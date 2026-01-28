using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace JumpArena.View.Admin
{
    public partial class ReportInboxForm : Form
    {
        private readonly string _cs =
            System.Configuration.ConfigurationManager.ConnectionStrings["JumpArenaContextDB"].ConnectionString;

        // Left - filters
        private ComboBox cmbFilterType = new ComboBox();
        private ComboBox cmbFilterPriority = new ComboBox();
        private CheckBox chkOnlyUnresolved = new CheckBox();
        private TextBox txtSearch = new TextBox();
        private Button btnRefresh = new Button();

        // Left - grid
        private DataGridView dgvReports = new DataGridView();

        // Right - details
        private TextBox txtType = new TextBox();
        private TextBox txtPriority = new TextBox();
        private TextBox txtReporter = new TextBox();
        private DateTimePicker dtpCreatedAt = new DateTimePicker();
        private TextBox txtBillCode = new TextBox();
        private TextBox txtSubject = new TextBox();
        private TextBox txtContent = new TextBox();

        // Status
        private CheckBox chkResolved = new CheckBox();
        private TextBox txtResolveNote = new TextBox();
        private Button btnSaveStatus = new Button();

        private DataTable _dt;
        private int _currentReportId = 0;

        public ReportInboxForm()
        {
            Text = "NHẬN BÁO CÁO - QUẢN LÝ XỬ LÝ";
            StartPosition = FormStartPosition.CenterScreen;
            Width = 1250;
            Height = 720;
            MinimumSize = new Size(1100, 650);

            BuildUI();
            WireEvents();
            LoadFilters();
            LoadReports();
        }

        private void BuildUI()
        {
            var split = new SplitContainer
            {
                Dock = DockStyle.Fill,
                SplitterDistance = 620
            };
            Controls.Add(split);

            // ===== LEFT =====
            var pnlFilter = new Panel { Dock = DockStyle.Top, Height = 90 };
            split.Panel1.Controls.Add(pnlFilter);

            var lblType = new Label { Text = "Loại:", Left = 10, Top = 12, AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            cmbFilterType.Left = 60; cmbFilterType.Top = 8; cmbFilterType.Width = 180; cmbFilterType.DropDownStyle = ComboBoxStyle.DropDownList;

            var lblPri = new Label { Text = "Ưu tiên:", Left = 260, Top = 12, AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            cmbFilterPriority.Left = 330; cmbFilterPriority.Top = 8; cmbFilterPriority.Width = 150; cmbFilterPriority.DropDownStyle = ComboBoxStyle.DropDownList;

            chkOnlyUnresolved.Text = "Chỉ chưa xử lý";
            chkOnlyUnresolved.Left = 500; chkOnlyUnresolved.Top = 10; chkOnlyUnresolved.AutoSize = true;

            var lblSearch = new Label { Text = "Tìm:", Left = 10, Top = 50, AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            txtSearch.Left = 60; txtSearch.Top = 46; txtSearch.Width = 420;

            btnRefresh.Text = "Làm mới";
            btnRefresh.Left = 500; btnRefresh.Top = 42; btnRefresh.Width = 100; btnRefresh.Height = 30;

            pnlFilter.Controls.AddRange(new Control[] { lblType, cmbFilterType, lblPri, cmbFilterPriority, chkOnlyUnresolved, lblSearch, txtSearch, btnRefresh });

            dgvReports.Dock = DockStyle.Fill;
            dgvReports.ReadOnly = true;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.MultiSelect = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            split.Panel1.Controls.Add(dgvReports);

            // ===== RIGHT =====
            var pnlRight = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10) };
            split.Panel2.Controls.Add(pnlRight);

            int y = 10;

            pnlRight.Controls.Add(MakeLabel("Loại báo cáo:", 10, y));
            txtType.SetBounds(130, y - 4, 470, 26); txtType.ReadOnly = true;
            pnlRight.Controls.Add(txtType); y += 35;

            pnlRight.Controls.Add(MakeLabel("Ưu tiên:", 10, y));
            txtPriority.SetBounds(130, y - 4, 200, 26); txtPriority.ReadOnly = true;
            pnlRight.Controls.Add(txtPriority);

            pnlRight.Controls.Add(MakeLabel("Nhân viên:", 350, y));
            txtReporter.SetBounds(430, y - 4, 170, 26); txtReporter.ReadOnly = true;
            pnlRight.Controls.Add(txtReporter); y += 35;

            pnlRight.Controls.Add(MakeLabel("Thời gian:", 10, y));
            dtpCreatedAt.SetBounds(130, y - 4, 200, 26);
            dtpCreatedAt.Enabled = false;
            pnlRight.Controls.Add(dtpCreatedAt);

            pnlRight.Controls.Add(MakeLabel("Mã Bill:", 350, y));
            txtBillCode.SetBounds(430, y - 4, 170, 26); txtBillCode.ReadOnly = true;
            pnlRight.Controls.Add(txtBillCode); y += 35;

            pnlRight.Controls.Add(MakeLabel("Chủ đề:", 10, y));
            txtSubject.SetBounds(130, y - 4, 470, 26); txtSubject.ReadOnly = true;
            pnlRight.Controls.Add(txtSubject); y += 35;

            pnlRight.Controls.Add(MakeLabel("Nội dung:", 10, y));
            txtContent.SetBounds(130, y - 4, 470, 260);
            txtContent.Multiline = true;
            txtContent.ScrollBars = ScrollBars.Vertical;
            txtContent.ReadOnly = true;
            pnlRight.Controls.Add(txtContent); y += 270;

            chkResolved.Text = "Đã xử lý";
            chkResolved.SetBounds(130, y, 120, 26);
            pnlRight.Controls.Add(chkResolved);

            pnlRight.Controls.Add(MakeLabel("Ghi chú xử lý:", 10, y + 35));
            txtResolveNote.SetBounds(130, y + 31, 470, 100);
            txtResolveNote.Multiline = true;
            txtResolveNote.ScrollBars = ScrollBars.Vertical;
            pnlRight.Controls.Add(txtResolveNote);

            btnSaveStatus.Text = "Lưu trạng thái";
            btnSaveStatus.SetBounds(430, y + 140, 170, 40);
            pnlRight.Controls.Add(btnSaveStatus);
        }

        private Label MakeLabel(string text, int x, int y)
            => new Label { Text = text, Left = x, Top = y, AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };

        private void WireEvents()
        {
            btnRefresh.Click += (s, e) => LoadReports();
            cmbFilterType.SelectedIndexChanged += (s, e) => LoadReports();
            cmbFilterPriority.SelectedIndexChanged += (s, e) => LoadReports();
            chkOnlyUnresolved.CheckedChanged += (s, e) => LoadReports();
            txtSearch.TextChanged += (s, e) => DebounceReload();

            dgvReports.SelectionChanged += (s, e) => LoadSelectedReportToDetail();
            btnSaveStatus.Click += btnSaveStatus_Click;
        }

        private Timer _debounceTimer;
        private void DebounceReload()
        {
            if (_debounceTimer == null)
            {
                _debounceTimer = new Timer();
                _debounceTimer.Interval = 350;
                _debounceTimer.Tick += (s, e) =>
                {
                    _debounceTimer.Stop();
                    LoadReports();
                };
            }
            _debounceTimer.Stop();
            _debounceTimer.Start();
        }

        private void LoadFilters()
        {
            cmbFilterType.Items.Clear();
            cmbFilterType.Items.Add("Tất cả");

            cmbFilterPriority.Items.Clear();
            cmbFilterPriority.Items.Add("Tất cả");

            // Bạn có thể load loại/ưu tiên từ DB riêng.
            // Tạm thời hardcode giống yêu cầu:
            cmbFilterType.Items.AddRange(new object[] { "Sự cố", "Kế toán", "Kho", "CSKH", "Khác" });
            cmbFilterPriority.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao", "Khẩn cấp" });

            cmbFilterType.SelectedIndex = 0;
            cmbFilterPriority.SelectedIndex = 0;
        }

        private void LoadReports()
        {
            string type = cmbFilterType.SelectedItem?.ToString() ?? "Tất cả";
            string pri = cmbFilterPriority.SelectedItem?.ToString() ?? "Tất cả";
            bool onlyUnresolved = chkOnlyUnresolved.Checked;
            string keyword = (txtSearch.Text ?? "").Trim();

            using (var con = new SqlConnection(_cs))
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = con;

                cmd.CommandText = @"
SELECT 
    r.ReportId,
    r.CreatedAt,
    r.ReportType,
    r.Priority,
    r.BillCode,
    r.Subject,
    r.IsResolved,
    u.FullName AS ReporterName
FROM dbo.InternalReport r
LEFT JOIN dbo.[User] u ON u.UserID = r.CreatedByUserId
WHERE 1=1
";
                if (type != "Tất cả")
                {
                    cmd.CommandText += " AND r.ReportType = @type";
                    cmd.Parameters.AddWithValue("@type", type);
                }
                if (pri != "Tất cả")
                {
                    cmd.CommandText += " AND r.Priority = @pri";
                    cmd.Parameters.AddWithValue("@pri", pri);
                }
                if (onlyUnresolved)
                {
                    cmd.CommandText += " AND r.IsResolved = 0";
                }
                if (keyword.Length > 0)
                {
                    cmd.CommandText += " AND (r.Subject LIKE @kw OR r.Content LIKE @kw OR r.BillCode LIKE @kw OR u.FullName LIKE @kw)";
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                }

                cmd.CommandText += " ORDER BY r.IsResolved ASC, r.CreatedAt DESC";

                using (var da = new SqlDataAdapter(cmd))
                {
                    _dt = new DataTable();
                    da.Fill(_dt);
                }
            }

            dgvReports.DataSource = _dt;

            // đặt tiêu đề cột
            if (dgvReports.Columns["ReportId"] != null) dgvReports.Columns["ReportId"].HeaderText = "ID";
            if (dgvReports.Columns["CreatedAt"] != null) dgvReports.Columns["CreatedAt"].HeaderText = "Thời gian";
            if (dgvReports.Columns["ReportType"] != null) dgvReports.Columns["ReportType"].HeaderText = "Loại";
            if (dgvReports.Columns["Priority"] != null) dgvReports.Columns["Priority"].HeaderText = "Ưu tiên";
            if (dgvReports.Columns["BillCode"] != null) dgvReports.Columns["BillCode"].HeaderText = "Mã Bill";
            if (dgvReports.Columns["Subject"] != null) dgvReports.Columns["Subject"].HeaderText = "Chủ đề";
            if (dgvReports.Columns["ReporterName"] != null) dgvReports.Columns["ReporterName"].HeaderText = "Nhân viên";
            if (dgvReports.Columns["IsResolved"] != null) dgvReports.Columns["IsResolved"].HeaderText = "Đã xử lý";

            if (dgvReports.Rows.Count > 0)
                dgvReports.Rows[0].Selected = true;
        }

        private void LoadSelectedReportToDetail()
        {
            if (dgvReports.CurrentRow == null) return;
            var row = dgvReports.CurrentRow;

            _currentReportId = Convert.ToInt32(row.Cells["ReportId"].Value);

            txtType.Text = Convert.ToString(row.Cells["ReportType"].Value);
            txtPriority.Text = Convert.ToString(row.Cells["Priority"].Value);
            txtReporter.Text = Convert.ToString(row.Cells["ReporterName"].Value);
            dtpCreatedAt.Value = Convert.ToDateTime(row.Cells["CreatedAt"].Value);
            txtBillCode.Text = Convert.ToString(row.Cells["BillCode"].Value);
            txtSubject.Text = Convert.ToString(row.Cells["Subject"].Value);

            // Load full content + status note từ DB cho chắc
            using (var con = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(@"
SELECT Content, IsResolved, ResolveNote
FROM dbo.InternalReport
WHERE ReportId = @id
", con))
            {
                cmd.Parameters.AddWithValue("@id", _currentReportId);
                con.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        txtContent.Text = rd["Content"]?.ToString() ?? "";
                        chkResolved.Checked = Convert.ToBoolean(rd["IsResolved"]);
                        txtResolveNote.Text = rd["ResolveNote"]?.ToString() ?? "";
                    }
                }
            }
        }

        private void btnSaveStatus_Click(object sender, EventArgs e)
        {
            if (_currentReportId <= 0)
            {
                MessageBox.Show("Chưa chọn báo cáo nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var con = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(@"
UPDATE dbo.InternalReport
SET 
    IsResolved = @done,
    ResolvedAt = CASE WHEN @done = 1 THEN GETDATE() ELSE NULL END,
    ResolvedByUserId = CASE WHEN @done = 1 THEN @uid ELSE NULL END,
    ResolveNote = @note
WHERE ReportId = @id
", con))
            {
                cmd.Parameters.AddWithValue("@done", chkResolved.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@uid", JumpArena.Session.UserId);
                cmd.Parameters.AddWithValue("@note", (txtResolveNote.Text ?? "").Trim());
                cmd.Parameters.AddWithValue("@id", _currentReportId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã lưu trạng thái xử lý.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadReports();
        }
    }
}
