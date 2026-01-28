using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JumpArena
{
    public partial class frmSelectRole : Form
    {
        // === Nested Static Class để lưu Role đã chọn ===
        public static class SelectedRole
        {
            public static int? RoleID { get; set; }
            public static string RoleName { get; set; }

            public static void Clear()
            {
                RoleID = null;
                RoleName = null;
            }
        }

        public frmSelectRole()
        {
            InitializeComponent();
            this.Shown += frmSelectRole_Shown;
            btnClose.MouseEnter += (s, e) => { btnClose.ForeColor = Color.Red; };
            btnClose.MouseLeave += (s, e) => { btnClose.ForeColor = Color.White; };

            // Gán sự kiện Click cho các nút role
            btnRoleNV.Click += BtnRole_Click;
            btnRoleManager.Click += BtnRole_Click;
            btnRoleAccountant.Click += BtnRole_Click;
            btnRoleAdmin.Click += BtnRole_Click;
        }

        private void BtnRole_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == btnRoleNV)
            {
                SelectedRole.RoleID = 1;
                SelectedRole.RoleName = "Nhân viên";                    // Đúng trong DB
            }
            else if (btn == btnRoleManager)
            {
                SelectedRole.RoleID = 2;
                SelectedRole.RoleName = "Quản lý";                      // Đúng trong DB
            }
            else if (btn == btnRoleAccountant)
            {
                SelectedRole.RoleID = 3;
                SelectedRole.RoleName = "Kế toán trưởng";               // Đúng trong DB (không phải "Kế toán")
            }
            else if (btn == btnRoleAdmin)
            {
                SelectedRole.RoleID = 4;
                SelectedRole.RoleName = "Admin";                        // Đúng trong DB
            }

            // Ẩn form chọn role và mở form login
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng khi bấm X ở màn hình chọn role
            Application.Exit();
        }

        // Hàm bo góc
        private void SetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
        }

        private void frmSelectRole_Shown(object sender, EventArgs e)
        {
            SetRoundedRegion(this, 30);
            SetRoundedRegion(pnlSelectRole, 20);
        }
    }
}