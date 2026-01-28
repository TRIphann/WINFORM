using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JumpArena
{
    public partial class frmRevenueReport : Form
    {
        private readonly string connectionString =
            "Data Source=localhost\\SQL2022NEW;Initial Catalog=JumpArenaDB;User ID=sa;Password=123456;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";

        public frmRevenueReport()
        {
            InitializeComponent();
            this.Load += frmRevenueReport_Load;
        }

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            cbThang.Items.Clear();
            cbNam.Items.Clear();

            // Tháng 01-12
            for (int i = 1; i <= 12; i++)
                cbThang.Items.Add(i.ToString("00"));

            // Năm 2023 -> hiện tại + 2
            for (int year = 2023; year <= DateTime.Now.Year + 2; year++)
                cbNam.Items.Add(year.ToString());

            // Default tháng/năm hiện tại
            cbThang.SelectedItem = "01";
            cbNam.SelectedItem = "2026";


            btnXem.PerformClick();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cbThang.SelectedItem == null || cbNam.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tháng và năm.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int thang = int.Parse(cbThang.SelectedItem.ToString());
            int nam = int.Parse(cbNam.SelectedItem.ToString());

            try
            {
                DataTable dt = LayDoanhThuTheoThang(thang, nam);

                dgvDoanhThuChiTiet.DataSource = dt;

                decimal tongDoanhThu = 0m;
                int tongSoHD = 0;

                if (dt.Rows.Count > 0)
                {
                    tongDoanhThu = dt.AsEnumerable()
                        .Sum(r => Convert.ToDecimal(r["ThanhTien"]));

                    tongSoHD = dt.AsEnumerable()
                        .Sum(r => Convert.ToInt32(r["SoHoaDon"]));
                }

                decimal trungBinhNgay = dt.Rows.Count > 0
                    ? tongDoanhThu / dt.Rows.Count
                    : 0;

                lblTongDoanhThu.Text = $"Tổng doanh thu tháng: {tongDoanhThu:N0} VNĐ";
                lblSoHoaDon.Text = $"Số lượng hóa đơn: {tongSoHD}";
                lblTrungBinhNgay.Text = $"Doanh thu TB/ngày: {trungBinhNgay:N0} VNĐ";

                VeBieuDo(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private DataTable LayDoanhThuTheoThang(int thang, int nam)
        {
            DataTable dt = new DataTable();

            string query = @"
        SELECT 
            CAST(CreatedDate AS DATE) AS Ngay,
            COUNT(InvoiceID) AS SoHoaDon,
            SUM(TotalOriginalAmount) AS DoanhThuGoc,
            SUM(DiscountAmount) AS GiamGia,
            SUM(TotalOriginalAmount - DiscountAmount) AS ThanhTien
        FROM Invoice
        WHERE MONTH(CreatedDate) = @Thang
          AND YEAR(CreatedDate) = @Nam
        GROUP BY CAST(CreatedDate AS DATE)
        ORDER BY Ngay";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam", nam);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                conn.Open();
                da.Fill(dt);
            }

            return dt;
        }


        private void VeBieuDo(DataTable dt)
        {
            chartDoanhThu.Series.Clear();

            var series = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            chartDoanhThu.Series.Add(series);

            var area = chartDoanhThu.ChartAreas[0];
            area.AxisX.Title = "Ngày";
            area.AxisY.Title = "Doanh thu (VNĐ)";
            area.AxisY.LabelStyle.Format = "#,##0";
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;

            if (dt.Rows.Count == 0)
            {
                series.Points.AddXY("Không có dữ liệu", 0);
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                var date = Convert.ToDateTime(row["Ngay"]);
                var value = row["ThanhTien"] == DBNull.Value ? 0m : Convert.ToDecimal(row["ThanhTien"]);
                series.Points.AddXY(date.ToString("dd"), value); // theo ngày trong tháng
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvDoanhThuChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.Title = "Xuất báo cáo doanh thu";
                sfd.FileName = $"BaoCaoDoanhThu_{cbThang.Text}-{cbNam.Text}.xlsx";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("DoanhThu");

                    ws.Cell(1, 1).Value = "BÁO CÁO DOANH THU";
                    ws.Cell(1, 1).Style.Font.Bold = true;
                    ws.Cell(1, 1).Style.Font.FontSize = 18;
                    ws.Range("A1:E1").Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    ws.Cell(3, 1).Value = $"Tháng {cbThang.Text} - Năm {cbNam.Text}";
                    ws.Cell(3, 1).Style.Font.Bold = true;

                    ws.Cell(5, 1).Value = lblTongDoanhThu.Text;
                    ws.Cell(6, 1).Value = lblSoHoaDon.Text;
                    ws.Cell(7, 1).Value = lblTrungBinhNgay.Text;

                    int headerRow = 9;

                    for (int c = 0; c < dgvDoanhThuChiTiet.Columns.Count; c++)
                    {
                        ws.Cell(headerRow, c + 1).Value = dgvDoanhThuChiTiet.Columns[c].HeaderText;
                        ws.Cell(headerRow, c + 1).Style.Font.Bold = true;
                        ws.Cell(headerRow, c + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                    }

                    int row = headerRow + 1;
                    for (int i = 0; i < dgvDoanhThuChiTiet.Rows.Count; i++)
                    {
                        var gridRow = dgvDoanhThuChiTiet.Rows[i];
                        if (gridRow.IsNewRow) continue;

                        for (int j = 0; j < dgvDoanhThuChiTiet.Columns.Count; j++)
                        {
                            var val = gridRow.Cells[j].Value;
                            var cell = ws.Cell(row, j + 1);

                            if (val == null || val == DBNull.Value)
                            {
                                cell.Value = "";
                            }
                            else if (val is DateTime d)
                            {
                                cell.Value = d;
                                cell.Style.NumberFormat.Format = "dd/MM/yyyy";
                            }
                            else if (val is decimal || val is double || val is float || val is int || val is long)
                            {
                                cell.Value = Convert.ToDecimal(val);
                                cell.Style.NumberFormat.Format = "#,##0";
                            }
                            else
                            {
                                cell.Value = val.ToString();
                            }
                        }

                        row++;
                    }

                    ws.Columns().AdjustToContents();
                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Xuất Excel thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
