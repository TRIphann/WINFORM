using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JumpArena
{
    public partial class frmWorkShiftManagement : Form
    {
        private readonly string _connStr =
            ConfigurationManager.ConnectionStrings["JumpArenaContextDB"].ConnectionString;

        private Timer _shiftTimer;
        private DateTime? _currentShiftStartTime;

        public frmWorkShiftManagement()
        {
            InitializeComponent();

            // ===== UI theo yêu cầu =====
            // End = thoát
            btnEndSelectedShifts.Text = "End";
            btnEndSelectedShifts.Click += (s, e) => this.Close();

            // Ẩn nút NEW nếu còn
            if (btnStartNewShift != null) btnStartNewShift.Visible = false;

            // Grid cơ bản
            SetupGrid(dgvActiveShifts);
            SetupGrid(dgvPersonalShiftHistory);

            // Search / Refresh (nếu không cần thì bỏ cũng được)
            btnSearch.Click += (s, e) => RefreshData();
            btnRefresh.Click += (s, e) =>
            {
                txtSearchStaff.Clear();
                RefreshData();
            };

            this.Load += frmWorkShiftManagement_Load;
            this.FormClosed += frmWorkShiftManagement_FormClosed;
        }

        private void frmWorkShiftManagement_Load(object sender, EventArgs e)
        {
            // 1) Chi nhánh: chỉ 1 JumpArena
            cbBranchFilter.Items.Clear();
            cbBranchFilter.Items.Add("JumpArena");
            cbBranchFilter.SelectedIndex = 0;
            cbBranchFilter.Enabled = false;

            // 2) Vai trò: đúng vai trò user chọn
            // ƯU TIÊN: Session.RoleName (nếu bạn có)
            // FALLBACK: frmSelectRole.SelectedRole.RoleName (bạn đang có)
            string roleName = "";
            try
            {
                // Nếu bạn có Session.RoleName thì dùng
                roleName = Session.RoleName;
            }
            catch
            {
                // Không có Session.RoleName thì lấy từ SelectedRole
                roleName = frmSelectRole.SelectedRole.RoleName;
            }

            if (string.IsNullOrWhiteSpace(roleName)) roleName = "Không rõ";

            cbRoleFilter.Items.Clear();
            cbRoleFilter.Items.Add(roleName);
            cbRoleFilter.SelectedIndex = 0;
            cbRoleFilter.Enabled = false;

            // 3) Trễ giờ: 00:00:00
            lblLateCount.Text = "Trễ giờ : 00:00:00";

            // 4) Load dữ liệu + start timer
            RefreshData();
            LoadCurrentShiftStartTime();
            StartShiftTimer();
        }

        private void frmWorkShiftManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_shiftTimer != null)
            {
                _shiftTimer.Stop();
                _shiftTimer.Tick -= ShiftTimer_Tick;
                _shiftTimer.Dispose();
                _shiftTimer = null;
            }
        }

        // ====== TIMER: Đang làm việc đếm realtime ======
        private void StartShiftTimer()
        {
            if (_shiftTimer != null) return;

            _shiftTimer = new Timer();
            _shiftTimer.Interval = 1000;
            _shiftTimer.Tick += ShiftTimer_Tick;
            _shiftTimer.Start();
        }

        private void ShiftTimer_Tick(object sender, EventArgs e)
        {
            // mỗi vài giây reload lại start time để tránh “leak” do đổi user / đổi ca
            // (nhẹ thôi, 5 giây reload 1 lần)
            if (DateTime.Now.Second % 5 == 0)
                LoadCurrentShiftStartTime();

            if (_currentShiftStartTime == null)
            {
                lblActiveCount.Text = "Đang làm việc : 00:00:00";
                return;
            }

            TimeSpan elapsed = DateTime.Now - _currentShiftStartTime.Value;
            if (elapsed < TimeSpan.Zero) elapsed = TimeSpan.Zero;

            lblActiveCount.Text = "Đang làm việc : " + elapsed.ToString(@"hh\:mm\:ss");
        }

        private void LoadCurrentShiftStartTime()
        {
            // Nếu user chưa login đúng
            if (Session.UserId <= 0)
            {
                _currentShiftStartTime = null;
                lblActiveCount.Text = "Đang làm việc : 00:00:00";
                return;
            }

            // Lấy StartTime ca đang mở (EndTime NULL) của user
            const string sql = @"
SELECT TOP 1 StartTime
FROM WorkShift
WHERE UserID = @UserID AND EndTime IS NULL
ORDER BY StartTime DESC;";

            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", Session.UserId);
                conn.Open();
                object val = cmd.ExecuteScalar();

                if (val == null || val == DBNull.Value)
                {
                    _currentShiftStartTime = null;
                    lblActiveCount.Text = "Đang làm việc : 00:00:00";
                }
                else
                {
                    _currentShiftStartTime = Convert.ToDateTime(val);
                }
            }
        }

        // ====== DATA ======
        private void RefreshData()
        {
            // Bên trái: ca đang mở của user (gọn, khỏi lẫn với ca người khác)
            dgvActiveShifts.DataSource = GetMyActiveShift(Session.UserId);

            // Bên phải: lịch sử cá nhân
            dgvPersonalShiftHistory.DataSource = GetPersonalHistory(Session.UserId);
        }

        private DataTable GetMyActiveShift(int userId)
        {
            // Có search theo tên thì… vô nghĩa vì đây là ca của chính user. Nên bỏ luôn.
            const string sql = @"
SELECT 
    ws.WorkShiftID AS [Mã ca],
    u.FullName     AS [Nhân viên],
    ws.StartTime   AS [Bắt đầu],
    ws.EndTime     AS [Kết thúc],
    DATEDIFF(MINUTE, ws.StartTime, ISNULL(ws.EndTime, GETDATE())) AS [Phút làm]
FROM WorkShift ws
JOIN [User] u ON u.UserID = ws.UserID
WHERE ws.UserID = @UserID AND ws.EndTime IS NULL
ORDER BY ws.StartTime DESC;";

            return FillTable(sql, new[] { new SqlParameter("@UserID", userId) });
        }

        private DataTable GetPersonalHistory(int userId)
        {
            // Lọc theo ô tìm kiếm (tùy bạn thích), ở đây chỉ lấy lịch sử cá nhân nên search cũng không cần.
            const string sql = @"
SELECT TOP 50
    ws.WorkShiftID AS [Mã ca],
    ws.StartTime   AS [Bắt đầu],
    ws.EndTime     AS [Kết thúc],
    DATEDIFF(MINUTE, ws.StartTime, ISNULL(ws.EndTime, GETDATE())) AS [Phút làm]
FROM WorkShift ws
WHERE ws.UserID = @UserID
ORDER BY ws.StartTime DESC;";

            return FillTable(sql, new[] { new SqlParameter("@UserID", userId) });
        }

        private DataTable FillTable(string sql, SqlParameter[] parameters)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }

        private void SetupGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = true;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
