using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JumpArena.View
{
    public partial class frmInvoice : Form
    {
        private readonly string _cs;
        private readonly int _invoiceId;
        private readonly string _customerName;
        private readonly string _phone;

        private decimal _subtotal = 0m;
        private decimal _discount = 0m;
        private decimal _finalTotal = 0m;
        private string _paymentSummary = "";

        public frmInvoice(string connectionString, int invoiceId, string customerName, string phone)
        {
            InitializeComponent();
            _cs = connectionString;
            _invoiceId = invoiceId;
            _customerName = customerName ?? "";
            _phone = phone ?? "";
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            LoadFromDb();
        }

        private void LoadFromDb()
        {
            // cố định nhân viên
            lblStaff.Text = "Nhân viên: cashier Jump Arena";

            // khách hàng + sđt
            lblCustomer.Text = "Khách hàng: " + _customerName.Trim();
            lblPhone.Text = "SĐT: " + _phone.Trim();

            // mã hoá đơn
            lblInvoiceID.Text = "Mã HĐ: " + _invoiceId.ToString("D4");

            // ngày có phút + giây (HH:mm:ss)
            DateTime created = DateTime.Now;

            dgvInvoiceDetail.Rows.Clear();

            using (var conn = new SqlConnection(_cs))
            {
                conn.Open();

                // 1) lấy CreatedDate, TotalOriginalAmount, DiscountAmount từ Invoice
                using (var cmd = new SqlCommand(@"
SELECT CreatedDate, TotalOriginalAmount, DiscountAmount
FROM Invoice
WHERE InvoiceID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", _invoiceId);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            created = Convert.ToDateTime(r["CreatedDate"]);
                            _subtotal = Convert.ToDecimal(r["TotalOriginalAmount"]);
                            _discount = Convert.ToDecimal(r["DiscountAmount"]);
                        }
                    }
                }

                // 2) chi tiết sản phẩm
                using (var cmd = new SqlCommand(@"
SELECT p.ProductName, d.Quantity, d.PriceAtPurchase
FROM InvoiceDetail d
JOIN Product p ON p.ProductID = d.ProductID
WHERE d.InvoiceID = @id
ORDER BY d.InvoiceDetailID;", conn))
                {
                    cmd.Parameters.AddWithValue("@id", _invoiceId);
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            string name = r["ProductName"].ToString();
                            int qty = Convert.ToInt32(r["Quantity"]);
                            decimal price = Convert.ToDecimal(r["PriceAtPurchase"]);
                            decimal lineTotal = qty * price;

                            dgvInvoiceDetail.Rows.Add(
                                name,
                                qty,
                                price.ToString("N0"),
                                lineTotal.ToString("N0"));
                        }
                    }
                }

                // 3) phương thức thanh toán (tổng hợp các dòng)
                using (var cmd = new SqlCommand(@"
SELECT pm.MethodName, SUM(t.Amount) AS TotalAmount
FROM PaymentTransaction t
JOIN PaymentMethod pm ON pm.PaymentMethodID = t.PaymentMethodID
WHERE t.InvoiceID = @id
GROUP BY pm.MethodName;", conn))
                {
                    cmd.Parameters.AddWithValue("@id", _invoiceId);
                    using (var r = cmd.ExecuteReader())
                    {
                        var parts = new System.Collections.Generic.List<string>();
                        while (r.Read())
                        {
                            string method = r["MethodName"].ToString();
                            decimal amt = Convert.ToDecimal(r["TotalAmount"]);
                            parts.Add(method);
                        }
                        _paymentSummary = parts.Count == 0 ? "N/A" : string.Join(" | ", parts);
                    }
                }
            }

            lblCreatedDate.Text = "Ngày: " + created.ToString("dd/MM/yyyy HH:mm:ss");

            _finalTotal = _subtotal - _discount;
            if (_finalTotal < 0) _finalTotal = 0;

            lblSubtotal.Text = "Tạm tính: " + _subtotal.ToString("N0") + " đ";
            lblDiscount.Text = "Giảm giá: " + _discount.ToString("N0") + " đ";
            lblFinalTotal.Text = "TỔNG TIỀN: " + _finalTotal.ToString("N0") + " đ";
            lblPaymentMethod.Text = "Thanh toán: " + _paymentSummary;
        }

        private void btnPrintAndClose_Click(object sender, EventArgs e)
        {
            ExportBillPOSImage(); // dùng dữ liệu thật đã load
            this.Close();
        }

        // ====== POS image: thay phần hardcode bằng dữ liệu thật ======
        private void ExportBillPOSImage()
        {
            int width = 302;
            int tempHeight = 2000;

            Bitmap bmp = new Bitmap(width, tempHeight);
            bmp.SetResolution(96, 96);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                Font titleFont = new Font("Consolas", 11, FontStyle.Bold);
                Font normalFont = new Font("Consolas", 8);
                Font boldFont = new Font("Consolas", 8, FontStyle.Bold);

                int y = 10;
                int lh = 18;

                DrawCenter(g, "JUMP ARENA", titleFont, y, width); y += lh + 5;
                DrawCenter(g, "HÓA ĐƠN THANH TOÁN", boldFont, y, width); y += lh;

                DrawLine(g, y); y += 8;

                DrawLeft(g, "Mã HĐ: " + _invoiceId.ToString("D4"), normalFont, ref y);
                DrawLeft(g, lblCreatedDate.Text, normalFont, ref y);

                DrawLeft(g, "NV: cashier Jump Arena", normalFont, ref y);
                DrawLeft(g, "KH: " + _customerName, normalFont, ref y);
                DrawLeft(g, "SĐT: " + _phone, normalFont, ref y);

                DrawLine(g, y); y += 8;

                DrawLeft(g, "SP        SL   GIÁ    TT", boldFont, ref y);
                DrawLine(g, y); y += 5;

                // items từ dgvInvoiceDetail
                foreach (DataGridViewRow row in dgvInvoiceDetail.Rows)
                {
                    if (row.IsNewRow) continue;
                    string name = (row.Cells[0].Value ?? "").ToString();
                    int qty = Convert.ToInt32(row.Cells[1].Value ?? 0);
                    decimal price = ParseMoney(row.Cells[2].Value?.ToString());
                    DrawItem(g, name, qty, (int)price, normalFont, ref y);
                }

                DrawLine(g, y); y += 8;

                DrawRight(g, "Tạm tính: " + _subtotal.ToString("N0"), normalFont, y, width); y += lh;
                DrawRight(g, "Giảm giá: " + _discount.ToString("N0"), normalFont, y, width); y += lh;
                DrawRight(g, "TỔNG: " + _finalTotal.ToString("N0"), boldFont, y, width); y += lh;

                DrawLine(g, y); y += 10;

                DrawCenter(g, "Thanh toán:", normalFont, y, width); y += lh;
                DrawCenter(g, _paymentSummary, normalFont, y, width); y += lh;

                DrawCenter(g, "CẢM ƠN QUÝ KHÁCH!", boldFont, y, width); y += lh;

                bmp = bmp.Clone(new Rectangle(0, 0, width, y + 10), bmp.PixelFormat);
            }

            string folder = Path.Combine(Application.StartupPath, "Bills");
            if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, $"Bill_{_invoiceId}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            bmp.Save(path, ImageFormat.Png);
            bmp.Dispose();

            MessageBox.Show("Xuất bill POS thành công!\n\n" + path, "Hoàn tất",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private decimal ParseMoney(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;
            var cleaned = new string(s.Where(ch => char.IsDigit(ch) || ch == '-').ToArray());
            return decimal.TryParse(cleaned, out var v) ? v : 0;
        }

        private void DrawLeft(Graphics g, string text, Font font, ref int y)
        {
            g.DrawString(text, font, Brushes.Black, 5, y);
            y += 18;
        }
        private void DrawCenter(Graphics g, string text, Font font, int y, int width)
        {
            SizeF size = g.MeasureString(text, font);
            g.DrawString(text, font, Brushes.Black, (width - size.Width) / 2, y);
        }
        private void DrawRight(Graphics g, string text, Font font, int y, int width)
        {
            SizeF size = g.MeasureString(text, font);
            g.DrawString(text, font, Brushes.Black, width - size.Width - 5, y);
        }
        private void DrawLine(Graphics g, int y)
        {
            g.DrawLine(Pens.Black, 5, y, 297, y);
        }
        private void DrawItem(Graphics g, string name, int qty, int price, Font font, ref int y)
        {
            // 80mm hẹp: tên tối đa 10 ký tự cho gọn
            string shortName = (name ?? "").Trim();
            if (shortName.Length > 10) shortName = shortName.Substring(0, 10);

            int lineTotal = qty * price;

            // Format kiểu VN: 315.000
            string sPrice = price.ToString("N0").Replace(",", ".");
            string sTotal = lineTotal.ToString("N0").Replace(",", ".");

            // Canh cột: SP(10) SL(2) GIÁ(9) TT(9)
            // Ví dụ: "Vé Jump     2  150.000  300.000"
            string line = $"{shortName,-10}{qty,2} {sPrice,9} {sTotal,9}";

            g.DrawString(line, font, Brushes.Black, 5, y);
            y += 18;
        }

    }
}
