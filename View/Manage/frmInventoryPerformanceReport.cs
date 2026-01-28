using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace JumpArena
{
    public partial class frmInventoryPerformanceReport : Form
    {
        private readonly string _connStr =
          System.Configuration.ConfigurationManager
              .ConnectionStrings["JumpArenaContextDB"]?.ConnectionString
          ?? throw new InvalidOperationException("Thiếu connection string 'JumpArenaContextDB' trong App.config");

        // Bạn chỉnh ngưỡng tồn thấp tùy ý
        private const int LOW_STOCK_THRESHOLD = 10;

        // Mode xem báo cáo
        private enum ReportMode { SummaryByProduct, SalesDetail }
        private ReportMode _mode = ReportMode.SummaryByProduct;

        public frmInventoryPerformanceReport()
        {
            InitializeComponent();

            // Gắn event
            this.Load += frmInventoryPerformanceReport_Load;
            btnGenerateReport.Click += btnGenerateReport_Click;
            btnExportExcel.Click += btnExportExcel_Click;

            txtSearchProduct.TextChanged += (_, __) => ApplySearchFilter();
            cbProductGroup.SelectedIndexChanged += (_, __) => ApplySearchFilter();

            dgvProductSummary.DataError += (_, e) =>
            {
                e.ThrowException = false; // khỏi crash vì format
            };
        }

        private void frmInventoryPerformanceReport_Load(object sender, EventArgs e)
        {
            // Fix “tên biến bị ngược”: bạn đang dùng dtpEndDate cho "Từ Ngày" và dtpStartDate cho "Đến Ngày"
            // Tôi không sửa designer của bạn, tôi xử lý logic ở đây:
            SetDefaultDates();

            LoadProductGroups();

            SetupGrid();

            // Load lần đầu
            LoadReport();
        }

        private void SetDefaultDates()
        {
            // Mặc định: hôm nay
            var today = DateTime.Today;
            dtpEndDate.Value = today;                 // "Từ Ngày" (theo UI)
            dtpStartDate.Value = today.AddDays(1).AddTicks(-1); // "Đến Ngày" end of today
        }

        private (DateTime from, DateTime to) GetDateRange()
        {
            // UI của bạn: lblFromDate gắn dtpEndDate, lblToDate gắn dtpStartDate
            var from = dtpEndDate.Value.Date;
            var to = dtpStartDate.Value;

            // ép "Đến ngày" thành cuối ngày nếu user chọn date-only
            to = to.Date.AddDays(1).AddTicks(-1);

            if (from > to)
            {
                // tự đổi lại cho user khỏi phải suy nghĩ
                var tmp = from;
                from = to.Date;
                to = tmp.Date.AddDays(1).AddTicks(-1);
            }

            return (from, to);
        }

        private void SetupGrid()
        {
            dgvProductSummary.AutoGenerateColumns = true;
            dgvProductSummary.ReadOnly = true;
            dgvProductSummary.AllowUserToAddRows = false;
            dgvProductSummary.AllowUserToDeleteRows = false;
            dgvProductSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadProductGroups()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(0, "Tất cả");

            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(@"
        SELECT CategoryID AS Id, CategoryName AS Name
        FROM Category
        ORDER BY CategoryName", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var tmp = new DataTable();
                conn.Open();
                da.Fill(tmp);

                foreach (DataRow r in tmp.Rows)
                    dt.Rows.Add(Convert.ToInt32(r["Id"]), r["Name"].ToString());
            }

            cbProductGroup.DisplayMember = "Name";
            cbProductGroup.ValueMember = "Id";
            cbProductGroup.DataSource = dt;
            cbProductGroup.SelectedValue = 0;
        }


        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            var (from, to) = GetDateRange();
            int groupId = cbProductGroup.SelectedValue is int v ? v : 0;
            string keyword = (txtSearchProduct.Text ?? "").Trim();

            // Mặc định: Tổng hợp theo sản phẩm (đúng cái tên dgvProductSummary của bạn)
            // Nếu bạn muốn thêm chế độ chi tiết: đổi _mode ở đây bằng nút/combobox
            var dt = _mode == ReportMode.SummaryByProduct
                ? GetSummaryByProduct(from, to, groupId, keyword)
                : GetSalesDetail(from, to, groupId, keyword);

            dgvProductSummary.DataSource = dt;

            UpdateHeaderTotals(dt);
            ApplyLowStockHighlighting();
        }

        private DataTable GetSummaryByProduct(DateTime from, DateTime to, int categoryId, string keyword)
        {
            var dt = new DataTable();

            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(@"
        ;WITH Sold AS (
            SELECT 
                d.ProductID,
                SUM(d.Quantity) AS QtySold,
                SUM(d.Quantity * ISNULL(d.PriceAtPurchase,0)) AS Revenue
            FROM InvoiceDetail d
            INNER JOIN Invoice i ON i.InvoiceID = d.InvoiceID
            WHERE i.CreatedDate >= @From AND i.CreatedDate <= @To
            GROUP BY d.ProductID
        )
        SELECT
            p.ProductID,
            p.ProductName,
            c.CategoryName,
            ISNULL(s.QtySold, 0) AS QtySold,
            CASE WHEN ISNULL(p.IsStockManaged,0) = 1 THEN ISNULL(p.StockQuantity,0) ELSE NULL END AS StockRemaining,
            ISNULL(s.Revenue, 0) AS Revenue
        FROM Product p
        LEFT JOIN Category c ON c.CategoryID = p.CategoryID
        LEFT JOIN Sold s ON s.ProductID = p.ProductID
        WHERE
            (@CategoryId = 0 OR p.CategoryID = @CategoryId)
            AND (@Keyword = '' OR p.ProductName LIKE '%' + @Keyword + '%')
        ORDER BY ISNULL(s.QtySold,0) DESC, p.ProductName ASC
    ", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@From", from);
                cmd.Parameters.AddWithValue("@To", to);
                cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                cmd.Parameters.AddWithValue("@Keyword", keyword);

                conn.Open();
                da.Fill(dt);
            }

            return dt;
        }


        private DataTable GetSalesDetail(DateTime from, DateTime to, int categoryId, string keyword)
        {
            var dt = new DataTable();

            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(@"
        SELECT
            i.CreatedDate AS SoldAt,
            i.InvoiceID AS InvoiceNo,
            p.ProductID,
            p.ProductName,
            c.CategoryName,
            d.Quantity AS Qty,
            ISNULL(d.PriceAtPurchase,0) AS UnitPrice,
            (d.Quantity * ISNULL(d.PriceAtPurchase,0)) AS LineTotal
        FROM InvoiceDetail d
        INNER JOIN Invoice i ON i.InvoiceID = d.InvoiceID
        INNER JOIN Product p ON p.ProductID = d.ProductID
        LEFT JOIN Category c ON c.CategoryID = p.CategoryID
        WHERE
            i.CreatedDate >= @From AND i.CreatedDate <= @To
            AND (@CategoryId = 0 OR p.CategoryID = @CategoryId)
            AND (@Keyword = '' OR p.ProductName LIKE '%' + @Keyword + '%')
        ORDER BY i.CreatedDate DESC
    ", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@From", from);
                cmd.Parameters.AddWithValue("@To", to);
                cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                cmd.Parameters.AddWithValue("@Keyword", keyword);

                conn.Open();
                da.Fill(dt);
            }

            return dt;
        }


        private void UpdateHeaderTotals(DataTable dt)
        {
            long totalSold = 0;

            if (dt.Columns.Contains("QtySold"))
                totalSold = dt.AsEnumerable().Sum(r => Convert.ToInt64(r["QtySold"]));
            else if (dt.Columns.Contains("Qty"))
                totalSold = dt.AsEnumerable().Sum(r => Convert.ToInt64(r["Qty"]));

            long totalStock = 0;
            if (dt.Columns.Contains("StockRemaining"))
            {
                totalStock = dt.AsEnumerable()
                    .Where(r => r["StockRemaining"] != DBNull.Value)
                    .Sum(r => Convert.ToInt64(r["StockRemaining"]));
            }

            lblTotalItems.Text = $"Tổng Số Sản Phẩm : {totalSold:N0}";
            lblGrandStock.Text = $"Tổng Tồn kho : {totalStock:N0}";
        }


        private void ApplyLowStockHighlighting()
        {
            // tô hàng sắp hết (chỉ với Summary)
            if (dgvProductSummary.DataSource == null) return;
            if (!dgvProductSummary.Columns.Contains("StockRemaining")) return;

            foreach (DataGridViewRow row in dgvProductSummary.Rows)
            {
                var cellVal = row.Cells["StockRemaining"].Value;
                if (cellVal == null || cellVal == DBNull.Value) continue;

                if (int.TryParse(cellVal.ToString(), out int stock) && stock < LOW_STOCK_THRESHOLD)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose;
                }
            }
        }

        private void ApplySearchFilter()
        {
            // Nếu bạn muốn lọc client-side (không query lại DB):
            // nhưng vì bạn cần đúng dữ liệu theo ngày, tôi khuyên query lại cho chuẩn.
            // Lọc nhanh thì dùng LoadReport().
            LoadReport();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvProductSummary.DataSource == null)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"InventoryPerformance_{DateTime.Now:yyyyMMdd_HHmm}.xlsx"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                var dt = dgvProductSummary.DataSource as DataTable;
                if (dt == null)
                {
                    MessageBox.Show("DataSource không phải DataTable. Xuất thất bại.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add(dt, "Report");

                    // Format numeric cột nếu có
                    if (dt.Columns.Contains("QtySold")) ws.Column(dt.Columns["QtySold"].Ordinal + 1).Style.NumberFormat.Format = "#,##0";
                    if (dt.Columns.Contains("Qty")) ws.Column(dt.Columns["Qty"].Ordinal + 1).Style.NumberFormat.Format = "#,##0";
                    if (dt.Columns.Contains("StockRemaining")) ws.Column(dt.Columns["StockRemaining"].Ordinal + 1).Style.NumberFormat.Format = "#,##0";
                    if (dt.Columns.Contains("Revenue")) ws.Column(dt.Columns["Revenue"].Ordinal + 1).Style.NumberFormat.Format = "#,##0";
                    if (dt.Columns.Contains("UnitPrice")) ws.Column(dt.Columns["UnitPrice"].Ordinal + 1).Style.NumberFormat.Format = "#,##0";
                    if (dt.Columns.Contains("LineTotal")) ws.Column(dt.Columns["LineTotal"].Ordinal + 1).Style.NumberFormat.Format = "#,##0";

                    // Auto fit
                    ws.Columns().AdjustToContents();

                    // Ghi thêm dòng tổng ở cuối
                    int lastRow = ws.LastRowUsed().RowNumber() + 2;
                    ws.Cell(lastRow, 1).Value = "Tổng SP bán:";
                    ws.Cell(lastRow, 2).Value = lblTotalItems.Text.Replace("Tổng Số Sản Phẩm :", "").Trim();

                    ws.Cell(lastRow + 1, 1).Value = "Tổng tồn kho:";
                    ws.Cell(lastRow + 1, 2).Value = lblGrandStock.Text.Replace("Tổng Tồn kho :", "").Trim();

                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Xuất Excel xong. Vậy là máy tính cũng làm được việc.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
