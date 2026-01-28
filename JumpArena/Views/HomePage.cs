using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using YourProjectNamespace;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JumpArena
{
    public partial class HomePage : Form
    {
        private readonly string connectionString;
        private List<ProductData> allProducts = new List<ProductData>();
        private List<ProductData> currentProducts = new List<ProductData>();
        private List<OrderItem> orderItems = new List<OrderItem>();
        private readonly int currentRoleID;
        private int currentPage = 0;
        private const int pageSize = 12;
        private bool isNewInvoiceCreated = false;
        private int currentInvoiceID = 0;

        public HomePage(int roleID)
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager  .ConnectionStrings["JumpArenaContextDB"].ConnectionString;

            SetupDataGridView();
            this.currentRoleID = roleID;
            SetupButtonPermissions();
            btnLogout.Click += BtnLogout_Click;

            // Thêm event handlers cho các nút lọc, tìm kiếm, và phân trang
            btnVe.Click += BtnVe_Click;
            btnVo.Click += BtnVo_Click;
            btnDoUong.Click += BtnDoUong_Click;
            btnCombo.Click += BtnCombo_Click;
            btnAllFilter.Click += BtnAllFilter_Click;
            btnSearch.Click += BtnSearch_Click;
            btnScrollLeft.Click += BtnScrollLeft_Click;
            btnScrollRight.Click += BtnScrollRight_Click;

            // Thêm event handlers mới theo yêu cầu
            btnNew.Click += BtnNew_Click;
            btnPayment.Click += BtnPayment_Click;
            dgvOrderItems.CellContentClick += DgvOrderItems_CellContentClick;

            LoadProducts();
            CreateInvoiceOnStartupIfNeeded();

            // Vừa vào app là có Bill No luôn
            CreateNewInvoiceAndResetUI(false);

        }
        private void CreateInvoiceOnStartupIfNeeded()
        {
            if (isNewInvoiceCreated && currentInvoiceID > 0) return;

            currentInvoiceID = CreateNewInvoicePending();   // chỉ gọi 1 lần khi mở app (hoặc sau payment)
            txtBillNo.Text = currentInvoiceID.ToString("D4");
            isNewInvoiceCreated = true;

            // clear UI
            ResetBillUIOnly();
        }

        private int CreateNewInvoicePending()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
INSERT INTO Invoice (CreatedDate, TotalOriginalAmount, DiscountAmount, Status, PaymentStatus)
VALUES (GETDATE(), 0, 0, 'Pending', 'Unpaid');
SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private void ResetBillUIOnly()
        {
            // reset giỏ hàng + UI, KHÔNG tạo invoice mới
            orderItems.Clear();
            ((BindingList<OrderItem>)dgvOrderItems.DataSource).ResetBindings();
            UpdateOrderSummary();

            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerName.Focus();
        }

        private void ResetCurrentInvoiceInDb()
        {
            // reset dữ liệu của invoice hiện tại về rỗng (tuỳ DB bạn có bảng chi tiết invoice)
            // Nếu bạn có bảng InvoiceItem/CTHoaDon thì xoá ở đây.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Ví dụ: nếu có bảng InvoiceItem lưu sản phẩm:
                // using (SqlCommand cmd = new SqlCommand("DELETE FROM InvoiceItem WHERE InvoiceID=@id", conn))
                // { cmd.Parameters.AddWithValue("@id", currentInvoiceID); cmd.ExecuteNonQuery(); }

                // Xoá payment tạm nếu có:
                using (SqlCommand cmd = new SqlCommand("DELETE FROM PaymentTransaction WHERE InvoiceID=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", currentInvoiceID);
                    cmd.ExecuteNonQuery();
                }

                // Reset header invoice
                using (SqlCommand cmd = new SqlCommand(@"
UPDATE Invoice
SET TotalOriginalAmount = 0,
    DiscountAmount = 0,
    Status = 'Pending',
    PaymentStatus = 'Unpaid'
WHERE InvoiceID = @id;", conn))
                {
                    cmd.Parameters.AddWithValue("@id", currentInvoiceID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmSelectRole.SelectedRole.Clear();
                this.Hide();
                frmSelectRole selectRoleForm = new frmSelectRole();
                selectRoleForm.ShowDialog();
                this.Close();
            }
        }

        // =============================================
        // PHÂN QUYỀN CÁC NÚT TRONG Header
        // =============================================
        private void SetupButtonPermissions()
        {
            // Gán sự kiện click cho tất cả các nút
            btnCheckInOut.Click += BtnCheckInOut_Click;
            btnProduct.Click += BtnProduct_Click;
            btnVoucher.Click += BtnVoucher_Click;
            btnStorage.Click += BtnStorage_Click;
            btnOnline.Click += BtnOnline_Click;
            btnPerformance.Click += BtnPerformance_Click;
            btnBestSellers.Click += BtnBestSellers_Click;
            btnReport.Click += BtnReport_Click;
            btnBillSearch.Click += BtnBillSearch_Click;
        }

        // RoleID = 1, 2: Check In/Out
        private void BtnCheckInOut_Click(object sender, EventArgs e)
        {
            if (currentRoleID == 1 || currentRoleID == 2)
            {
                OpenForm(typeof(frmCheck_in), "Check In/Out");
            }
            else
            {
                ShowNoPermissionMessage();
            }
        }

        // RoleID = 2: Inventory Management, RoleID = 4: Add Product
        private void BtnProduct_Click(object sender, EventArgs e)
        {
            if (currentRoleID == 2)
            {
                OpenForm(typeof(frmInventoryManagement), "Quản lý kho");
            }
            else if (currentRoleID == 4)
            {
                OpenForm(typeof(AddProductForm), "Thêm sản phẩm");
            }
            else
            {
                ShowNoPermissionMessage();
            }
        }

        // RoleID = 3: Under construction, RoleID = 4: Create Voucher
        private void BtnVoucher_Click(object sender, EventArgs e)
        {
            if (currentRoleID == 3)
            {
                MessageBox.Show("Form đang chưa hoàn thiện!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (currentRoleID == 4)
            {
                OpenForm(typeof(CreateVoucherForm), "Tạo voucher");
            }
            else
            {
                ShowNoPermissionMessage();
            }
        }

        // RoleID = 2: Inventory Performance, RoleID = 3: Invoice Confirmation
        private void BtnStorage_Click(object sender, EventArgs e)
        {
            if (currentRoleID == 2)
            {
                OpenForm(typeof(frmInventoryPerformanceReport), "Báo cáo hiệu suất kho");
            }
            else if (currentRoleID == 3)
            {
                OpenForm(typeof(frmInvoiceConfirmation), "Xác nhận hóa đơn");
            }
            else
            {
                ShowNoPermissionMessage();
            }
        }

        // RoleID = 2: Work Shift Management, RoleID = 4: Company Accounts
        private void BtnOnline_Click(object sender, EventArgs e)
        {
            if (currentRoleID == 2)
            {
                OpenForm(typeof(frmWorkShiftManagement), "Quản lý ca làm việc");
            }
            else if (currentRoleID == 4)
            {
                OpenForm(typeof(CompanyAccountsForm), "Tài khoản công ty");
            }
            else
            {
                ShowNoPermissionMessage();
            }
        }

        // RoleID = 1, 2: Shift Performance
        private void BtnPerformance_Click(object sender, EventArgs e)
        {
            if (currentRoleID == 1 || currentRoleID == 2)
            {
                OpenForm(typeof(frmShiftPerformance), "Hiệu suất ca làm");
            }
            else
            {
                ShowNoPermissionMessage();
            }
        }

        // RoleID = 3: Under construction
        private void BtnBestSellers_Click(object sender, EventArgs e)
        {
            if (currentRoleID == 3)
            {
                MessageBox.Show("Form đang chưa hoàn thiện!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ShowNoPermissionMessage();
            }
        }

        // RoleID = 1, 2: Report To Server, RoleID = 3: Under construction, RoleID = 4: Report and Feedback
        private void BtnReport_Click(object sender, EventArgs e)
        {
            if (currentRoleID == 1 || currentRoleID == 2)
            {
                OpenForm(typeof(frmReportToServer), "Báo cáo");
            }
            else if (currentRoleID == 3)
            {
                MessageBox.Show("Form đang chưa hoàn thiện!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (currentRoleID == 4)
            {
                OpenForm(typeof(ReportAndFeedbackForm), "Báo cáo và phản hồi");
            }
            else
            {
                ShowNoPermissionMessage();
            }
        }

        // RoleID = 2: Order Modification Audit, RoleID = 3: Audit Log
        private void BtnBillSearch_Click(object sender, EventArgs e)
        {
            if (currentRoleID == 2)
            {
                OpenForm(typeof(frmOrderModificationAudit), "Kiểm tra đơn hàng");
            }
            else if (currentRoleID == 3)
            {
                OpenForm(typeof(frmAuditLog), "Nhật ký kiểm toán");
            }
            else
            {
                ShowNoPermissionMessage();
            }
        }

        // Helper method để mở form
        private void OpenForm(Type formType, string formName)
        {
            try
            {
                Form form = (Form)Activator.CreateInstance(formType);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form {formName}: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method để hiển thị thông báo không có quyền
        private void ShowNoPermissionMessage()
        {
            MessageBox.Show("Bạn không có quyền thực hiện chức năng này!",
                "Không được phép", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // =============================================
        // CẤU HÌNH DATAGRIDVIEW VÀ TẢI SẢN PHẨM
        // =============================================
        private void SetupDataGridView()
        {
            dgvOrderItems.AutoGenerateColumns = false;
            colDescription.DataPropertyName = nameof(OrderItem.Description);
            colQuantity.DataPropertyName = nameof(OrderItem.Quantity);
            colTotal.DataPropertyName = nameof(OrderItem.Total);
            dgvOrderItems.DataSource = new BindingList<OrderItem>(orderItems);
        }

        private void LoadProducts()
        {
            allProducts.Clear();
            string query = @"
                SELECT p.ProductID, p.ProductName, p.Description, p.Price, p.StockQuantity, c.CategoryID, c.CategoryName
                FROM Product p
                LEFT JOIN Category c ON p.CategoryID = c.CategoryID
                ORDER BY p.ProductID;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())

                    {
                        while (reader.Read())
                        {
                            allProducts.Add(new ProductData
                            {
                                ProductID = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Price = reader.GetDecimal(3),
                                StockQuantity = reader.GetInt32(4),
                                CategoryID = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),
                                CategoryName = reader.IsDBNull(6) ? null : reader.GetString(6)
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi tải sản phẩm:\n\n" + ex.ToString(),
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

            }

            // Đặt currentProducts ban đầu là tất cả sản phẩm
            ResetFilters();
        }

        private void DisplayPage()
        {
            var productsToDisplay = currentProducts.Skip(currentPage * pageSize).Take(pageSize).ToList();
            DisplayProducts(productsToDisplay);
            UpdateDots();
        }

        private void DisplayProducts(List<ProductData> products)
        {
            var productControls = new List<(Panel panel, Label name, Label price, PictureBox pb, Button btn)>
            {
                (pnlProduce1, lblProductName1, lblPrice1, pbJump1, btnAddToCart1),
                (pnlProduce2, lblProductName2, lblPrice2, pbJump2, btnAddToCart2),
                (pnlProduce3, lblProductName3, lblPrice3, pbJump3, btnAddToCart3),
                (pnlProduce4, lblProductName4, lblPrice4, pbJump4, btnAddToCart4),
                (pnlProduce5, lblProductName5, lblPrice5, pbJump5, btnAddToCart5),
                (pnlProduce6, lblProductName6, lblPrice6, pbJump6, btnAddToCart6),
                (pnlProduce7, lblProductName7, lblPrice7, pbJump7, btnAddToCart7),
                (pnlProduce8, lblProductName8, lblPrice8, pbJump8, btnAddToCart8),
                (pnlProduce9, lblProductName9, lblPrice9, pbJump9, btnAddToCart9),
                (pnlProduce10, lblProductName10, lblPrice10, pbJump10, btnAddToCart10),
                (pnlProduce11, lblProductName11, lblPrice11, pbJump11, btnAddToCart11),
                (pnlProduce12, lblProductName12, lblPrice12, pbJump12, btnAddToCart12)
            };

            for (int i = 0; i < productControls.Count; i++)
            {
                var ctrl = productControls[i];
                if (i < products.Count)
                {
                    ctrl.name.Text = products[i].ProductName;
                    ctrl.price.Text = string.Format("{0:N0} ₫", products[i].Price);
                    if (!string.IsNullOrEmpty(products[i].CategoryName))
                        ctrl.price.Text += " / " + products[i].CategoryName;
                    ctrl.panel.Tag = products[i].ProductID;
                    ctrl.panel.Visible = true;
                    ctrl.btn.Click -= BtnAddToCart_Click;
                    ctrl.btn.Click += BtnAddToCart_Click;
                }
                else
                {
                    ctrl.panel.Visible = false;
                }
            }
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (!isNewInvoiceCreated)
            {
                MessageBox.Show("Vui lòng tạo hóa đơn mới trước khi thêm sản phẩm!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Button btn = (Button)sender;
            Panel panel = (Panel)btn.Parent;
            if (panel.Tag is int productId)
            {
                var product = allProducts.FirstOrDefault(p => p.ProductID == productId);
                if (product != null)
                {
                    var item = orderItems.FirstOrDefault(x => x.ProductID == productId);
                    if (item != null)
                        item.Quantity++;
                    else
                        orderItems.Add(new OrderItem
                        {
                            ProductID = productId,
                            Description = product.ProductName,
                            Price = product.Price,
                            Quantity = 1
                        });

                    ((BindingList<OrderItem>)dgvOrderItems.DataSource).ResetBindings();
                    UpdateOrderSummary();
                }
            }
        }

        private void UpdateOrderSummary()
        {
            decimal total = orderItems.Sum(x => x.Total);
            decimal discount = 0;
            decimal payable = total - discount;

            lblBillTotalValue.Text = string.Format("{0:N0} ₫", total);
            lblTotalDiscountValue.Text = string.Format("{0:N0} ₫", discount);
            lblTotaPayable.Text = string.Format("{0:N0} ₫", payable);
        }
        private decimal GetCurrentPayable()
        {
            // Bạn đang set payable = total - discount trong UpdateOrderSummary()
            decimal total = orderItems.Sum(x => x.Total);
            decimal discount = 0;
            return total - discount;
        }

        private void EnsureInvoiceDetailsSaved()
        {
            // Lưu orderItems vào InvoiceDetail (xóa cũ rồi insert lại cho sạch)
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Xóa detail cũ nếu có
                        using (SqlCommand cmdDel = new SqlCommand(
                            "DELETE FROM InvoiceDetail WHERE InvoiceID = @InvoiceID", conn, tran))
                        {
                            cmdDel.Parameters.AddWithValue("@InvoiceID", currentInvoiceID);
                            cmdDel.ExecuteNonQuery();
                        }

                        // Insert detail mới
                        string sqlIns = @"
INSERT INTO InvoiceDetail (Quantity, PriceAtPurchase, InvoiceID, ProductID)
VALUES (@Qty, @Price, @InvoiceID, @ProductID);";

                        foreach (var item in orderItems)
                        {
                            using (SqlCommand cmdIns = new SqlCommand(sqlIns, conn, tran))
                            {
                                cmdIns.Parameters.AddWithValue("@Qty", item.Quantity);
                                cmdIns.Parameters.AddWithValue("@Price", item.Price);
                                cmdIns.Parameters.AddWithValue("@InvoiceID", currentInvoiceID);
                                cmdIns.Parameters.AddWithValue("@ProductID", item.ProductID);
                                cmdIns.ExecuteNonQuery();
                            }
                        }

                        // Update tổng tiền trên Invoice
                        decimal total = orderItems.Sum(x => x.Total);
                        decimal discount = 0;

                        using (SqlCommand cmdUpd = new SqlCommand(@"
UPDATE Invoice
SET TotalOriginalAmount = @Total,
    DiscountAmount = @Discount
WHERE InvoiceID = @InvoiceID;", conn, tran))
                        {
                            cmdUpd.Parameters.AddWithValue("@Total", total);
                            cmdUpd.Parameters.AddWithValue("@Discount", discount);
                            cmdUpd.Parameters.AddWithValue("@InvoiceID", currentInvoiceID);
                            cmdUpd.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }


        // =============================================
        // XỬ LÝ PHÂN TRANG
        // =============================================
        private void BtnScrollLeft_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                DisplayPage();
            }
        }

        private void BtnScrollRight_Click(object sender, EventArgs e)
        {
            int maxPage = (currentProducts.Count - 1) / pageSize;
            if (currentPage < maxPage)
            {
                currentPage++;
                DisplayPage();
            }
        }

        private void UpdateDots()
        {
            // Giả sử chỉ có 3 dots, chúng ta sẽ ẩn/hiện và đánh dấu active
            // Nếu số trang > 3, có thể cần mở rộng, nhưng tạm thời xử lý cho <=3
            int totalPages = ((currentProducts.Count - 1) / pageSize) + 1;
            var dots = new[] { lblDot1, lblDot2, lblDot3 };

            for (int i = 0; i < dots.Length; i++)
            {
                if (i < totalPages)
                {
                    dots[i].Visible = true;
                    dots[i].ForeColor = (i == currentPage) ? Color.Red : Color.Black;
                }
                else
                {
                    dots[i].Visible = false;
                }
            }
        }

        // =============================================
        // XỬ LÝ LỌC THEO DANH MỤC
        // =============================================
        private void BtnVe_Click(object sender, EventArgs e)
        {
            FilterByCategory(1); // CategoryID cho Vé vui chơi
        }

        private void BtnVo_Click(object sender, EventArgs e)
        {
            FilterByCategory(2); // CategoryID cho Vớ
        }

        private void BtnDoUong_Click(object sender, EventArgs e)
        {
            FilterByCategory(3); // CategoryID cho Đồ uống
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FilterByCategory(4); // CategoryID cho Combo
        }

        private void FilterByCategory(int categoryId)
        {
            currentProducts = allProducts.Where(p => p.CategoryID == categoryId).ToList();
            currentPage = 0;
            DisplayPage();
        }

        // =============================================
        // XỬ LÝ TÌM KIẾM
        // =============================================
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtProductSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(searchText))
            {
                currentProducts = allProducts.Where(p => p.ProductName.ToLower().Contains(searchText)).ToList();
            }
            else
            {
                currentProducts = allProducts.ToList();
            }
            currentPage = 0;
            DisplayPage();
        }

        // =============================================
        // RESET BỘ LỌC
        // =============================================
        private void BtnAllFilter_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        private void ResetFilters()
        {
            currentProducts = allProducts.ToList();
            currentPage = 0;
            txtProductSearch.Clear();
            DisplayPage();
        }

        // =============================================
        // CHỨC NĂNG MỚI: TẠO HÓA ĐƠN MỚI
        // =============================================
        // =============================================
        // CHỨC NĂNG MỚI: TẠO HÓA ĐƠN MỚI
        // =============================================
        // =============================================
        // CHỨC NĂNG MỚI: TẠO HÓA ĐƠN MỚI
        // =============================================

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (!isNewInvoiceCreated || currentInvoiceID <= 0)
            {
                // nếu vì lý do nào đó chưa có invoice thì tạo 1 cái
                CreateInvoiceOnStartupIfNeeded();
                return;
            }

            DialogResult result = MessageBox.Show(
                "Tạo đơn mới (reset bill hiện tại). Dữ liệu đang chọn sẽ bị xóa.",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                // reset DB + UI nhưng GIỮ nguyên InvoiceID hiện tại => BillNo không đổi
                ResetCurrentInvoiceInDb();
                ResetBillUIOnly();

                txtBillNo.Text = currentInvoiceID.ToString("D4"); // vẫn 0034
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi reset hóa đơn: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CreateNewInvoiceAndResetUI(bool askConfirmIfCurrentHasData)
        {
            if (askConfirmIfCurrentHasData)
            {
                bool hasAnyData = orderItems.Count > 0
                                  || !string.IsNullOrWhiteSpace(txtCustomerName.Text)
                                  || !string.IsNullOrWhiteSpace(txtCustomerPhone.Text);

                if (hasAnyData)
                {
                    var result = MessageBox.Show(
                        "Bạn đang có dữ liệu trên hóa đơn. Tạo hóa đơn mới sẽ xóa dữ liệu hiện tại. Tiếp tục?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result != DialogResult.Yes) return;
                }
            }

            // Reset UI
            orderItems.Clear();
            ((BindingList<OrderItem>)dgvOrderItems.DataSource).ResetBindings();
            UpdateOrderSummary();

            txtCustomerName.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;

            // Create new invoice in DB
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
INSERT INTO Invoice (CreatedDate, TotalOriginalAmount, DiscountAmount, Status, PaymentStatus)
VALUES (GETDATE(), 0, 0, 'Pending', 'Unpaid');
SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    currentInvoiceID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            txtBillNo.Text = currentInvoiceID.ToString("D4");
            isNewInvoiceCreated = true;

            txtCustomerName.Focus();
        }


        // =============================================
        // CHỨC NĂNG MỚI: XÓA SẢN PHẨM KHỎI GIỎ HÀNG
        // =============================================
        private void DgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colDelete.Index && e.RowIndex >= 0)
            {
                orderItems.RemoveAt(e.RowIndex);
                ((BindingList<OrderItem>)dgvOrderItems.DataSource).ResetBindings();
                UpdateOrderSummary();
            }
        }

        // =============================================
        // CHỨC NĂNG MỚI: THANH TOÁN
        // =============================================
        private void BtnPayment_Click(object sender, EventArgs e)
        {
            if (!isNewInvoiceCreated || currentInvoiceID <= 0)
            {
                MessageBox.Show("Hóa đơn chưa sẵn sàng.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (orderItems.Count == 0)
            {
                MessageBox.Show("Hóa đơn phải có ít nhất 1 sản phẩm!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtCustomerName.Text.Trim()) || string.IsNullOrEmpty(txtCustomerPhone.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên khách hàng và số điện thoại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal total = orderItems.Sum(x => x.Total);

            // mở payment và CHỜ kết quả
            using (var f = new frmPayments(currentInvoiceID, txtCustomerName.Text.Trim(), txtCustomerPhone.Text.Trim(), total))
            {
                var rs = f.ShowDialog();

                if (rs == DialogResult.OK)
                {
                    // thanh toán xong => tạo hóa đơn mới (bill +1)
                    currentInvoiceID = CreateNewInvoicePending();
                    txtBillNo.Text = currentInvoiceID.ToString("D4"); // 0035
                    isNewInvoiceCreated = true;

                    ResetBillUIOnly();
                }
            }
        }




        private void tableLayoutBillHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }
    }

    public class ProductData
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int? CategoryID { get; set; }
        public string CategoryName { get; set; }
    }

    public class OrderItem
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total => Price * Quantity;
    }
}