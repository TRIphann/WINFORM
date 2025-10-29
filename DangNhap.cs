using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing; // Cần thiết cho Color
using Microsoft.VisualBasic; // Cần thiết cho Interaction.InputBox

namespace BTLLTTQ
{
    public partial class DangNhap : Form
    {
        private DBHelper db = new DBHelper();

        public DangNhap()
        {
            InitializeComponent();

            // Gọi hàm kiểm tra kết nối (Dùng để test)
            db.KiemTraKetNoi();

            // ⭐️ KHỞI TẠO PLACEHOLDER & GÁN SỰ KIỆN TẠI ĐÂY
            KhoiTaoPlaceholder();
        }

        private void KhoiTaoPlaceholder()
        {
            // Thiết lập giá trị và màu cho Tên đăng nhập
            txtTenDangNhap.Text = "Email";
            txtTenDangNhap.ForeColor = Color.Gray;

            // Thiết lập giá trị và màu cho Mật khẩu
            txtMatKhau.Text = "Password";
            txtMatKhau.ForeColor = Color.Gray;
            txtMatKhau.UseSystemPasswordChar = false; // Tắt ẩn ký tự để chữ "Password" hiện ra

            // Gán sự kiện cho TextBox (Dù đã gán trong Designer, vẫn nên có)
            txtTenDangNhap.Enter += new EventHandler(txtTenDangNhap_Enter);
            txtTenDangNhap.Leave += new EventHandler(txtTenDangNhap_Leave);
            txtMatKhau.Enter += new EventHandler(txtMatKhau_Enter);
            txtMatKhau.Leave += new EventHandler(txtMatKhau_Leave);
        }

        // =========================================================
        // XỬ LÝ ĐĂNG NHẬP (CLICK BUTTON)
        // =========================================================
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = (txtTenDangNhap.Text == "Email") ? "" : txtTenDangNhap.Text.Trim();
            string password = (txtMatKhau.Text == "Password") ? "" : txtMatKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable userData = db.DangNhap(username, password);

            if (userData != null && userData.Rows.Count > 0)
            {
                int vaiTroID = (int)userData.Rows[0]["VaiTroID"];

                this.Hide();
                Main mainForm = new Main(vaiTroID);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // XỬ LÝ CLICK FORGOT PASSWORD
        // =========================================================
        private void lblForgot_Click(object sender, EventArgs e)
        {
            // ⭐️ KHÔNG CẦN InputBox NỮA, MỞ FORM TRỰC TIẾP

            this.Hide();

            // Mở Form ResetPassword KHÔNG CẦN TRUYỀN THAM SỐ
            ResetPassword resetForm = new ResetPassword();
            resetForm.Show();

            // Đảm bảo Form DangNhap hiện lại khi ResetPassword đóng
            resetForm.FormClosed += (s, args) => this.Show();
        }


        // =========================================================
        // LOGIC PLACEHOLDER (WATERMARK)
        // =========================================================

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Email")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
            // Logic Icon động (Nếu cần): picEmail.Image = Properties.Resources.IconEmail_Active;
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                txtTenDangNhap.Text = "Email";
                txtTenDangNhap.ForeColor = Color.Gray;
            }
            // Logic Icon động (Nếu cần): picEmail.Image = Properties.Resources.IconEmail_Default;
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Password")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.UseSystemPasswordChar = true; // Bật chế độ ẩn ký tự
            }
            // Logic Icon động (Nếu cần): picPassword.Image = Properties.Resources.IconLock_Active;
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                txtMatKhau.Text = "Password";
                txtMatKhau.ForeColor = Color.Gray;
                txtMatKhau.UseSystemPasswordChar = false; // Tắt chế độ ẩn ký tự
            }
            // Logic Icon động (Nếu cần): picPassword.Image = Properties.Resources.IconLock_Default;
        }
    }
}