using System;
using System.Windows.Forms;

namespace JumpArena.View.Accountant
{
    public partial class MENUAUC : Form
    {
        private frmRevenueReport _frmRevenueReport;
        private frmVoucherCheckIn _frmVoucherCheckIn;
        private frmBestSeller _frmBestSeller;

        public MENUAUC()
        {
            InitializeComponent();

            // ===== TEXT CỐ ĐỊNH =====
            lbJump.Text = "KẾ TOÁN JUMP ARENA";

            btnfrmRevenueReport.Text = "BÁO CÁO DOANH THU";
            btnfrmVoucherCheckIn.Text = "CHECK-IN VOUCHER";
            btnfrmBestSeller.Text = "TOP SẢN PHẨM BÁN CHẠY";
            btnLogout.Text = "ĐĂNG XUẤT";

            // ===== EVENTS =====
            btnfrmRevenueReport.Click += (s, e) => OpenRevenueReport();
            btnfrmVoucherCheckIn.Click += (s, e) => OpenVoucherCheckIn();
            btnfrmBestSeller.Click += (s, e) => OpenBestSeller();
            btnLogout.Click += BtnLogout_Click;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất?",
                "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            _frmRevenueReport?.Close();
            _frmVoucherCheckIn?.Close();
            _frmBestSeller?.Close();

            Session.Clear();
            frmSelectRole.SelectedRole.Clear();

            this.Hide();
            new frmSelectRole().ShowDialog();
            this.Close();
        }

        private void ChildClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void OpenRevenueReport()
        {
            if (_frmRevenueReport == null || _frmRevenueReport.IsDisposed)
            {
                _frmRevenueReport = new frmRevenueReport();
                _frmRevenueReport.FormClosed += ChildClosed;
            }

            this.Enabled = false;
            _frmRevenueReport.Show();
        }

        private void OpenVoucherCheckIn()
        {
            if (_frmVoucherCheckIn == null || _frmVoucherCheckIn.IsDisposed)
            {
                _frmVoucherCheckIn = new frmVoucherCheckIn();
                _frmVoucherCheckIn.FormClosed += ChildClosed;
            }

            this.Enabled = false;
            _frmVoucherCheckIn.Show();
        }

        private void OpenBestSeller()
        {
            if (_frmBestSeller == null || _frmBestSeller.IsDisposed)
            {
                _frmBestSeller = new frmBestSeller();
                _frmBestSeller.FormClosed += ChildClosed;
            }

            this.Enabled = false;
            _frmBestSeller.Show();
        }
    }
}
