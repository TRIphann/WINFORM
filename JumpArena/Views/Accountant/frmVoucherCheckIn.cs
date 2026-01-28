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
    public partial class frmVoucherCheckIn : Form
    {
        private readonly string connectionString =
            "data source=LAPTOP-TJTL70JS;initial catalog=JumpArenaDB;persist security info=True;user id=sa;password=Abcd@1234;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";

        public frmVoucherCheckIn()
        {
            InitializeComponent();
        }

        private void frmVoucherCheckIn_Load(object sender, EventArgs e)
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
                // Voucher đang áp dụng (trong thời gian lọc)
                DataTable dtDangApDung = LayVoucherDangApDung(thang, nam);
                dgvDangApDung.DataSource = dtDangApDung;

                // Voucher hết hạn (EndDate < ngày đầu tháng lọc)
                DataTable dtHetHan = LayVoucherHetHan(thang, nam);
                dgvHetHan.DataSource = dtHetHan;

                // Biểu đồ top voucher áp dụng nhiều nhất
                DataTable dtTop = LayTopVoucherApDung(thang, nam);
                VeBieuDo(dtTop);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu:\n{ex.Message}", "Lỗi");
            }
        }

        private DataTable LayVoucherDangApDung(int thang, int nam)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    v.VoucherCode,
                    v.Description,
                    v.DiscountType,
                    v.DiscountValue,
                    COUNT(i.VoucherID) AS SoLuongApDung
                FROM Voucher v
                LEFT JOIN Invoice i ON v.VoucherID = i.VoucherID AND i.Status = N'Hoàn thành'
                WHERE v.StartDate <= DATEFROMPARTS(@Nam, @Thang, 1) 
                  AND v.EndDate >= DATEFROMPARTS(@Nam, @Thang, 1)
                GROUP BY v.VoucherCode, v.Description, v.DiscountType, v.DiscountValue
                ORDER BY SoLuongApDung DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Thang", thang);
                    cmd.Parameters.AddWithValue("@Nam", nam);
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }

            return dt;
        }

        private DataTable LayVoucherHetHan(int thang, int nam)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    v.VoucherCode,
                    v.Description,
                    v.DiscountType,
                    v.DiscountValue,
                    v.EndDate
                FROM Voucher v
                WHERE v.EndDate < DATEFROMPARTS(@Nam, @Thang, 1)
                ORDER BY v.EndDate DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Thang", thang);
                    cmd.Parameters.AddWithValue("@Nam", nam);
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }

            return dt;
        }

        private DataTable LayTopVoucherApDung(int thang, int nam)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT TOP 10
                    v.VoucherCode,
                    COUNT(i.VoucherID) AS SoLuongApDung
                FROM Voucher v
                LEFT JOIN Invoice i ON v.VoucherID = i.VoucherID 
                    AND i.Status = N'Hoàn thành'
                    AND MONTH(i.CreatedDate) = @Thang
                    AND YEAR(i.CreatedDate) = @Nam
                GROUP BY v.VoucherCode
                ORDER BY SoLuongApDung DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Thang", thang);
                    cmd.Parameters.AddWithValue("@Nam", nam);
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }

            return dt;
        }

        private void VeBieuDo(DataTable dt)
        {
            chartVoucherTop.Series.Clear();

            var series = new Series("Số lượng áp dụng")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(0, 122, 204),
                IsValueShownAsLabel = true
            };
            chartVoucherTop.Series.Add(series);

            var area = chartVoucherTop.ChartAreas[0];
            area.AxisX.Title = "Voucher Code";
            area.AxisY.Title = "Số lần áp dụng";
            area.AxisY.LabelStyle.Format = "#,##0";
            area.AxisX.Interval = 1;

            if (dt.Rows.Count == 0)
            {
                series.Points.AddXY("Không có dữ liệu", 0);
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                string code = row["VoucherCode"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuongApDung"]);
                series.Points.AddXY(code, soLuong);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvDangApDung.Rows.Count <= 1 && dgvHetHan.Rows.Count <= 1)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = $"VoucherCheckIn_{cbThang.Text}-{cbNam.Text}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var ws = workbook.Worksheets.Add("Voucher");

                            // Tiêu đề
                            ws.Cell(1, 1).Value = "BÁO CÁO VOUCHER CHECK-IN & ÁP DỤNG";
                            ws.Cell(1, 1).Style.Font.Bold = true;
                            ws.Cell(1, 1).Style.Font.FontSize = 18;
                            ws.Range("A1:E1").Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                            ws.Cell(3, 1).Value = $"Thời gian: Tháng {cbThang.Text} - Năm {cbNam.Text}";
                            ws.Cell(3, 1).Style.Font.Bold = true;

                            // Voucher đang áp dụng
                            ws.Cell(5, 1).Value = "VOUCHER ĐANG ÁP DỤNG";
                            ws.Cell(5, 1).Style.Font.Bold = true;
                            int row = 6;
                            for (int col = 0; col < dgvDangApDung.Columns.Count; col++)
                            {
                                ws.Cell(row, col + 1).Value = dgvDangApDung.Columns[col].HeaderText;
                                ws.Cell(row, col + 1).Style.Font.Bold = true;
                            }
                            row++;
                            for (int i = 0; i < dgvDangApDung.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvDangApDung.Columns.Count; j++)
                                {
                                    var value = dgvDangApDung.Rows[i].Cells[j].Value;
                                    ws.Cell(row + i, j + 1).Value = (XLCellValue)(value ?? string.Empty);
                                }
                            }

                            // Voucher hết hạn (bảng thứ 2)
                            row += dgvDangApDung.Rows.Count + 3;
                            ws.Cell(row, 1).Value = "VOUCHER ĐÃ HẾT HẠN";
                            ws.Cell(row, 1).Style.Font.Bold = true;
                            row++;
                            for (int col = 0; col < dgvHetHan.Columns.Count; col++)
                            {
                                ws.Cell(row, col + 1).Value = dgvHetHan.Columns[col].HeaderText;
                                ws.Cell(row, col + 1).Style.Font.Bold = true;
                            }
                            row++;
                            for (int i = 0; i < dgvHetHan.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvHetHan.Columns.Count; j++)
                                {
                                    var value = dgvHetHan.Rows[i].Cells[j].Value;
                                    ws.Cell(row + i, j + 1).Value = (XLCellValue)(value ?? string.Empty);
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