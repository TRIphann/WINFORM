using JumpArena.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace JumpArena
{
    public partial class frmLogin : Form
    {
        private bool isPasswordVisible = false;

        public frmLogin()
        {
            InitializeComponent();

            btnClose.MouseEnter += (s, e) => btnClose.ForeColor = System.Drawing.Color.Red;
            btnClose.MouseLeave += (s, e) => btnClose.ForeColor = System.Drawing.Color.White;
            btnShowPassword.Paint += BtnShowPassword_Paint;

            SetRoundedRegion(this, 30);
            SetRoundedRegion(pnlLoginPanel, 20);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (frmSelectRole.SelectedRole.RoleID == null)
            {
                MessageBox.Show("Lỗi hệ thống: Chưa chọn vai trò từ màn hình trước.\nVui lòng khởi động lại ứng dụng.",
                    "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedRoleId = frmSelectRole.SelectedRole.RoleID.Value;
            string selectedRoleName = frmSelectRole.SelectedRole.RoleName ?? "Không xác định";

            try
            {
                using (var context = new JumpArenaContextDB())
                {
                    var user = context.Users
                        .FirstOrDefault(u => u.Username == username && u.Password == password);

                    if (user == null)
                    {
                        MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng!",
                            "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string userRoleName = context.Roles
                        .Where(r => r.RoleID == user.RoleID)
                        .Select(r => r.RoleName)
                        .FirstOrDefault() ?? "Không xác định";

                    if (user.RoleID != selectedRoleId)
                    {
                        MessageBox.Show(
                            $"Tài khoản \"{username}\" thuộc vai trò \"{userRoleName}\",\n" +
                            $"nhưng bạn đã chọn đăng nhập với vai trò \"{selectedRoleName}\".\n\n" +
                            "Vui lòng chọn đúng vai trò hoặc sử dụng tài khoản phù hợp.",
                            "Không được phép đăng nhập",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                        return;
                    }

                    // ===== SET SESSION =====
                    Session.UserId = user.UserID; // đúng theo code bạn đang dùng
                    Session.FullName = user.FullName ?? "";
                    Session.RoleName = userRoleName ?? selectedRoleName;
                    Session.Username = user.Username ?? username;

                    ShiftService.StartShiftIfNotActive(Session.UserId);

                    MessageBox.Show(
                        $"Đăng nhập thành công!\n\n" +
                        $"Chào mừng {Session.FullName}\n" +
                        $"Vai trò: {selectedRoleName}",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Hide();

                    if (selectedRoleId == 4) // Admin
                    {
                        var adminMenu = new JumpArena.View.Admin.MENU();
                        adminMenu.ShowDialog();
                    }
                    else if (selectedRoleId == 3) // KẾ TOÁN TRƯỞNG
                    {
                        var menuAuc = new JumpArena.View.Accountant.MENUAUC();
                        menuAuc.ShowDialog();
                    }
                    else
                    {
                        var homePage = new HomePage(selectedRoleId);
                        homePage.ShowDialog();
                    }

                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu:\n" + ex.Message,
                    "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmSelectRole.SelectedRole.Clear();
            this.Hide();
            new frmSelectRole().ShowDialog();
            this.Close();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.UseSystemPasswordChar = !isPasswordVisible;
            btnShowPassword.Invalidate();
        }

        private void BtnShowPassword_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(System.Drawing.Color.White);

            int w = btnShowPassword.Width;
            int h = btnShowPassword.Height;

            using (Pen pen = new Pen(System.Drawing.Color.Black, 2))
            using (Brush brush = new SolidBrush(System.Drawing.Color.Black))
            {
                Rectangle eyeRect = new Rectangle(4, h / 4, w - 8, h / 2);
                e.Graphics.DrawEllipse(pen, eyeRect);

                if (isPasswordVisible)
                {
                    int pupilSize = Math.Max(2, w / 6);
                    int pupilX = w / 2 - pupilSize / 2;
                    int pupilY = h / 2 - pupilSize / 2;
                    e.Graphics.FillEllipse(brush, pupilX, pupilY, pupilSize, pupilSize);
                }
                else
                {
                    e.Graphics.DrawLine(pen, 4, h - 4, w - 4, 4);
                }
            }
        }

        private void SetRoundedRegion(System.Windows.Forms.Control control, int radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90);
                path.CloseFigure();
                control.Region = new Region(path);
            }
        }
    }
}
