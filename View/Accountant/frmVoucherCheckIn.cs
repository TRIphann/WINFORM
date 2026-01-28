using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel;

namespace JumpArena
{
    public partial class frmVoucherCheckIn : Form
    {
        private readonly string connectionString =
            "Data Source=localhost\\SQL2022NEW;Initial Catalog=JumpArenaDB;User ID=sa;Password=123456;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";

        // Cột voucher thật sự trong Invoice (auto detect)
        private string _invoiceVoucherCol;

        public frmVoucherCheckIn()
        {
            InitializeComponent();
            this.Load += frmVoucherCheckIn_Load;
        }

        private void frmVoucherCheckIn_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    _invoiceVoucherCol = DetectInvoiceVoucherColumn(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không detect được cột voucher trong bảng Invoice.\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cbThang.Items.Clear();
            for (int i = 1; i <= 12; i++) cbThang.Items.Add(i.ToString("00"));

            cbNam.Items.Clear();
            for (int year = 2023; year <= DateTime.Now.Year + 2; year++) cbNam.Items.Add(year.ToString());

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
                var dtDangApDung = LayVoucherDangApDung(thang, nam);
                dgvDangApDung.DataSource = dtDangApDung;

                var dtHetHan = LayVoucherHetHan(thang, nam);
                dgvHetHan.DataSource = dtHetHan;

                var dtTop = LayTopVoucherApDung(thang, nam);
                VeBieuDo(dtTop);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu:\n{ex.Message}", "Lỗi");
            }
        }

        // ===== Detect cột voucher trong Invoice =====
        // Ưu tiên: AppliedVoucherId -> VoucherID -> AppliedVoucherID
        private string DetectInvoiceVoucherColumn(SqlConnection conn)
        {
            const string sql = @"
                SELECT c.name
                FROM sys.columns c
                INNER JOIN sys.tables t ON c.object_id = t.object_id
                WHERE t.name = 'Invoice'
                  AND c.name IN ('AppliedVoucherId', 'VoucherID', 'AppliedVoucherID');";

            var cols = new System.Collections.Generic.List<string>();
            using (var cmd = new SqlCommand(sql, conn))
            using (var r = cmd.ExecuteReader())
            {
                while (r.Read()) cols.Add(r.GetString(0));
            }

            if (cols.Contains("AppliedVoucherId")) return "AppliedVoucherId";
            if (cols.Contains("VoucherID")) return "VoucherID";
            if (cols.Contains("AppliedVoucherID")) return "AppliedVoucherID";

            throw new Exception("Invoice không có cột voucher (AppliedVoucherId/VoucherID/AppliedVoucherID).");
        }

        // ===== Voucher đang áp dụng (đếm số lần áp dụng trong tháng/năm đã chọn) =====
        private DataTable LayVoucherDangApDung(int thang, int nam)
        {
            var dt = new DataTable();

            // dùng cột voucher detect được
            string query = $@"
                SELECT 
                    v.VoucherCode,
                    v.Description,
                    v.DiscountType,
                    v.DiscountValue,
                    COUNT(i.InvoiceID) AS SoLuongApDung,
                    ISNULL(SUM(i.DiscountAmount),0) AS TongTienGiam
                FROM Invoice i
                INNER JOIN Voucher v ON v.VoucherID = i.[{_invoiceVoucherCol}]
                WHERE i.Status = 'Completed'
                  AND YEAR(i.CreatedDate) = @Nam
                  AND MONTH(i.CreatedDate) = @Thang
                GROUP BY v.VoucherCode, v.Description, v.DiscountType, v.DiscountValue
                ORDER BY SoLuongApDung DESC;";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam", nam);
                new SqlDataAdapter(cmd).Fill(dt);
            }

            return dt;
        }

        // ===== Voucher hết hạn =====
        private DataTable LayVoucherHetHan(int thang, int nam)
        {
            var dt = new DataTable();

            string query = @"
                SELECT 
                    v.VoucherCode,
                    v.Description,
                    v.DiscountType,
                    v.DiscountValue,
                    v.EndDate
                FROM Voucher v
                WHERE v.EndDate < DATEFROMPARTS(@Nam, @Thang, 1)
                ORDER BY v.EndDate DESC;";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam", nam);
                new SqlDataAdapter(cmd).Fill(dt);
            }

            return dt;
        }

        // ===== Top voucher áp dụng nhiều nhất =====
        private DataTable LayTopVoucherApDung(int thang, int nam)
        {
            var dt = new DataTable();

            // SỬA LỖI: bỏ "WHERE AND"
            // đồng thời dùng cột voucher detect được
            string query = $@"
                SELECT TOP 10
                    v.VoucherCode,
                    COUNT(i.InvoiceID) AS SoLuongApDung
                FROM Invoice i
                INNER JOIN Voucher v ON v.VoucherID = i.[{_invoiceVoucherCol}]
                WHERE i.Status = 'Completed'
                  AND YEAR(i.CreatedDate) = @Nam
                  AND MONTH(i.CreatedDate) = @Thang
                GROUP BY v.VoucherCode
                ORDER BY SoLuongApDung DESC;";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam", nam);
                new SqlDataAdapter(cmd).Fill(dt);
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
                string code = row["VoucherCode"]?.ToString() ?? "";
                int soLuong = row["SoLuongApDung"] == DBNull.Value ? 0 : Convert.ToInt32(row["SoLuongApDung"]);
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

                            ws.Cell(1, 1).Value = "BÁO CÁO VOUCHER CHECK-IN & ÁP DỤNG";
                            ws.Cell(1, 1).Style.Font.Bold = true;
                            ws.Cell(1, 1).Style.Font.FontSize = 18;
                            ws.Range("A1:E1").Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                            ws.Cell(3, 1).Value = $"Thời gian: Tháng {cbThang.Text} - Năm {cbNam.Text}";
                            ws.Cell(3, 1).Style.Font.Bold = true;

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
                                    ws.Cell(row + i, j + 1).Value = value?.ToString() ?? "";
                                }
                            }

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
                                    ws.Cell(row + i, j + 1).Value = value?.ToString() ?? "";
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
