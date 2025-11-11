// Thêm các thư viện (using) cần thiết ở đầu file
using JumpArena.BusinessLogic;
using JumpArena.DataAccess;
using JumpArena.Models;
using System;
using System.Windows.Forms;

// Đảm bảo namespace này khớp với tên dự án của bạn
namespace JumpArena.Views
{
    public partial class frmLogin : Form
    {
        private Role _selectedRole; // Biến để lưu vai trò được truyền sang
        private UserService _userService;

        public frmLogin(Role selectedRole)
        {
            InitializeComponent();
            _userService = new UserService();
            _selectedRole = selectedRole;

            this.Text = $"Đăng nhập (Vai trò: {_selectedRole.RoleName})";

            // Cài đặt ban đầu cho nút "Con Mắt"
            if (btnShowPass != null)
            {
                btnShowPass.Text = "👁️";
            }
        }

        // === SỰ KIỆN CLICK NÚT ĐĂNG NHẬP ===
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập và Mật khẩu.", "Thiếu thông tin");
                return;
            }

            User loggedInUser = _userService.Login(username, password);

            if (loggedInUser == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Lỗi Đăng nhập");
            }
            else if (loggedInUser.RoleID != _selectedRole.RoleID)
            {
                MessageBox.Show("Tài khoản của bạn không thuộc vai trò bạn đã chọn.", "Sai vai trò");
            }
            else
            {
                MessageBox.Show($"Chào mừng {loggedInUser.FullName}!");

                // TODO: Lưu người dùng và mở Form Tạo Ca
                // GlobalUser.CurrentUser = loggedInUser;
                // frmCreateWorkShift frmShift = new frmCreateWorkShift();
                // frmShift.Show();

                this.Close();
            }
        }

        // (Nếu bạn muốn nhấn Enter để đăng nhập)
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        // === HÀM MỚI 1: NÚT QUAY LẠI ===
        private void btnBack_Click(object sender, EventArgs e)
        {
            // 1. Tìm Form 'frmSelectRole' đang bị ẩn
            Form selectRoleForm = Application.OpenForms["frmSelectRole"];

            if (selectRoleForm != null)
            {
                // 2. Làm nó hiện lại
                selectRoleForm.Show();
            }

            // 3. Đóng Form đăng nhập này lại
            this.Close();
        }

        // === HÀM MỚI 2: NÚT CON MẮT (HIỆN/ẨN MẬT KHẨU) ===
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                // Nếu mật khẩu đang bị che:
                // 1. Gỡ ký tự che ('\0' là ký tự rỗng)
                txtPassword.PasswordChar = '\0';
                // 2. Đổi biểu tượng thành "che mắt"
                btnShowPass.Text = "🙈";
            }
            else
            {
                // Nếu mật khẩu đang được hiển thị:
                // 1. Đặt lại ký tự che
                txtPassword.PasswordChar = '*';
                // 2. Đổi biểu tượng thành "mở mắt"
                btnShowPass.Text = "👁️";
            }
        }
    }
}