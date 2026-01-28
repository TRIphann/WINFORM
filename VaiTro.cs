using System;
using System.Windows.Forms;

namespace BTLLTTQ
{
    // ⭐️ ĐỔI TÊN CLASS TỪ Form1 THÀNH VaiTro
    public partial class VaiTro : Form
    {
        public VaiTro()
        {
            InitializeComponent();
        }

        // =========================================================
        // HÀM CHUNG XỬ LÝ VIỆC MỞ FORM ĐĂNG NHẬP
        // =========================================================
        private void MoFormDangNhap(string vaiTro)
        {
            MessageBox.Show($"Bạn đã chọn vai trò: {vaiTro}. Chuyển đến trang Đăng nhập.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ẩn Form Chào mừng hiện tại
            this.Hide();

            // Tạo và mở Form Đăng nhập
            DangNhap dangNhapForm = new DangNhap();

            // Gán sự kiện: Khi Form Đăng nhập đóng, Form Chào mừng sẽ hiện lại
            dangNhapForm.FormClosed += (s, args) => this.Show();

            dangNhapForm.Show();
        }


        // =========================================================
        // XỬ LÝ SỰ KIỆN CLICK CHO 3 BUTTON
        // =========================================================
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            MoFormDangNhap("Nhân viên");
        }

        private void btnKeToan_Click(object sender, EventArgs e)
        {
            MoFormDangNhap("Kế toán");
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            MoFormDangNhap("Quản lý");
        }
    }
}