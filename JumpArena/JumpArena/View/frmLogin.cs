using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace JumpArena
{
    public partial class frmLogin : Form
    {
        private bool isPasswordVisible = false;

        public frmLogin()
        {
            InitializeComponent();

            btnClose.MouseEnter += (s, e) => btnClose.ForeColor = Color.Red;
            btnClose.MouseLeave += (s, e) => btnClose.ForeColor = Color.White;
            btnShowPassword.Paint += BtnShowPassword_Paint;
            this.FormBorderStyle = FormBorderStyle.None;

            // Bo góc cho Form
            SetRoundedRegion(this, 30); // radius = 30, có thể thay đổi

            // Bo góc cho pnlLoginPanel
            SetRoundedRegion(pnlLoginPanel, 20); // radius = 20, tùy chỉnh
        }


        private void BtnShowPassword_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(Color.White);
            int w = btnShowPassword.Width;
            int h = btnShowPassword.Height;
            using (Pen pen = new Pen(Color.Black, 2))
            using (Brush brush = new SolidBrush(Color.Black))
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn frmLogin
            frmSelectRole selectRoleForm = new frmSelectRole();
            selectRoleForm.ShowDialog(); // Mở frmSelectRole dưới dạng modal
            this.Close(); // Đóng frmLogin sau khi frmSelectRole đóng
        }

        private void btnLogin_Click(object sender, EventArgs e) => MessageBox.Show($"Username: {txtUsername.Text}\nPassword: {txtPassword.Text}");
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.UseSystemPasswordChar = !isPasswordVisible;
            btnShowPassword.Invalidate();
        }

        private void SetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, 90), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - radius, radius, 90), 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
        }


    }
}
