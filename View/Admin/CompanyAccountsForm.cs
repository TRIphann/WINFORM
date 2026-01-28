using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JumpArena.View.Admin
{
    public partial class CompanyAccountsForm : Form
    {
        private readonly string _cs;

        private DataTable _dtAccounts;
        private DataTable _dtRoles;

        public CompanyAccountsForm()
        {
            InitializeComponent();

            _cs = System.Configuration.ConfigurationManager
                .ConnectionStrings["JumpArenaContextDB"].ConnectionString;

            SetupGrid();

            LoadRolesFromDb();
            LoadAccountsFromDb(); // load lần đầu
        }

        private void SetupGrid()
        {
            dgvAccounts.AutoGenerateColumns = false;
            dgvAccounts.AllowUserToAddRows = true;     // chừa 1 dòng cuối để nhập
            dgvAccounts.AllowUserToDeleteRows = false; // xóa phải bấm nút Xóa
            dgvAccounts.ReadOnly = false;              // cho sửa trực tiếp
            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.MultiSelect = false;

            dgvAccounts.Columns.Clear();

            // UserID (khóa) - không cho sửa
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUserID",
                HeaderText = "UserID",
                DataPropertyName = "UserID",
                ReadOnly = true,
                Width = 80
            });

            // Username
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUsername",
                HeaderText = "Username",
                DataPropertyName = "Username",
                Width = 160
            });

            // FullName
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFullName",
                HeaderText = "Họ tên",
                DataPropertyName = "FullName",
                Width = 220
            });

            // Role (Combo ngay trong grid)
            var roleCol = new DataGridViewComboBoxColumn
            {
                Name = "colRoleID",
                HeaderText = "Vai trò",
                DataPropertyName = "RoleID",
                DisplayMember = "RoleName",
                ValueMember = "RoleID",
                Width = 150
            };
            dgvAccounts.Columns.Add(roleCol);

            // IsActive
            dgvAccounts.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colIsActive",
                HeaderText = "Hoạt động",
                DataPropertyName = "IsActive",
                Width = 90
            });

            dgvAccounts.DataError += (s, e) =>
            {
                // tránh lỗi combo column khi role null / mismatch
                e.ThrowException = false;
            };

            cmbRoles.SelectedIndexChanged += cmbRoles_SelectedIndexChanged;
        }

        // ===================== LOAD ROLES =====================
        private void LoadRolesFromDb()
        {
            using (var conn = new SqlConnection(_cs))
            using (var da = new SqlDataAdapter(@"
SELECT RoleID, RoleName
FROM Role
ORDER BY RoleID;", conn))
            {
                _dtRoles = new DataTable();
                da.Fill(_dtRoles);
            }

            // Combo filter bên trái
            var dtFilter = _dtRoles.Copy();
            var rowAll = dtFilter.NewRow();
            rowAll["RoleID"] = 0;
            rowAll["RoleName"] = "Tất cả";
            dtFilter.Rows.InsertAt(rowAll, 0);

            cmbRoles.DisplayMember = "RoleName";
            cmbRoles.ValueMember = "RoleID";
            cmbRoles.DataSource = dtFilter;

            // gán roles cho cột Combo trong grid
            var gridRoleCol = dgvAccounts.Columns["colRoleID"] as DataGridViewComboBoxColumn;
            gridRoleCol.DataSource = _dtRoles;
            gridRoleCol.DisplayMember = "RoleName";
            gridRoleCol.ValueMember = "RoleID";
        }

        // ===================== LOAD ACCOUNTS =====================
        private void LoadAccountsFromDb(int roleIdFilter = 0)
        {
            string sql = @"
SELECT 
    u.UserID,
    u.Username,
    u.FullName,
    u.RoleID,
    u.IsActive
FROM [User] u
" + (roleIdFilter > 0 ? "WHERE u.RoleID = @RoleID" : "") + @"
ORDER BY u.UserID;";

            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (roleIdFilter > 0)
                    cmd.Parameters.Add("@RoleID", SqlDbType.Int).Value = roleIdFilter;

                _dtAccounts = new DataTable();
                da.Fill(_dtAccounts);
            }

            dgvAccounts.DataSource = _dtAccounts;
        }

        // ===================== FILTER =====================
        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoles.SelectedValue == null) return;

            int roleId = Convert.ToInt32(cmbRoles.SelectedValue);
            LoadAccountsFromDb(roleId);
        }

        // ===================== ADD (chỉ lấy dòng cuối) =====================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Dòng nhập mới luôn là row cuối (IsNewRow)
            var newRow = dgvAccounts.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.IsNewRow);

            // thực tế: dữ liệu người dùng nhập nằm ở "row trước dòng newRow"
            // DataGridView có 1 dòng newRow trống, khi user gõ nó thành 1 row thật và newRow trống mới xuất hiện.
            // Nên ta lấy "row cuối cùng có dữ liệu" = Rows.Count - 2 (nếu AllowUserToAddRows = true)
            int idx = dgvAccounts.AllowUserToAddRows ? dgvAccounts.Rows.Count - 2 : dgvAccounts.Rows.Count - 1;
            if (idx < 0) return;

            var row = dgvAccounts.Rows[idx];
            if (row.IsNewRow)
            {
                MessageBox.Show("Nhập dữ liệu ở dòng cuối trước đã.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = Convert.ToString(row.Cells["colUsername"].Value)?.Trim();
            string fullName = Convert.ToString(row.Cells["colFullName"].Value)?.Trim();
            object roleVal = row.Cells["colRoleID"].Value;
            bool isActive = row.Cells["colIsActive"].Value != null && (bool)row.Cells["colIsActive"].Value;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username không được trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Họ tên không được trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (roleVal == null || roleVal == DBNull.Value)
            {
                MessageBox.Show("Chọn vai trò.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int roleId = Convert.ToInt32(roleVal);

            using (var conn = new SqlConnection(_cs))
            {
                conn.Open();

                // check trùng username (khuyên có)
                using (var cmdCheck = new SqlCommand("SELECT COUNT(1) FROM [User] WHERE Username=@u", conn))
                {
                    cmdCheck.Parameters.Add("@u", SqlDbType.NVarChar, 150).Value = username;
                    int exists = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (exists > 0)
                    {
                        MessageBox.Show("Username đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // insert
                // NOTE: nếu bảng User của bạn có Password bắt buộc, bạn phải thêm cột + giá trị ở đây.
                using (var cmd = new SqlCommand(@"
INSERT INTO [User] (Username, FullName, RoleID, IsActive)
VALUES (@Username, @FullName, @RoleID, @IsActive);

SELECT CAST(SCOPE_IDENTITY() AS INT);", conn))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 150).Value = username;
                    cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 150).Value = fullName;
                    cmd.Parameters.Add("@RoleID", SqlDbType.Int).Value = roleId;
                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;

                    int newId = Convert.ToInt32(cmd.ExecuteScalar());

                    // reload để có UserID mới và sync grid
                    int filterRole = cmbRoles.SelectedValue == null ? 0 : Convert.ToInt32(cmbRoles.SelectedValue);
                    LoadAccountsFromDb(filterRole);

                    // select row mới
                    var found = dgvAccounts.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(r => !r.IsNewRow && Convert.ToInt32(r.Cells["colUserID"].Value) == newId);
                    if (found != null) dgvAccounts.CurrentCell = found.Cells["colUsername"];
                }
            }
        }

        // ===================== EDIT (sửa những gì đã sửa trên lưới) =====================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 tài khoản để sửa.", "Thiếu chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvAccounts.SelectedRows[0];
            if (row.IsNewRow) return;

            int userId = Convert.ToInt32(row.Cells["colUserID"].Value);

            string username = Convert.ToString(row.Cells["colUsername"].Value)?.Trim();
            string fullName = Convert.ToString(row.Cells["colFullName"].Value)?.Trim();
            object roleVal = row.Cells["colRoleID"].Value;
            bool isActive = row.Cells["colIsActive"].Value != null && (bool)row.Cells["colIsActive"].Value;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(fullName) || roleVal == null)
            {
                MessageBox.Show("Thiếu dữ liệu (Username/Họ tên/Vai trò).", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int roleId = Convert.ToInt32(roleVal);

            using (var conn = new SqlConnection(_cs))
            {
                conn.Open();

                // check username trùng người khác
                using (var cmdCheck = new SqlCommand(@"
SELECT COUNT(1) 
FROM [User] 
WHERE Username=@u AND UserID<>@id;", conn))
                {
                    cmdCheck.Parameters.Add("@u", SqlDbType.NVarChar, 150).Value = username;
                    cmdCheck.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                    int exists = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (exists > 0)
                    {
                        MessageBox.Show("Username bị trùng với tài khoản khác.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                using (var cmd = new SqlCommand(@"
UPDATE [User]
SET Username=@Username,
    FullName=@FullName,
    RoleID=@RoleID,
    IsActive=@IsActive
WHERE UserID=@UserID;", conn))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 150).Value = username;
                    cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 150).Value = fullName;
                    cmd.Parameters.Add("@RoleID", SqlDbType.Int).Value = roleId;
                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = userId;

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Đã cập nhật tài khoản.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ===================== DELETE =====================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 tài khoản để xóa.", "Thiếu chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvAccounts.SelectedRows[0];
            if (row.IsNewRow) return;

            int userId = Convert.ToInt32(row.Cells["colUserID"].Value);
            string username = Convert.ToString(row.Cells["colUsername"].Value);

            var ok = MessageBox.Show($"Xóa tài khoản '{username}' ?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok != DialogResult.Yes) return;

            using (var conn = new SqlConnection(_cs))
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM [User] WHERE UserID=@id", conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                    cmd.ExecuteNonQuery();
                }
            }

            int filterRole = cmbRoles.SelectedValue == null ? 0 : Convert.ToInt32(cmbRoles.SelectedValue);
            LoadAccountsFromDb(filterRole);

            MessageBox.Show("Đã xóa.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ========== giữ nguyên nếu bạn cần chỉnh layout panel phải ==========
        private void splitContainerMain_Panel2_SizeChanged(object sender, EventArgs e)
        {
            int titleHeight = lblListTitle.Height + lblListTitle.Location.Y + 10;
            pnlList.Location = new Point(0, titleHeight);
            pnlList.Size = new Size(splitContainerMain.Panel2.ClientSize.Width,
                                    splitContainerMain.Panel2.ClientSize.Height - titleHeight);
        }
    }
}
