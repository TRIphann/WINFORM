using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTLLTTQ
{
    public partial class ResetPassword : Form
    {
        // ⭐️ ĐÃ BỎ BIẾN _tenDangNhapCanReset
        private DBHelper db = new DBHelper();

        // ⭐️ CONSTRUCTOR MỚI: Không nhận tham số, giúp loại bỏ InputBox
        public ResetPassword()
        {
            InitializeComponent();

            // Khởi tạo Placeholder cho các TextBox
            KhoiTaoPlaceholder();

            // Cập nhật tiêu đề Form
            this.Text = "Đặt lại Mật khẩu";
        }

        private void KhoiTaoPlaceholder()
        {
            // Thiết lập giá trị và màu cho Mật khẩu mới
            txtMatKhauMoi.Text = "Mật khẩu mới";
            txtMatKhauMoi.ForeColor = Color.Gray;
            txtMatKhauMoi.UseSystemPasswordChar = false;

            // Thiết lập giá trị và màu cho Xác nhận mật khẩu
            txtXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            txtXacNhanMatKhau.ForeColor = Color.Gray;
            txtXacNhanMatKhau.UseSystemPasswordChar = false;

            // Gán sự kiện Enter và Leave
            txtMatKhauMoi.Enter += new EventHandler(txtMatKhauMoi_Enter);
            txtMatKhauMoi.Leave += new EventHandler(txtMatKhauMoi_Leave);
            txtXacNhanMatKhau.Enter += new EventHandler(txtXacNhanMatKhau_Enter);
            txtXacNhanMatKhau.Leave += new EventHandler(txtXacNhanMatKhau_Leave);
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            // Lấy giá trị sau khi loại bỏ placeholder
            string matKhauMoi = (txtMatKhauMoi.Text == "Mật khẩu mới") ? "" : txtMatKhauMoi.Text.Trim();
            string xacNhanMatKhau = (txtXacNhanMatKhau.Text == "Xác nhận mật khẩu") ? "" : txtXacNhanMatKhau.Text.Trim();

            // 1. Kiểm tra trống
            if (string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mật khẩu mới và Xác nhận mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra khớp nhau
            if (matKhauMoi != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và Xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ⭐️ GIẢ ĐỊNH: Dùng một TenDangNhap cứng để Test cập nhật DB
            // (Bạn cần thay thế bằng logic lấy TenDangNhap/Email hợp lệ sau khi người dùng xác minh)
            string tenDangNhapTest = "admin"; // Thay thế bằng tài khoản có sẵn trong DB để test

            // 3. Thực hiện cập nhật mật khẩu
            try
            {
                // Gọi hàm UpdatePassword từ DBHelper (cần đảm bảo hàm này đã được định nghĩa)
                bool success = db.UpdatePassword(tenDangNhapTest, matKhauMoi);

                if (success)
                {
                    MessageBox.Show("✅ Đặt lại mật khẩu thành công! Vui lòng đăng nhập lại.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("❌ Lỗi xảy ra trong quá trình cập nhật mật khẩu. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LOGIC PLACEHOLDER (WATERMARK) CHO MẬT KHẨU MỚI
        // =========================================================

        private void txtMatKhauMoi_Enter(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "Mật khẩu mới")
            {
                txtMatKhauMoi.Text = "";
                txtMatKhauMoi.ForeColor = Color.Black;
                txtMatKhauMoi.UseSystemPasswordChar = true; // Bật ẩn ký tự
            }
        }

        private void txtMatKhauMoi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                txtMatKhauMoi.Text = "Mật khẩu mới";
                txtMatKhauMoi.ForeColor = Color.Gray;
                txtMatKhauMoi.UseSystemPasswordChar = false; // Tắt ẩn ký tự
            }
        }

        // =========================================================
        // LOGIC PLACEHOLDER (WATERMARK) CHO XÁC NHẬN MẬT KHẨU
        // =========================================================

        private void txtXacNhanMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhau.Text == "Xác nhận mật khẩu")
            {
                txtXacNhanMatKhau.Text = "";
                txtXacNhanMatKhau.ForeColor = Color.Black;
                txtXacNhanMatKhau.UseSystemPasswordChar = true; // Bật ẩn ký tự
            }
        }

        private void txtXacNhanMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtXacNhanMatKhau.Text))
            {
                txtXacNhanMatKhau.Text = "Xác nhận mật khẩu";
                txtXacNhanMatKhau.ForeColor = Color.Gray;
                txtXacNhanMatKhau.UseSystemPasswordChar = false; // Tắt ẩn ký tự
            }
        }
    }
}