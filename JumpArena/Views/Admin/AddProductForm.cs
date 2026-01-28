using System;
using System.Windows.Forms;

namespace YourProjectNamespace // Thay thế bằng namespace của dự án bạn
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            // Tải dữ liệu danh mục mẫu
            cmbCategory.Items.Add("Điện thoại");
            cmbCategory.Items.Add("Máy tính xách tay");
            cmbCategory.Items.Add("Phụ kiện");
            cmbCategory.SelectedIndex = 0;
        }

        // Xử lý sự kiện khi nhấn nút "Lưu"
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu
            string productId = txtProductID.Text;
            string productName = txtProductName.Text;
            string category = cmbCategory.SelectedItem.ToString();
            string description = txtDescription.Text;
            string supplier = txtSupplier.Text; // Lấy giá trị Nhà Cung Cấp

            // Kiểm tra và chuyển đổi giá trị số
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Giá bán không hợp lệ. Vui lòng nhập một số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Số lượng tồn không hợp lệ. Vui lòng nhập một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }

            // Kiểm tra dữ liệu bắt buộc 
            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Tên Sản Phẩm không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(supplier))
            {
                MessageBox.Show("Nhà Cung Cấp không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplier.Focus();
                return;
            }


            // THỰC HIỆN LOGIC LƯU VÀO CƠ SỞ DỮ LIỆU TẠI ĐÂY...

            MessageBox.Show($"Đã lưu sản phẩm: {productName} (NCC: {supplier}) thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Xử lý sự kiện khi nhấn nút "Hủy"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}