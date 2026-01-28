using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using ClosedXML.Excel;

namespace JumpArena
{
    public partial class frmBestSeller : Form
    {
        private readonly string connectionString =
            "data source=LAPTOP-TJTL70JS;initial catalog=JumpArenaDB;persist security info=True;user id=sa;password=Abcd@1234;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";

        public frmBestSeller()
        {
            InitializeComponent();
        }

        private void frmSanPhamBanChay_Load(object sender, EventArgs e)
        {
            // Load tháng
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i.ToString("00"));
            }

            // Load năm
            for (int year = 2023; year <= DateTime.Now.Year + 2; year++)
            {
                cbNam.Items.Add(year.ToString());
            }

            cbThang.SelectedIndex = DateTime.Now.Month - 1;
            cbNam.SelectedItem = DateTime.Now.Year.ToString();

            btnXem.PerformClick();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cbThang.SelectedItem == null || cbNam.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tháng và năm.", "Cảnh báo");
                return;
            }

            int thang = int.Parse(cbThang.SelectedItem.ToString());
            int nam = int.Parse(cbNam.SelectedItem.ToString());

            try
            {
                DataTable dt = LaySanPhamBanChay(thang, nam);

                dgvSanPhamBanChay.DataSource = dt;

                // Định dạng cột
                foreach (DataGridViewColumn col in dgvSanPhamBanChay.Columns)
                {
                    if (col.Name == "DoanhThu")
                    {
                        col.DefaultCellStyle.Format = "N0";
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    else if (col.Name == "TyLeDongGop")
                    {
                        col.DefaultCellStyle.Format = "P2";
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    else if (col.Name == "SoLuongBan")
                    {
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }

                VeBieuDo(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu:\n{ex.Message}\n\nChi tiết:\n{ex.StackTrace}", "Lỗi");
            }
        }

        private DataTable LaySanPhamBanChay(int thang, int nam)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT TOP 10
                    p.ProductName AS TenSanPham,
                    SUM(id.Quantity) AS SoLuongBan,
                    SUM(id.Quantity * id.PriceAtPurchase) AS DoanhThu,
                    CASE WHEN SUM(id.Quantity * id.PriceAtPurchase) > 0 
                         THEN CAST(SUM(id.Quantity * id.PriceAtPurchase) AS DECIMAL(18,2)) / 
                              (SELECT SUM(id2.Quantity * id2.PriceAtPurchase) 
                               FROM InvoiceDetail id2 
                               JOIN Invoice i2 ON id2.InvoiceID = i2.InvoiceID 
                               WHERE MONTH(i2.CreatedDate) = @Thang AND YEAR(i2.CreatedDate) = @Nam 
                               AND i2.Status = N'Hoàn thành') * 100 
                         ELSE 0 END AS TyLeDongGop
                FROM InvoiceDetail id
                JOIN Invoice i ON id.InvoiceID = i.InvoiceID
                JOIN Product p ON id.ProductID = p.ProductID
                WHERE MONTH(i.CreatedDate) = @Thang 
                  AND YEAR(i.CreatedDate) = @Nam
                  AND i.Status = N'Hoàn thành'
                GROUP BY p.ProductName
                ORDER BY SoLuongBan DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
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
            chartSanPhamBanChay.Series.Clear();

            var series = new Series("Số lượng bán")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(0, 122, 204),
                IsValueShownAsLabel = true
            };
            chartSanPhamBanChay.Series.Add(series);

            var area = chartSanPhamBanChay.ChartAreas[0];
            area.AxisX.Title = "Sản phẩm";
            area.AxisY.Title = "Số lượng bán";
            area.AxisY.LabelStyle.Format = "#,##0";
            area.AxisX.Interval = 1;

            if (dt.Rows.Count == 0)
            {
                series.Points.AddXY("Không có dữ liệu", 0);
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                string tenSP = row["TenSanPham"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuongBan"]);
                series.Points.AddXY(tenSP, soLuong);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvSanPhamBanChay.Rows.Count <= 1)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = $"SanPhamBanChay_{cbThang.Text}-{cbNam.Text}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var ws = workbook.Worksheets.Add("SanPhamBanChay");

                            ws.Cell(1, 1).Value = "BÁO CÁO SẢN PHẨM BÁN CHẠY NHẤT";
                            ws.Cell(1, 1).Style.Font.Bold = true;
                            ws.Cell(1, 1).Style.Font.FontSize = 18;
                            ws.Range("A1:D1").Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                            ws.Cell(3, 1).Value = $"Thời gian: Tháng {cbThang.Text} - Năm {cbNam.Text}";
                            ws.Cell(3, 1).Style.Font.Bold = true;

                            int row = 5;
                            for (int col = 0; col < dgvSanPhamBanChay.Columns.Count; col++)
                            {
                                ws.Cell(row, col + 1).Value = dgvSanPhamBanChay.Columns[col].HeaderText;
                                ws.Cell(row, col + 1).Style.Font.Bold = true;
                                ws.Cell(row, col + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                            }

                            row++;
                            for (int i = 0; i < dgvSanPhamBanChay.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvSanPhamBanChay.Columns.Count; j++)
                                {
                                    var value = dgvSanPhamBanChay.Rows[i].Cells[j].Value;
                                    var xlCell = ws.Cell(row + i, j + 1);

                                    if (value == null || value == DBNull.Value)
                                    {
                                        xlCell.Value = string.Empty;
                                    }
                                    else if (value is decimal || value is double)
                                    {
                                        xlCell.Value = Convert.ToDecimal(value);
                                        xlCell.Style.NumberFormat.Format = "#,##0";
                                    }
                                    else
                                    {
                                        xlCell.Value = value.ToString();
                                    }
                                }
                            }

                            ws.Columns().AdjustToContents();
                            workbook.SaveAs(sfd.FileName);

                            MessageBox.Show($"Xuất thành công!\n{sfd.FileName}", "Thành công");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi xuất Excel:\n{ex.Message}", "Lỗi");
                    }
                }
            }
        }
    }
}