using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace JumpArena.View
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        // ==============================
        // FORM LOAD (CHỈ XEM, KHÔNG IN)
        // ==============================
        private void frmInvoice_Load(object sender, EventArgs e)
        {
            // Form này chỉ để xem → không ép 80mm
            LoadDemoData();
        }

        // ==============================
        // DATA DEMO (BẠN THAY DB SAU)
        // ==============================
        private void LoadDemoData()
        {
            lblInvoiceID.Text = "Mã HĐ: HD00125";
            lblCreatedDate.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblStaff.Text = "Nhân viên: Nguyễn Văn A";
            lblCustomer.Text = "Khách hàng: Trần Văn B";
            lblPhone.Text = "SĐT: 0909 123 456";

            dgvInvoiceDetail.Rows.Clear();
            dgvInvoiceDetail.Rows.Add("Vé Jump Arena", 2, "150.000", "300.000");
            dgvInvoiceDetail.Rows.Add("Nước suối", 1, "15.000", "15.000");

            lblSubtotal.Text = "Tạm tính: 315.000 đ";
            lblDiscount.Text = "Giảm giá: 15.000 đ";
            lblFinalTotal.Text = "TỔNG TIỀN: 300.000 đ";
            lblPaymentMethod.Text = "Thanh toán: Tiền mặt";
        }

        // ==============================
        // BUTTON IN & ĐÓNG
        // ==============================
        private void btnPrintAndClose_Click(object sender, EventArgs e)
        {
            ExportBillPOSImage();
            this.Close();
        }

        // ==============================
        // XUẤT BILL POS THỰC TẾ (80MM)
        // ==============================
        private void ExportBillPOSImage()
        {
            int width = 302;          // 80mm
            int tempHeight = 1200;    // đủ lớn, sẽ crop

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

                // ===== HEADER =====
                DrawCenter(g, "JUMP ARENA", titleFont, y, width);
                y += lh + 5;

                DrawCenter(g, "HÓA ĐƠN THANH TOÁN", boldFont, y, width);
                y += lh;

                DrawLine(g, y); y += 8;

                // ===== INFO =====
                DrawLeft(g, "Mã HĐ: HD00125", normalFont, ref y);
                DrawLeft(g, "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), normalFont, ref y);
                DrawLeft(g, "NV: Nguyễn Văn A", normalFont, ref y);
                DrawLeft(g, "KH: Trần Văn B", normalFont, ref y);
                DrawLeft(g, "SĐT: 0909 123 456", normalFont, ref y);

                DrawLine(g, y); y += 8;

                // ===== ITEM HEADER =====
                DrawLeft(g, "SP        SL   GIÁ    TT", boldFont, ref y);
                DrawLine(g, y); y += 5;

                // ===== ITEMS =====
                DrawItem(g, "Vé Jump", 2, 150000, normalFont, ref y);
                DrawItem(g, "Nước suối", 1, 15000, normalFont, ref y);

                DrawLine(g, y); y += 8;

                // ===== TOTAL =====
                DrawRight(g, "Tạm tính: 315.000", normalFont, y, width); y += lh;
                DrawRight(g, "Giảm giá: 15.000", normalFont, y, width); y += lh;
                DrawRight(g, "TỔNG: 300.000", boldFont, y, width); y += lh;

                DrawLine(g, y); y += 10;

                DrawCenter(g, "Thanh toán: Tiền mặt", normalFont, y, width);
                y += lh;

                DrawCenter(g, "CẢM ƠN QUÝ KHÁCH!", boldFont, y, width);
                y += lh;

                // ===== CROP CHIỀU CAO THẬT =====
                bmp = bmp.Clone(new Rectangle(0, 0, width, y + 10), bmp.PixelFormat);
            }

            string folder = Path.Combine(Application.StartupPath, "Bills");
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, $"Bill_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            bmp.Save(path, ImageFormat.Png);
            bmp.Dispose();

            MessageBox.Show("Xuất bill POS thành công!\n\n" + path,
                "Hoàn tất",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==============================
        // HÀM VẼ HỖ TRỢ
        // ==============================
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
            string line =
                $"{name,-10}{qty,2} {price / 1000,4}k {(qty * price) / 1000,4}k";
            g.DrawString(line, font, Brushes.Black, 5, y);
            y += 18;
        }
    }
}
