using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel;
namespace JumpArena
{
    public partial class frmRevenueReport : Form
    {
        // Connection string từ app.config / web.config (dùng sa + password)
        private readonly string connectionString =
            "data source=LAPTOP-TJTL70JS;initial catalog=JumpArenaDB;persist security info=True;user id=sa;password=Abcd@1234;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";

        public frmRevenueReport()
        {
            InitializeComponent();
        }

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            // Load tháng 01 → 12
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i.ToString("00"));
            }

            // Load năm (dựa trên dữ liệu mẫu từ 2023 trở lên)
            for (int year = 2023; year <= DateTime.Now.Year + 2; year++)
            {
                cbNam.Items.Add(year.ToString());
            }

            // Mặc định chọn tháng/năm hiện tại (hoặc gần nhất có dữ liệu)
            cbThang.SelectedIndex = DateTime.Now.Month - 1;
            string namHienTai = DateTime.Now.Year.ToString();
            if (cbNam.Items.Contains(namHienTai))
            {
                cbNam.SelectedItem = namHienTai;
            }
            else if (cbNam.Items.Count > 0)
            {
                cbNam.SelectedIndex = cbNam.Items.Count - 1; // chọn năm mới nhất
            }

            btnXem.PerformClick(); // Load dữ liệu mặc định
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cbThang.SelectedItem == null || cbNam.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tháng và năm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int thang = int.Parse(cbThang.SelectedItem.ToString());
            int nam = int.Parse(cbNam.SelectedItem.ToString());

            try
            {
                DataTable dt = LayDoanhThuTheoThang(thang, nam);

                // Tính tổng hợp an toàn
                decimal tongDoanhThu = 0;
                int tongSoHD = 0;
                decimal trungBinhNgay = 0;

                if (dt.Rows.Count > 0)
                {
                    tongDoanhThu = dt.AsEnumerable()
                        .Sum(r => r["ThanhTien"] == DBNull.Value ? 0m : Convert.ToDecimal(r["ThanhTien"]));

                    tongSoHD = dt.AsEnumerable()
                        .Sum(r => r["SoHoaDon"] == DBNull.Value ? 0 : Convert.ToInt32(r["SoHoaDon"]));

                    trungBinhNgay = dt.Rows.Count > 0 ? tongDoanhThu / dt.Rows.Count : 0;
                }

                lblTongDoanhThu.Text = $"Tổng doanh thu tháng: {tongDoanhThu:N0} VNĐ";
                lblSoHoaDon.Text = $"Số lượng hóa đơn: {tongSoHD:N0}";
                lblTrungBinhNgay.Text = $"Doanh thu TB/ngày: {trungBinhNgay:N0} VNĐ";

                // Bind DataGridView
                dgvDoanhThuChiTiet.DataSource = dt;

                // Định dạng cột
                foreach (DataGridViewColumn col in dgvDoanhThuChiTiet.Columns)
                {
                    if (new[] { "DoanhThuGoc", "GiamGia", "ThanhTien" }.Contains(col.Name))
                    {
                        col.DefaultCellStyle.Format = "N0";
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    else if (col.Name == "Ngay")
                    {
                        col.DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                }

                // Vẽ biểu đồ
                VeBieuDo(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu:\n{ex.Message}\n\nStackTrace:\n{ex.StackTrace}",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable LayDoanhThuTheoThang(int thang, int nam)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    CAST(i.CreatedDate AS DATE) AS Ngay,
                    COUNT(DISTINCT i.InvoiceID) AS SoHoaDon,
                    ISNULL(SUM(i.TotalOriginalAmount), 0) AS DoanhThuGoc,
                    ISNULL(SUM(i.DiscountAmount), 0) AS GiamGia,
                    ISNULL(SUM(i.TotalOriginalAmount - i.DiscountAmount), 0) AS ThanhTien
                FROM Invoice i
                WHERE MONTH(i.CreatedDate) = @Thang 
                  AND YEAR(i.CreatedDate) = @Nam
                  AND i.Status = N'Hoàn thành'
                GROUP BY CAST(i.CreatedDate AS DATE)
                ORDER BY Ngay";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); // Mở kết nối trước khi dùng adapter
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Thang", thang);
                    cmd.Parameters.AddWithValue("@Nam", nam);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        private void VeBieuDo(DataTable dt)
        {
            chartDoanhThu.Series.Clear();

            var series = new Series("Doanh Thu")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(0, 122, 204),
                BorderWidth = 1,
                IsValueShownAsLabel = true
            };
            chartDoanhThu.Series.Add(series);

            var chartArea = chartDoanhThu.ChartAreas[0];
            chartArea.AxisX.Title = "Ngày";
            chartArea.AxisY.Title = "Doanh thu (VNĐ)";
            chartArea.AxisY.LabelStyle.Format = "#,##0";
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            if (dt.Rows.Count == 0)
            {
                series.Points.AddXY("Không có dữ liệu", 0);
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                string ngay = row["Ngay"] == DBNull.Value
                    ? "N/A"
                    : Convert.ToDateTime(row["Ngay"]).ToString("dd");

                decimal giaTri = row["ThanhTien"] == DBNull.Value
                    ? 0m
                    : Convert.ToDecimal(row["ThanhTien"]);

                series.Points.AddXY(ngay, giaTri);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvDoanhThuChiTiet.Rows.Count <= 1) // Không có dữ liệu thực
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.Title = "Xuất báo cáo doanh thu";
                sfd.FileName = $"BaoCaoDoanhThu_{cbThang.Text}-{cbNam.Text}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var ws = workbook.Worksheets.Add("Doanh Thu");

                            // Tiêu đề báo cáo
                            ws.Cell(1, 1).Value = "BÁO CÁO DOANH THU THÁNG";
                            ws.Cell(1, 1).Style.Font.Bold = true;
                            ws.Cell(1, 1).Style.Font.FontSize = 18;
                            ws.Range("A1:E1").Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                            // Thông tin lọc
                            ws.Cell(3, 1).Value = $"Thời gian: Tháng {cbThang.Text} - Năm {cbNam.Text}";
                            ws.Cell(3, 1).Style.Font.Bold = true;

                            // Tổng hợp (từ label)
                            ws.Cell(5, 1).Value = lblTongDoanhThu.Text;
                            ws.Cell(6, 1).Value = lblSoHoaDon.Text;
                            ws.Cell(7, 1).Value = lblTrungBinhNgay.Text;

                            // Header bảng
                            int currentRow = 9;
                            for (int col = 0; col < dgvDoanhThuChiTiet.Columns.Count; col++)
                            {
                                var headerCell = ws.Cell(currentRow, col + 1);
                                headerCell.Value = dgvDoanhThuChiTiet.Columns[col].HeaderText;
                                headerCell.Style.Font.Bold = true;
                                headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                                headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            }

                            // Dữ liệu bảng - xử lý null và cast an toàn
                            currentRow++;
                            for (int i = 0; i < dgvDoanhThuChiTiet.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvDoanhThuChiTiet.Columns.Count; j++)
                                {
                                    var cell = dgvDoanhThuChiTiet.Rows[i].Cells[j];
                                    var cellValue = cell.Value;

                                    var xlCell = ws.Cell(currentRow + i, j + 1);

                                    if (cellValue == null || cellValue == DBNull.Value)
                                    {
                                        xlCell.Value = string.Empty;
                                    }
                                    else
                                    {
                                        // Xử lý kiểu dữ liệu an toàn
                                        if (cellValue is DateTime dt)
                                        {
                                            xlCell.Value = dt;
                                            xlCell.Style.NumberFormat.Format = "dd/MM/yyyy";
                                        }
                                        else if (cellValue is decimal || cellValue is double || cellValue is float)
                                        {
                                            xlCell.Value = Convert.ToDecimal(cellValue);
                                            xlCell.Style.NumberFormat.Format = "#,##0";
                                            xlCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                                        }
                                        else
                                        {
                                            xlCell.Value = cellValue.ToString();
                                        }
                                    }
                                }
                            }

                            // Tự động điều chỉnh cột
                            ws.Columns().AdjustToContents();

                            // Lưu file
                            workbook.SaveAs(sfd.FileName);

                            MessageBox.Show($"Xuất file Excel thành công!\nĐường dẫn: {sfd.FileName}",
                                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xuất Excel:\n{ex.Message}\n\nChi tiết:\n{ex.StackTrace}",
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}