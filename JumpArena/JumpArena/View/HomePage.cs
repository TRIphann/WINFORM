using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thêm thư viện này

namespace JumpArena
{
    // =============================================
    // KHAI BÁO CẤU TRÚC DỮ LIỆU BÊN NGOÀI HOMEPAGE
    // =============================================

    // Class đại diện cho dữ liệu Sản phẩm lấy từ DB
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

    // Class đại diện cho một mục trong giỏ hàng (tại dgvOrderItems)
    public class OrderItem
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } // Giá bán tại thời điểm thêm
        public int Quantity { get; set; }
        public decimal Total => Price * Quantity;
    }

    public partial class HomePage : Form
    {
        // =============================================
        // KHAI BÁO BIẾN TRONG HOMEPAGE
        // =============================================
        // Chuỗi kết nối đến SQL Server.
        // Cần thay thế YOUR_SERVER_NAME bằng tên máy chủ của bạn.
        private const string connectionString = "Data Source=LAPTOP-0KAUS2R2;Initial Catalog=JumpArenaDB;Integrated Security=True;";

        // Danh sách lưu trữ tất cả sản phẩm tải từ DB
        private List<ProductData> allProducts = new List<ProductData>();

        // Danh sách lưu trữ các mục trong giỏ hàng
        private List<OrderItem> orderItems = new List<OrderItem>();


        // =============================================
        // CONSTRUCTOR VÀ CÁC SỰ KIỆN CHÍNH
        // =============================================
        public HomePage()
        {
            InitializeComponent();
            btnLogout.Click += BtnLogout_Click;

            // Cấu hình DataGridView
            SetupDataGridView();

            // Gọi phương thức tải dữ liệu khi Form khởi tạo
            LoadProducts();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // =============================================
        // THIẾT LẬP DATA GRID VIEW
        // =============================================
        private void SetupDataGridView()
        {
            // Tắt tự động tạo cột vì đã có 3 cột được định nghĩa trong Designer
            dgvOrderItems.AutoGenerateColumns = false;

            // Ánh xạ cột với thuộc tính của class OrderItem
            colDescription.DataPropertyName = nameof(OrderItem.Description);
            colQuantity.DataPropertyName = nameof(OrderItem.Quantity);
            colTotal.DataPropertyName = nameof(OrderItem.Total);

            // Gán nguồn dữ liệu
            dgvOrderItems.DataSource = new BindingList<OrderItem>(orderItems);
        }

        // =============================================
        // LOGIC KẾT NỐI VÀ TẢI DỮ LIỆU SẢN PHẨM
        // =============================================
        private void LoadProducts()
        {
            allProducts.Clear();

            // Lệnh SQL kết hợp Product và Category 
            string query = @"
                SELECT 
                    p.ProductID, 
                    p.ProductName, 
                    p.Description, 
                    p.Price, 
                    p.StockQuantity,
                    c.CategoryName 
                FROM Product p
                LEFT JOIN Category c ON p.CategoryID = c.CategoryID
                ORDER BY p.ProductID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
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
                                    CategoryName = reader.IsDBNull(5) ? null : reader.GetString(5)
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Hiển thị sản phẩm lên các panel (Giả sử bạn chỉ hiển thị 12 sản phẩm đầu tiên)
            DisplayProducts(allProducts.Take(12).ToList());
        }

        // Phương thức để điền dữ liệu vào các control của sản phẩm
        private void DisplayProducts(List<ProductData> products)
        {
            // Danh sách các control để dễ dàng truy cập và điền dữ liệu
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
                var controls = productControls[i];
                if (i < products.Count)
                {
                    // Hiển thị thông tin sản phẩm
                    controls.name.Text = products[i].ProductName;
                    // Định dạng giá tiền
                    controls.price.Text = string.Format("{0:N0} / {1}", products[i].Price, products[i].CategoryName);
                    controls.panel.Tag = products[i].ProductID; // Lưu ProductID vào Tag 

                    // Thiết lập hình ảnh (Cần thêm logic tải hình ảnh nếu có)
                    // controls.pb.Image = /* Logic tải hình ảnh */; 

                    controls.panel.Visible = true;
                    // Thêm sự kiện click cho nút "THÊM VÀO GIỎ"
                    controls.btn.Click -= BtnAddToCart_Click;
                    controls.btn.Click += BtnAddToCart_Click;
                }
                else
                {
                    // Ẩn các panel không có sản phẩm để hiển thị
                    controls.panel.Visible = false;
                }
            }
        }

        // =============================================
        // LOGIC GIỎ HÀNG VÀ THANH TOÁN
        // =============================================

        // Xử lý sự kiện khi nhấn nút "THÊM VÀO GIỎ"
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Panel productPanel = (Panel)btn.Parent;

            if (productPanel.Tag is int productID)
            {
                ProductData selectedProduct = allProducts.FirstOrDefault(p => p.ProductID == productID);

                if (selectedProduct != null)
                {
                    // Kiểm tra xem sản phẩm đã có trong giỏ hàng chưa
                    OrderItem existingItem = orderItems.FirstOrDefault(item => item.ProductID == productID);

                    if (existingItem != null)
                    {
                        // Nếu có, tăng số lượng
                        existingItem.Quantity++;
                    }
                    else
                    {
                        // Nếu chưa, thêm mục mới
                        orderItems.Add(new OrderItem
                        {
                            ProductID = productID,
                            Description = selectedProduct.ProductName,
                            Price = selectedProduct.Price, // Lấy giá bán
                            Quantity = 1
                        });
                    }

                    // Refresh DataGridView và cập nhật tổng kết
                    ((BindingList<OrderItem>)dgvOrderItems.DataSource).ResetBindings();
                    UpdateOrderSummary();
                }
            }
        }

        // Phương thức tính toán và cập nhật tóm tắt hóa đơn
        private void UpdateOrderSummary()
        {
            decimal totalOriginalAmount = orderItems.Sum(item => item.Total);
            decimal totalDiscount = 0; // Giả sử discount là 0 ban đầu

            // TODO: Thêm logic tính toán giảm giá (voucher, promotion, discount) vào đây
            // (Ví dụ: totalDiscount = CalculateDiscount(totalOriginalAmount, appliedVoucher);)

            decimal totalPayable = totalOriginalAmount - totalDiscount;

            // Cập nhật các Label tóm tắt
            lblBillTotalValue.Text = string.Format("{0:N0}", totalOriginalAmount); // Bill Total
            lblTotalDiscountValue.Text = string.Format("{0:N0}", totalDiscount); // Total Discount
            lblTotaPayable.Text = string.Format("{0:N0}", totalPayable); // Total Payable
        }
    }
}