using System;
using System.Windows.Forms;
using System.Drawing;

namespace YourProjectNamespace
{
    public partial class CompanyAccountsForm : Form
    {
        public CompanyAccountsForm()
        {
            InitializeComponent();
            LoadAccountRoles();
            LoadAccountData();
        }

        // --- HÀM TẢI DỮ LIỆU BAN ĐẦU ---

        private void LoadAccountRoles()
        {
            cmbRoles.Items.Add("Tất cả");
            cmbRoles.Items.Add("Nhân viên");
            cmbRoles.Items.Add("Quản lý");
            cmbRoles.Items.Add("Kế toán");
            cmbRoles.SelectedIndex = 0;

            // Logic bố cục đã được chuyển sang Designer (Hàng 4 cho Label, Hàng 5 cho ComboBox)
            // Chỉ cần đảm bảo các controls được bám dính đúng cách trong TLP
            this.lblRoleFilter.Anchor = AnchorStyles.Left; // Căn giữa dọc, bám trái
            this.lblRoleFilter.Margin = new Padding(10, 0, 0, 0);

            this.cmbRoles.Anchor = AnchorStyles.Left | AnchorStyles.Right; // Lấp đầy chiều rộng
            this.cmbRoles.Margin = new Padding(10, 0, 10, 0); // Khoảng đệm 10px hai bên
        }

        private void LoadAccountData()
        {
            dgvAccounts.Columns.Clear();
            dgvAccounts.Rows.Clear();

            dgvAccounts.Columns.Add("ID", "Mã TK");
            dgvAccounts.Columns.Add("Name", "Tên Tài Khoản");
            dgvAccounts.Columns.Add("Role", "Vai Trò");
            dgvAccounts.Columns.Add("Status", "Trạng Thái");

            dgvAccounts.Rows.Add("TK001", "Nguyen Van A", "Quản lý", "Hoạt động");
            dgvAccounts.Rows.Add("TK002", "Tran Thi B", "Kế toán", "Hoạt động");
            dgvAccounts.Rows.Add("TK003", "Le Van C", "Nhân viên", "Tạm khóa");
        }

        // --- PHƯƠNG THỨC XỬ LÝ KÍCH THƯỚC (Giữ nguyên) ---

        private void splitContainerMain_Panel2_SizeChanged(object sender, EventArgs e)
        {
            // Logic điều chỉnh pnlList để nó nằm dưới lblListTitle
            int titleHeight = lblListTitle.Height + lblListTitle.Location.Y + 10;
            pnlList.Location = new Point(0, titleHeight);
            pnlList.Size = new Size(splitContainerMain.Panel2.ClientSize.Width, splitContainerMain.Panel2.ClientSize.Height - titleHeight);
        }

        // --- CÁC HÀM XỬ LÝ NÚT VÀ SỰ KIỆN (Giữ nguyên) ---

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở Form Thêm Tài Khoản mới...", "Tác vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                string accountId = dgvAccounts.SelectedRows[0].Cells["ID"].Value.ToString();
                MessageBox.Show($"Mở Form Sửa Tài Khoản ID: {accountId}", "Tác vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                string accountName = dgvAccounts.SelectedRows[0].Cells["Name"].Value.ToString();
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản '{accountName}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvAccounts.Rows.RemoveAt(dgvAccounts.SelectedRows[0].Index);
                    MessageBox.Show($"Đã xóa tài khoản {accountName}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cmbRoles.SelectedItem.ToString();
            MessageBox.Show($"Lọc danh sách theo vai trò: {selectedRole}", "Lọc", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}