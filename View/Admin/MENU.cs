using System;
using System.Windows.Forms;

namespace JumpArena.View.Admin
{
    public partial class MENU : Form
    {
        private AddProductForm _addProductForm;
        private CompanyAccountsForm _companyAccountsForm;
        private CreateVoucherForm _createVoucherForm;

        // ĐỔI: dùng ReportInboxForm thay ReportAndFeedbackForm
        private ReportInboxForm _reportInboxForm;

        public MENU()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            btnLogout.Click += BtnLogout_Click;

            var role = (JumpArena.Session.RoleName ?? "").ToUpper();
            var name = JumpArena.Session.FullName ?? "";
            lbJump.Text = $"CHÀO MỪNG {role} - {name}";

            btnAddProductForm.Click += BtnAddProductForm_Click;
            btnCompanyAccountsForm.Click += BtnCompanyAccountsForm_Click;
            btnCreateVoucherForm.Click += BtnCreateVoucherForm_Click;
            btnReportInboxForm.Click += Btn_reportInboxForm_Click;

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes) return;

            // đóng form con nếu đang mở
            _addProductForm?.Close();
            _companyAccountsForm?.Close();
            _createVoucherForm?.Close();
            _reportInboxForm?.Close();

            // clear session + role
            JumpArena.Session.Clear();
            frmSelectRole.SelectedRole.Clear();

            Hide();

            var selectRole = new frmSelectRole();
            selectRole.FormClosed += (s, args) => Close();
            selectRole.Show();
        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }

        private void BtnAddProductForm_Click(object sender, EventArgs e)
        {
            if (_addProductForm == null || _addProductForm.IsDisposed)
            {
                _addProductForm = new AddProductForm();
                _addProductForm.FormClosed += ChildFormClosed;
            }

            Enabled = false;
            _addProductForm.Show();
            _addProductForm.BringToFront();
        }

        private void BtnCompanyAccountsForm_Click(object sender, EventArgs e)
        {
            if (_companyAccountsForm == null || _companyAccountsForm.IsDisposed)
            {
                _companyAccountsForm = new CompanyAccountsForm();
                _companyAccountsForm.FormClosed += ChildFormClosed;
            }

            Enabled = false;
            _companyAccountsForm.Show();
            _companyAccountsForm.BringToFront();
        }

        private void BtnCreateVoucherForm_Click(object sender, EventArgs e)
        {
            if (_createVoucherForm == null || _createVoucherForm.IsDisposed)
            {
                _createVoucherForm = new CreateVoucherForm();
                _createVoucherForm.FormClosed += ChildFormClosed;
            }

            Enabled = false;
            _createVoucherForm.Show();
            _createVoucherForm.BringToFront();
        }

        private void Btn_reportInboxForm_Click(object sender, EventArgs e)
        {
            if (_reportInboxForm == null || _reportInboxForm.IsDisposed)
            {
                _reportInboxForm = new ReportInboxForm();
                _reportInboxForm.FormClosed += ChildFormClosed;
            }

            Enabled = false;
            _reportInboxForm.Show();
            _reportInboxForm.BringToFront();
        }
    }
}
