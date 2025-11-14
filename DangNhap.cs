using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace BTLLTTQ
{
    public partial class DangNhap : Form
    {
        private DBHelper db = new DBHelper();

        public DangNhap()
        {
            InitializeComponent();
            db.KiemTraKetNoi();
            KhoiTaoPlaceholder();
        }

        private void KhoiTaoPlaceholder()
        {
            // Thiết lập giá trị và màu cho Tên đăng nhập
            txtTenDangNhap.Text = "Mời bạn nhập Tên Đăng Nhập";
            txtTenDangNhap.ForeColor = Color.Gray;

            // Thiết lập giá trị và màu cho Mật khẩu
            txtMatKhau.Text = "Mời bạn nhập Mật Khẩu";
            txtMatKhau.ForeColor = Color.Gray;
            txtMatKhau.UseSystemPasswordChar = false;

            // Gán sự kiện cho TextBox
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
            string placeholderUser = "Mời bạn nhập Tên Đăng Nhập";
            string placeholderPass = "Mời bạn nhập Mật Khẩu";

            string username = (txtTenDangNhap.Text == placeholderUser) ? "" : txtTenDangNhap.Text.Trim();
            string password = (txtMatKhau.Text == placeholderPass) ? "" : txtMatKhau.Text;

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
                mainForm.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu! Vui lòng thử lại.", "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
            }
        }



        // =========================================================
        // LOGIC PLACEHOLDER (WATERMARK)
        // =========================================================

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Mời bạn nhập Tên Đăng Nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                txtTenDangNhap.Text = "Mời bạn nhập Tên Đăng Nhập";
                txtTenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mời bạn nhập Mật Khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.UseSystemPasswordChar = true; // Bật chế độ ẩn ký tự
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                txtMatKhau.Text = "Mời bạn nhập Mật Khẩu";
                txtMatKhau.ForeColor = Color.Gray;
                txtMatKhau.UseSystemPasswordChar = false; // Tắt chế độ ẩn ký tự
            }
        }
    }
}