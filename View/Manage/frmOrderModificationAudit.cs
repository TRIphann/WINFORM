using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JumpArena
{
    public partial class frmOrderModificationAudit : Form
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["JumpArenaContextDB"].ConnectionString;

        private int _selectedInvoiceId = 0;

        private int _managerUserId = 0;
        private string _managerName = "";

        private BillLineItem _selectedOldLine = null;

        // ====== MODEL BIND COMBOBOX ======
        private class BillItem
        {
            public int InvoiceID { get; set; }
            public DateTime CreatedDate { get; set; }
            public string CashierName { get; set; }
            public string Display { get; set; }
        }

        // Dòng sản phẩm trong bill (InvoiceDetail)
        private class BillLineItem
        {
            public int InvoiceDetailID { get; set; }
            public int OldProductID { get; set; }
            public string OldProductName { get; set; }
            public int OldQty { get; set; }
            public decimal OldPrice { get; set; }
            public string Display { get; set; }
        }

        public frmOrderModificationAudit()
        {
            InitializeComponent();

            this.Load += frmOrderModificationAudit_Load;

            cbModificationType.SelectedIndexChanged += cbModificationType_SelectedIndexChanged;
            cbNewProduct.SelectedIndexChanged += cbNewProduct_SelectedIndexChanged;

            btnVerifyManager.Click += btnVerifyManager_Click;
            btnProceedToModify.Click += btnProceedToModify_Click;

            btnProceedToModify.Enabled = false;
            lblAuthStatus.Text = "Trạng thái :";
        }

        private void frmOrderModificationAudit_Load(object sender, EventArgs e)
        {
            // Load bill cũ
            LoadOldBillsIntoLoai();

            // reset UI
            lblBillID.Text = "Mã Bill :";
            lblCreationTime.Text = "Thời gian tạo Bill :";
            lblOldTotal.Text = "Tổng tiền Bill Cũ :";
            lblCashier.Text = "Nhân viên bán hàng :";
            lblMaxTime.Text = "Thời gian Tối đa :";

            cbNewProduct.DataSource = null;
            cbNewProduct.Items.Clear();

            txtReasonDetail.Clear();
        }

        // =========================
        // LOẠI = BILL CŨ
        // =========================
        private void LoadOldBillsIntoLoai()
        {
            string sql = @"
SELECT TOP 200 
    i.InvoiceID,
    i.CreatedDate,
    ISNULL(u.FullName,'') AS CashierName
FROM Invoice i
LEFT JOIN [User] u ON i.UserID = u.UserID
WHERE (i.Status='Completed' OR i.PaymentStatus='Paid')
ORDER BY i.CreatedDate DESC;";

            var bills = new List<BillItem>();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        int id = rd.GetInt32(0);
                        DateTime created = rd.GetDateTime(1);
                        string cashier = rd.IsDBNull(2) ? "" : rd.GetString(2);

                        bills.Add(new BillItem
                        {
                            InvoiceID = id,
                            CreatedDate = created,
                            CashierName = cashier,
                            Display = $"{id:D4} | {created:dd/MM/yyyy HH:mm} | {cashier}"
                        });
                    }
                }
            }

            cbModificationType.DisplayMember = "Display";
            cbModificationType.ValueMember = "InvoiceID";
            cbModificationType.DataSource = bills;

            if (bills.Count > 0) cbModificationType.SelectedIndex = 0;
        }

        private void cbModificationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbModificationType.SelectedValue == null) return;

            _selectedInvoiceId = Convert.ToInt32(cbModificationType.SelectedValue);

            LoadBillHeader(_selectedInvoiceId);
            LoadBillLinesIntoLyDo(_selectedInvoiceId);

            // đổi bill thì bắt login lại cho chắc
            btnProceedToModify.Enabled = (_managerUserId > 0);
        }

        // =========================
        // HEADER BILL
        // =========================
        private void LoadBillHeader(int invoiceId)
        {
            string sql = @"
SELECT 
    i.InvoiceID,
    i.CreatedDate,
    ISNULL(i.TotalOriginalAmount,0) AS TotalOriginalAmount,
    ISNULL(i.DiscountAmount,0) AS DiscountAmount,
    ISNULL(u.FullName,'') AS CashierName
FROM Invoice i
LEFT JOIN [User] u ON i.UserID = u.UserID
WHERE i.InvoiceID = @id;";

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = invoiceId;

                    using (var rd = cmd.ExecuteReader())
                    {
                        if (!rd.Read()) return;

                        DateTime created = Convert.ToDateTime(rd["CreatedDate"]);
                        decimal total = Convert.ToDecimal(rd["TotalOriginalAmount"]);
                        decimal discount = Convert.ToDecimal(rd["DiscountAmount"]);
                        decimal payable = total - discount;
                        if (payable < 0) payable = 0;

                        string cashier = rd["CashierName"].ToString();

                        lblBillID.Text = "Mã Bill : " + invoiceId.ToString("D4");
                        lblCreationTime.Text = "Thời gian tạo Bill : " + created.ToString("dd/MM/yyyy HH:mm:ss");
                        lblOldTotal.Text = "Tổng tiền Bill Cũ : " + payable.ToString("N0") + " ₫";
                        lblCashier.Text = "Nhân viên bán hàng : " + cashier;

                        // bạn muốn giới hạn sửa trong 30 phút từ lúc tạo
                        lblMaxTime.Text = "Thời gian Tối đa : " + created.AddMinutes(30).ToString("dd/MM/yyyy HH:mm:ss");
                    }
                }
            }
        }

        // =========================
        // "LÝ DO" = DÒNG SẢN PHẨM CŨ TRONG BILL
        // (cbNewProduct trong designer của bạn đang đứng ở vị trí Lý do)
        // =========================
        private void LoadBillLinesIntoLyDo(int invoiceId)
        {
            string sql = @"
SELECT 
    d.InvoiceDetailID,
    d.ProductID,
    ISNULL(p.ProductName,'') AS ProductName,
    d.Quantity,
    d.PriceAtPurchase
FROM InvoiceDetail d
LEFT JOIN Product p ON d.ProductID = p.ProductID
WHERE d.InvoiceID = @id
ORDER BY p.ProductName;";

            var lines = new List<BillLineItem>();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = invoiceId;

                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int detailId = Convert.ToInt32(rd["InvoiceDetailID"]);
                            int pid = Convert.ToInt32(rd["ProductID"]);
                            string name = rd["ProductName"].ToString();
                            int qty = Convert.ToInt32(rd["Quantity"]);
                            decimal price = Convert.ToDecimal(rd["PriceAtPurchase"]);

                            lines.Add(new BillLineItem
                            {
                                InvoiceDetailID = detailId,
                                OldProductID = pid,
                                OldProductName = name,
                                OldQty = qty,
                                OldPrice = price,
                                Display = $"{name} | SL:{qty} | {price:N0} ₫"
                            });
                        }
                    }
                }
            }

            // QUAN TRỌNG: ValueMember phải tồn tại trong BillLineItem
            cbNewProduct.DisplayMember = "Display";
            cbNewProduct.ValueMember = "InvoiceDetailID";
            cbNewProduct.DataSource = lines;

            if (lines.Count > 0) cbNewProduct.SelectedIndex = 0;
        }

        private void cbNewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedOldLine = cbNewProduct.SelectedItem as BillLineItem;
            FillDetailTemplate();
        }

        // =========================
        // Chi tiết: nhét luôn vào textbox để bạn sửa trực tiếp
        // - Bạn sửa dòng "Sản phẩm:" thành sản phẩm mới
        // - ProductID sẽ tự cập nhật khi Fix (tìm theo ProductName)
        // =========================
        private void FillDetailTemplate()
        {
            if (_selectedOldLine == null) return;

            txtReasonDetail.Text =
                $"Sản phẩm: {_selectedOldLine.OldProductName}\r\n" +
                $"ProductID: (Sẽ tự động cập nhật)\r\n" +
                $"Số lượng: {_selectedOldLine.OldQty}\r\n" +
                $"Giá: {_selectedOldLine.OldPrice:N0} ₫\r\n";
        }

        // =========================
        // LOGIN quản lý
        // =========================
        private void btnVerifyManager_Click(object sender, EventArgs e)
        {
            string username = txtManagerUser.Text.Trim();
            string password = txtManagerPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblAuthStatus.Text = "Trạng thái : Thiếu thông tin";
                btnProceedToModify.Enabled = false;
                _managerUserId = 0;
                _managerName = "";
                return;
            }

            string sql = @"
SELECT TOP 1 u.UserID, ISNULL(u.FullName,''), ISNULL(r.RoleName,'')
FROM [User] u
LEFT JOIN Role r ON u.RoleID = r.RoleID
WHERE u.Username=@u AND u.Password=@p;";

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@u", SqlDbType.NVarChar).Value = username;
                    cmd.Parameters.Add("@p", SqlDbType.NVarChar).Value = password;

                    using (var rd = cmd.ExecuteReader())
                    {
                        if (!rd.Read())
                        {
                            lblAuthStatus.Text = "Trạng thái : Sai tài khoản/mật khẩu";
                            btnProceedToModify.Enabled = false;
                            _managerUserId = 0;
                            _managerName = "";
                            return;
                        }

                        string roleName = rd.GetString(2).ToLowerInvariant();

                        // check quyền, bạn muốn "quản lý"
                        if (!(roleName.Contains("manager") || roleName.Contains("quản")))
                        {
                            lblAuthStatus.Text = "Trạng thái : Không đủ quyền";
                            btnProceedToModify.Enabled = false;
                            _managerUserId = 0;
                            _managerName = "";
                            return;
                        }

                        _managerUserId = rd.GetInt32(0);
                        _managerName = rd.GetString(1);

                        lblAuthStatus.Text = "Trạng thái : OK - " + _managerName;
                        btnProceedToModify.Enabled = true;
                    }
                }
            }
        }

        // =========================
        // FIX bill: đổi 1 dòng sản phẩm theo InvoiceDetailID
        // - Sản phẩm mới lấy từ dòng "Sản phẩm:" trong textbox
        // - ProductID tự tìm trong bảng Product
        // - Update lại tổng invoice
        // - Update hiệu suất WorkShift (tuỳ schema)
        // - In bill (gọi form in bill của bạn)
        // =========================
        private void btnProceedToModify_Click(object sender, EventArgs e)
        {
            if (_managerUserId <= 0)
            {
                MessageBox.Show("Chưa xác thực quản lý.");
                return;
            }

            if (_selectedInvoiceId <= 0 || _selectedOldLine == null)
            {
                MessageBox.Show("Chưa chọn Bill / dòng sản phẩm cần sửa.");
                return;
            }

            // Parse textbox (bạn sửa trực tiếp ở đây)
            var parsed = ParseReasonDetailText(txtReasonDetail.Text);
            string newProductName = parsed.productName;
            int newQty = parsed.qty;
            decimal newPrice = parsed.price;

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var tran = conn.BeginTransaction();

                try
                {
                    // 1) tìm ProductID theo tên sản phẩm mới
                    int newProductId = FindProductIdByName(conn, tran, newProductName);

                    // 2) update 1 dòng InvoiceDetail
                    using (var cmd = new SqlCommand(@"
UPDATE InvoiceDetail
SET ProductID=@pid,
    Quantity=@qty,
    PriceAtPurchase=@price
WHERE InvoiceDetailID=@detailId;", conn, tran))
                    {
                        cmd.Parameters.Add("@pid", SqlDbType.Int).Value = newProductId;
                        cmd.Parameters.Add("@qty", SqlDbType.Int).Value = newQty;
                        cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = newPrice;
                        cmd.Parameters.Add("@detailId", SqlDbType.Int).Value = _selectedOldLine.InvoiceDetailID;

                        int affected = cmd.ExecuteNonQuery();
                        if (affected == 0) throw new Exception("Không sửa được dòng InvoiceDetail.");
                    }

                    // 3) tính lại TotalOriginalAmount theo InvoiceDetail
                    decimal newTotal = 0;
                    using (var cmd = new SqlCommand(@"
SELECT ISNULL(SUM(Quantity * PriceAtPurchase),0)
FROM InvoiceDetail
WHERE InvoiceID=@id;", conn, tran))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = _selectedInvoiceId;
                        newTotal = Convert.ToDecimal(cmd.ExecuteScalar());
                    }

                    using (var cmd = new SqlCommand(@"
UPDATE Invoice
SET TotalOriginalAmount=@t
WHERE InvoiceID=@id;", conn, tran))
                    {
                        cmd.Parameters.Add("@t", SqlDbType.Decimal).Value = newTotal;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = _selectedInvoiceId;
                        cmd.ExecuteNonQuery();
                    }

                    // 4) log chỉnh sửa (bạn có bảng OrderModificationLog/OrderModificationLogDetail)
                    // Nếu schema khác cột thì nó fail. Tôi bọc try để không phá giao dịch.
                    TryInsertModificationLog(conn, tran,
                        invoiceId: _selectedInvoiceId,
                        managerUserId: _managerUserId,
                        reasonText: txtReasonDetail.Text.Trim(),
                        oldProductId: _selectedOldLine.OldProductID,
                        newProductId: newProductId,
                        oldQty: _selectedOldLine.OldQty,
                        newQty: newQty,
                        oldPrice: _selectedOldLine.OldPrice,
                        newPrice: newPrice);

                    // 5) cập nhật hiệu suất ca làm (tuỳ schema, bạn phải chỉnh tên cột nếu khác)
                    TryUpdateWorkShiftPerformanceAfterInvoiceChange(conn, tran, _selectedInvoiceId);

                    tran.Commit();

                    MessageBox.Show("Sửa bill thành công.");

                    // reload UI
                    LoadBillHeader(_selectedInvoiceId);
                    LoadBillLinesIntoLyDo(_selectedInvoiceId);

                    // in bill đã sửa
                    OpenPrintBillForm(_selectedInvoiceId);
                }
                catch (Exception ex)
                {
                    try { tran.Rollback(); } catch { }
                    MessageBox.Show("Fix thất bại:\n" + ex.Message);
                }
            }
        }

        // =========================
        // PARSE chi tiết
        // =========================
        private (string productName, int qty, decimal price) ParseReasonDetailText(string text)
        {
            string name = "";
            int qty = 1;
            decimal price = 0;

            var lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var raw in lines)
            {
                var line = raw.Trim();

                if (line.StartsWith("Sản phẩm:", StringComparison.OrdinalIgnoreCase))
                    name = line.Substring("Sản phẩm:".Length).Trim();

                if (line.StartsWith("Số lượng:", StringComparison.OrdinalIgnoreCase))
                {
                    var s = line.Substring("Số lượng:".Length).Trim();
                    var digits = new string(s.Where(char.IsDigit).ToArray());
                    if (int.TryParse(digits, out var v)) qty = v;
                    if (qty <= 0) qty = 1;
                }

                if (line.StartsWith("Giá:", StringComparison.OrdinalIgnoreCase))
                {
                    var s = line.Substring("Giá:".Length).Trim();
                    var digits = new string(s.Where(char.IsDigit).ToArray());
                    if (decimal.TryParse(digits, out var v)) price = v;
                }
            }

            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Chi tiết thiếu dòng 'Sản phẩm:'");

            if (price <= 0)
                throw new Exception("Chi tiết thiếu/không hợp lệ dòng 'Giá:'");

            return (name, qty, price);
        }

        // =========================
        // FIND ProductID theo tên (exact trước, rồi LIKE)
        // =========================
        private int FindProductIdByName(SqlConnection conn, SqlTransaction tran, string productName)
        {
            // exact
            using (var cmd = new SqlCommand("SELECT TOP 1 ProductID FROM Product WHERE ProductName=@n;", conn, tran))
            {
                cmd.Parameters.Add("@n", SqlDbType.NVarChar).Value = productName;
                var rs = cmd.ExecuteScalar();
                if (rs != null) return Convert.ToInt32(rs);
            }

            // like
            using (var cmd = new SqlCommand("SELECT TOP 1 ProductID FROM Product WHERE ProductName LIKE @n ORDER BY LEN(ProductName);", conn, tran))
            {
                cmd.Parameters.Add("@n", SqlDbType.NVarChar).Value = "%" + productName + "%";
                var rs = cmd.ExecuteScalar();
                if (rs != null) return Convert.ToInt32(rs);
            }

            throw new Exception("Không tìm thấy Product theo tên: " + productName);
        }

        // =========================
        // LOG chỉnh sửa (bọc try để schema lệch vẫn không chết)
        // =========================
        private void TryInsertModificationLog(
            SqlConnection conn, SqlTransaction tran,
            int invoiceId, int managerUserId, string reasonText,
            int oldProductId, int newProductId,
            int oldQty, int newQty,
            decimal oldPrice, decimal newPrice)
        {
            try
            {
                // Bạn có 2 bảng: OrderModificationLog + OrderModificationLogDetail
                // Nếu tên cột khác, bạn tự sửa.
                int logId = 0;

                using (var cmd = new SqlCommand(@"
INSERT INTO OrderModificationLog(InvoiceID, ManagerUserID, ReasonDetail, CreatedAt)
VALUES (@inv, @mgr, @reason, GETDATE());
SELECT CAST(SCOPE_IDENTITY() AS INT);", conn, tran))
                {
                    cmd.Parameters.Add("@inv", SqlDbType.Int).Value = invoiceId;
                    cmd.Parameters.Add("@mgr", SqlDbType.Int).Value = managerUserId;
                    cmd.Parameters.Add("@reason", SqlDbType.NVarChar).Value = reasonText;
                    logId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (var cmd = new SqlCommand(@"
INSERT INTO OrderModificationLogDetail(LogID, OldProductID, NewProductID, OldQty, NewQty, OldPrice, NewPrice)
VALUES (@log, @oldPid, @newPid, @oldQty, @newQty, @oldPrice, @newPrice);", conn, tran))
                {
                    cmd.Parameters.Add("@log", SqlDbType.Int).Value = logId;
                    cmd.Parameters.Add("@oldPid", SqlDbType.Int).Value = oldProductId;
                    cmd.Parameters.Add("@newPid", SqlDbType.Int).Value = newProductId;
                    cmd.Parameters.Add("@oldQty", SqlDbType.Int).Value = oldQty;
                    cmd.Parameters.Add("@newQty", SqlDbType.Int).Value = newQty;
                    cmd.Parameters.Add("@oldPrice", SqlDbType.Decimal).Value = oldPrice;
                    cmd.Parameters.Add("@newPrice", SqlDbType.Decimal).Value = newPrice;
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                // schema lệch thì thôi, không giết transaction
            }
        }

        // =========================
        // Cập nhật hiệu suất WorkShift (tuỳ schema)
        // Nếu WorkShift bạn KHÔNG có cột tổng, bạn comment hàm này cũng được.
        // =========================
        private void TryUpdateWorkShiftPerformanceAfterInvoiceChange(SqlConnection conn, SqlTransaction tran, int invoiceId)
        {
            try
            {
                DateTime created;
                int cashierUserId;

                using (var cmd = new SqlCommand("SELECT CreatedDate, UserID FROM Invoice WHERE InvoiceID=@id", conn, tran))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = invoiceId;
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (!rd.Read()) return;
                        created = rd.GetDateTime(0);
                        cashierUserId = rd.GetInt32(1);
                    }
                }

                int workShiftId = 0;
                using (var cmd = new SqlCommand(@"
SELECT TOP 1 WorkShiftID
FROM WorkShift
WHERE UserID=@uid
  AND StartTime <= @t
  AND (EndTime IS NULL OR EndTime >= @t)
ORDER BY StartTime DESC;", conn, tran))
                {
                    cmd.Parameters.Add("@uid", SqlDbType.Int).Value = cashierUserId;
                    cmd.Parameters.Add("@t", SqlDbType.DateTime).Value = created;
                    var rs = cmd.ExecuteScalar();
                    if (rs == null) return;
                    workShiftId = Convert.ToInt32(rs);
                }

                DateTime startTime;
                DateTime? endTime = null;

                using (var cmd = new SqlCommand("SELECT StartTime, EndTime FROM WorkShift WHERE WorkShiftID=@sid", conn, tran))
                {
                    cmd.Parameters.Add("@sid", SqlDbType.Int).Value = workShiftId;
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (!rd.Read()) return;
                        startTime = rd.GetDateTime(0);
                        if (!rd.IsDBNull(1)) endTime = rd.GetDateTime(1);
                    }
                }

                DateTime endCalc = endTime ?? DateTime.Now;

                // bạn tự chỉnh điều kiện Paid/Completed nếu muốn lọc
                using (var cmd = new SqlCommand(@"
SELECT
    COUNT(*) AS TotalInvoices,
    ISNULL(SUM(TotalOriginalAmount),0) AS TotalAmount,
    ISNULL(SUM(DiscountAmount),0) AS TotalDiscount
FROM Invoice
WHERE UserID=@uid
  AND CreatedDate >= @start
  AND CreatedDate <= @end;", conn, tran))
                {
                    cmd.Parameters.Add("@uid", SqlDbType.Int).Value = cashierUserId;
                    cmd.Parameters.Add("@start", SqlDbType.DateTime).Value = startTime;
                    cmd.Parameters.Add("@end", SqlDbType.DateTime).Value = endCalc;

                    int totalInvoices = 0;
                    decimal totalAmount = 0;
                    decimal totalDiscount = 0;

                    using (var rd = cmd.ExecuteReader())
                    {
                        rd.Read();
                        totalInvoices = Convert.ToInt32(rd["TotalInvoices"]);
                        totalAmount = Convert.ToDecimal(rd["TotalAmount"]);
                        totalDiscount = Convert.ToDecimal(rd["TotalDiscount"]);
                    }

                    // CHỈ CHẠY NẾU WorkShift có các cột này. Không có thì SQL sẽ fail và bị catch.
                    using (var upd = new SqlCommand(@"
UPDATE WorkShift
SET TotalInvoices=@ti,
    TotalAmount=@ta,
    TotalDiscount=@td,
    LastUpdate=GETDATE()
WHERE WorkShiftID=@sid;", conn, tran))
                    {
                        upd.Parameters.Add("@ti", SqlDbType.Int).Value = totalInvoices;
                        upd.Parameters.Add("@ta", SqlDbType.Decimal).Value = totalAmount;
                        upd.Parameters.Add("@td", SqlDbType.Decimal).Value = totalDiscount;
                        upd.Parameters.Add("@sid", SqlDbType.Int).Value = workShiftId;
                        upd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                // schema khác thì thôi
            }
        }

        // =========================
        // IN BILL: bạn thay bằng form in bill thật
        // =========================
        private void OpenPrintBillForm(int invoiceId)
        {
            // TODO: thay bằng form in bill của bạn
            // Ví dụ:
            // using (var f = new frmInvoice(invoiceId)) f.ShowDialog();

            MessageBox.Show("TODO: Gọi form in bill với InvoiceID=" + invoiceId);
        }
    }
}
