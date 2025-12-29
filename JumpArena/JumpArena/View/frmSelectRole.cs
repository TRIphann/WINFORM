
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace JumpArena
{
    public partial class frmSelectRole : Form
    {
        public frmSelectRole()
        {
            InitializeComponent();
            this.Shown += frmSelectRole_Shown; 
            btnClose.MouseEnter += (s, e) => { btnClose.ForeColor = Color.Red; };
            btnClose.MouseLeave += (s, e) => { btnClose.ForeColor = Color.White; };
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Hàm tiện ích bo góc
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
            // Bo Form
            SetRoundedRegion(this, 30);
            // Bo panel
            SetRoundedRegion(pnlSelectRole, 20);
        }


    }
}