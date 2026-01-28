using System;
using System.Linq;
using System.Windows.Forms;
using JumpArena.Models;

namespace JumpArena.View.Admin
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();

            // UI basic
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // events (nếu designer đã gắn thì cũng không sao)
            this.Load += AddProductForm_Load;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesFromDb();
        }

        private void LoadCategoriesFromDb()
        {
            using (var context = new JumpArenaContextDB())
            {
                var cats = context.Categories
                    .OrderBy(c => c.CategoryName)
                    .ToList();

                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
                cmbCategory.DataSource = cats;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string productName = (txtProductName.Text ?? "").Trim();
            string description = (txtDescription.Text ?? "").Trim();

            // Mã SP của bạn đang có textbox txtProductID nhưng model ProductID là int identity
            // nên coi txtProductID là optional (hoặc bỏ qua). Không insert ProductID.
            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Tên sản phẩm không được để trống.");
                txtProductName.Focus();
                return;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục.");
                cmbCategory.Focus();
                return;
            }

            if (!decimal.TryParse((txtPrice.Text ?? "").Trim(), out decimal price) || price < 0)
            {
                MessageBox.Show("Giá bán không hợp lệ.");
                txtPrice.Focus();
                return;
            }

            if (!int.TryParse((txtQuantity.Text ?? "").Trim(), out int qty) || qty < 0)
            {
                MessageBox.Show("Số lượng tồn không hợp lệ.");
                txtQuantity.Focus();
                return;
            }

            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);

            using (var context = new JumpArenaContextDB())
            {
                // chống trùng đơn giản
                bool exists = context.Products.Any(x =>
                    x.ProductName == productName && x.CategoryID == categoryId);

                if (exists)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại trong danh mục này.");
                    return;
                }

                var newProduct = new Product
                {
                    ProductName = productName,
                    Price = price,
                    StockQuantity = qty,
                    CategoryID = categoryId,
                    Description = string.IsNullOrWhiteSpace(description) ? null : description
                };

                context.Products.Add(newProduct);
                context.SaveChanges();
            }

            MessageBox.Show("Đã thêm sản phẩm mới.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
