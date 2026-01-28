using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JumpArena
{
    public partial class frmShiftPerformance : Form
    {
        private readonly string _connStr =
            ConfigurationManager.ConnectionStrings["JumpArenaContextDB"].ConnectionString;

        public frmShiftPerformance()
        {
            InitializeComponent();

            this.Load += frmShiftPerformance_Load;
            dtpSelectDate.ValueChanged += (s, e) => LoadShiftPerformanceForSelectedDate();
        }

        private void frmShiftPerformance_Load(object sender, EventArgs e)
        {
            dgvProductSold.AutoGenerateColumns = true;
            dgvProductSold.ReadOnly = true;
            dgvProductSold.AllowUserToAddRows = false;
            dgvProductSold.RowHeadersVisible = false;
            dgvProductSold.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadShiftPerformanceForSelectedDate();
        }

        private void LoadShiftPerformanceForSelectedDate()
        {
            if (Session.UserId <= 0)
            {
                MessageBox.Show("Chưa có Session.UserId. Login chưa set Session.");
                return;
            }

            // 1) Lấy ca theo ngày đã chọn (ưu tiên ca đang mở, nếu không có thì lấy ca gần nhất trong ngày)
            DateTime selectedDate = dtpSelectDate.Value.Date;

            var shift = GetShiftOfUserByDate(Session.UserId, selectedDate);
            if (shift == null)
            {
                SetHeaderNoShift();
                SetKpiZero();
                dgvProductSold.DataSource = null;
                return;
            }

            int workShiftId = shift.Value.WorkShiftId;
            DateTime start = shift.Value.StartTime;
            DateTime? end = shift.Value.EndTime; // null nếu đang mở
            DateTime endForQuery = end ?? DateTime.Now;

            // 2) Set header
            lblStaffIDt.Text = $"Mã Nhân Viên : {Session.UserId}";
            lblStartTime.Text = $"Thời gian Bắt đầu : {start:dd/MM/yyyy HH:mm:ss}";
            lblEndTime.Text = $"Thời gian Kết thúc : {(end.HasValue ? end.Value.ToString("dd/MM/yyyy HH:mm:ss") : "(Đang làm)")}";

            // 3) KPI
            LoadKpi(Session.UserId, start, endForQuery);

            // 4) Grid sản phẩm bán trong ca
            dgvProductSold.DataSource = LoadProductsSold(Session.UserId, start, endForQuery);
        }

        private (int WorkShiftId, DateTime StartTime, DateTime? EndTime)? GetShiftOfUserByDate(int userId, DateTime date)
        {
            // Ca đang mở
            string sqlOpen = @"
SELECT TOP 1 WorkShiftID, StartTime, EndTime
FROM WorkShift
WHERE UserID = @UserID AND EndTime IS NULL
ORDER BY StartTime DESC;";

            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(sqlOpen, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return (
                            rd.GetInt32(0),
                            rd.GetDateTime(1),
                            rd.IsDBNull(2) ? (DateTime?)null : rd.GetDateTime(2)
                        );
                    }
                }
            }

            // Nếu không có ca đang mở: lấy ca gần nhất trong ngày được chọn
            string sqlDay = @"
SELECT TOP 1 WorkShiftID, StartTime, EndTime
FROM WorkShift
WHERE UserID = @UserID
  AND CAST(StartTime AS DATE) = @Day
ORDER BY StartTime DESC;";

            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(sqlDay, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@Day", date);
                conn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return (
                            rd.GetInt32(0),
                            rd.GetDateTime(1),
                            rd.IsDBNull(2) ? (DateTime?)null : rd.GetDateTime(2)
                        );
                    }
                }
            }

            return null;
        }

        private void LoadKpi(int userId, DateTime start, DateTime end)
        {
            // CẦN: Invoice có cột UserID (bước 1-2 đã làm)
            string sqlKpi = @"
SELECT
    COUNT(DISTINCT i.InvoiceID) AS TotalBills,
    ISNULL(SUM(id.Quantity),0) AS TotalProducts,
    ISNULL(SUM(id.Quantity * id.PriceAtPurchase),0) AS TotalRevenue,
    ISNULL(SUM(i.DiscountAmount),0) AS TotalDiscount
FROM Invoice i
LEFT JOIN InvoiceDetail id ON id.InvoiceID = i.InvoiceID
WHERE i.UserID = @UserID
  AND i.CreatedDate >= @StartTime
  AND i.CreatedDate <= @EndTime
  AND i.PaymentStatus = 'Paid';";

            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(sqlKpi, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@StartTime", start);
                cmd.Parameters.AddWithValue("@EndTime", end);

                conn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        int totalBills = rd.IsDBNull(0) ? 0 : Convert.ToInt32(rd[0]);
                        int totalProducts = rd.IsDBNull(1) ? 0 : Convert.ToInt32(rd[1]);
                        decimal totalRevenue = rd.IsDBNull(2) ? 0 : Convert.ToDecimal(rd[2]);
                        decimal totalDiscount = rd.IsDBNull(3) ? 0 : Convert.ToDecimal(rd[3]);

                        lblTotalBills.Text = $"Tổng Hóa đơn : {totalBills}";
                        lblTotalProductsSold.Text = $"Tổng Sản phẩm : {totalProducts}";
                        lblTotalRevenue.Text = $"Tổng Tiền : {totalRevenue:N0} ₫";
                        lblTotalDiscount.Text = $"Tổng Giảm giá : {totalDiscount:N0} ₫";
                        return;
                    }
                }
            }

            SetKpiZero();
        }

        private DataTable LoadProductsSold(int userId, DateTime start, DateTime end)
        {
            string sql = @"
SELECT
    p.ProductName AS [Sản phẩm],
    SUM(id.Quantity) AS [Số lượng],
    id.PriceAtPurchase AS [Giá],
    SUM(id.Quantity * id.PriceAtPurchase) AS [Tổng tiền]
FROM Invoice i
JOIN InvoiceDetail id ON id.InvoiceID = i.InvoiceID
JOIN Product p ON p.ProductID = id.ProductID
WHERE i.UserID = @UserID
  AND i.CreatedDate >= @StartTime
  AND i.CreatedDate <= @EndTime
  AND i.PaymentStatus = 'Paid'
GROUP BY p.ProductName, id.PriceAtPurchase
ORDER BY [Tổng tiền] DESC;";

            var dt = new DataTable();
            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@StartTime", start);
                cmd.Parameters.AddWithValue("@EndTime", end);
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }

        private void SetHeaderNoShift()
        {
            lblStaffIDt.Text = $"Mã Nhân Viên : {Session.UserId}";
            lblStartTime.Text = "Thời gian Bắt đầu : -";
            lblEndTime.Text = "Thời gian Kết thúc : -";
        }

        private void SetKpiZero()
        {
            lblTotalBills.Text = "Tổng Hóa đơn : 0";
            lblTotalProductsSold.Text = "Tổng Sản phẩm : 0";
            lblTotalRevenue.Text = "Tổng Tiền : 0 ₫";
            lblTotalDiscount.Text = "Tổng Giảm giá : 0 ₫";
        }
    }
}
