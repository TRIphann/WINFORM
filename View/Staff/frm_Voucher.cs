using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
namespace JumpArena
{
    public partial class frm_Voucher : Form
    {
        // ===== UI controls của bạn =====
        private Panel pnlDialog, pnlLeft, pnlRight, pnlLeftFrame, pnlRightFrame, pnlLeftSummary;
        private Label lblTitle;
        private Button btnClose, btnApplyVoucher, btnReset, btnOk;
        private DataGridView dgvItems;
        private TabControl tabRight;
        private TabPage tabVoucher, tabSchema;
        private TextBox txtVoucherCode;
        private ListBox lstVoucherResult;

        // ===== DATA =====
        private readonly string _connectionString;
        private readonly List<OrderItem> _cart;   // giỏ hàng từ HomePage
        private decimal _total;                  // tổng tiền giỏ hàng

        // trạng thái voucher đang áp
        private VoucherInfo _appliedVoucher = null;
        private decimal _discountAmount = 0m;

        // ===== OUTPUT: HomePage sẽ đọc các property này sau khi OK =====
        public decimal AppliedDiscountAmount => _discountAmount;
        public string AppliedVoucherCode => _appliedVoucher?.VoucherCode ?? "";
        public int? AppliedVoucherId => _appliedVoucher?.VoucherID;

        // ===== Constructor: bắt buộc truyền vào ConnectionString + cart =====
        public frm_Voucher(string connectionString, List<OrderItem> cart)
        {
            InitializeComponent();

            _connectionString = connectionString;
            _cart = cart ?? new List<OrderItem>();
            _total = _cart.Sum(x => x.Total);

            BuildUI();
            BuildLeftGrid();
            SetVietnameseText();     // đổi text sang tiếng Việt
            BindCartToGridInitial(); // đổ cart vào grid
            UpdateSummaryUI();       // tổng tiền ban đầu
            WireEvents();
        }

        private void SetVietnameseText()
        {
            lblTitle.Text = "Áp dụng khuyến mãi thủ công";

            tabVoucher.Text = "Voucher / Khuyến mãi";
            tabSchema.Text = "Chương trình";

            btnApplyVoucher.Text = "Áp dụng";
            btnReset.Text = "Làm lại";
            btnOk.Text = "OK";

            // textbox placeholder giả
            txtVoucherCode.ForeColor = Color.Gray;
            txtVoucherCode.Text = "Nhập mã voucher";
        }

        private void BuildUI()
        {
            // Popup overlay
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(45, 45, 45);
            this.ClientSize = new Size(1200, 650);

            // Dialog trắng
            pnlDialog = new Panel
            {
                BackColor = Color.White,
                Size = new Size(1100, 560),
                Location = new Point((this.ClientSize.Width - 1100) / 2, (this.ClientSize.Height - 560) / 2),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pnlDialog);

            // Title
            lblTitle = new Label
            {
                Text = "Áp dụng khuyến mãi thủ công",
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(18, 14)
            };
            pnlDialog.Controls.Add(lblTitle);

            // Close
            btnClose = new Button
            {
                Text = "X",
                BackColor = Color.FromArgb(160, 40, 40),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(42, 32),
                Location = new Point(pnlDialog.Width - 55, 10)
            };
            btnClose.FlatAppearance.BorderSize = 0;
            pnlDialog.Controls.Add(btnClose);

            // Left
            pnlLeft = new Panel
            {
                Size = new Size(700, 490),
                Location = new Point(18, 55),
                BackColor = Color.White
            };
            pnlDialog.Controls.Add(pnlLeft);

            // Right
            pnlRight = new Panel
            {
                Size = new Size(360, 490),
                Location = new Point(735, 55),
                BackColor = Color.White
            };
            pnlDialog.Controls.Add(pnlRight);

            // Left frame
            pnlLeftFrame = new Panel
            {
                BackColor = Color.FromArgb(234, 240, 255),
                Location = new Point(0, 0),
                Size = new Size(pnlLeft.Width, 400),
                Padding = new Padding(12)
            };
            pnlLeft.Controls.Add(pnlLeftFrame);

            // Grid
            dgvItems = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                ReadOnly = true
            };
            pnlLeftFrame.Controls.Add(dgvItems);

            // Summary bottom left
            pnlLeftSummary = new Panel
            {
                BackColor = Color.White,
                Location = new Point(0, 405),
                Size = new Size(pnlLeft.Width, 85)
            };
            pnlLeft.Controls.Add(pnlLeftSummary);

            // Right frame
            pnlRightFrame = new Panel
            {
                BackColor = Color.FromArgb(234, 240, 255),
                Location = new Point(0, 0),
                Size = new Size(pnlRight.Width, 290),
                Padding = new Padding(12)
            };
            pnlRight.Controls.Add(pnlRightFrame);

            // Tabs
            tabRight = new TabControl
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9)
            };
            tabVoucher = new TabPage("Voucher / Khuyến mãi");
            tabSchema = new TabPage("Chương trình");
            tabRight.TabPages.Add(tabVoucher);
            tabRight.TabPages.Add(tabSchema);
            pnlRightFrame.Controls.Add(tabRight);

            lstVoucherResult = new ListBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10)
            };
            tabVoucher.Controls.Add(lstVoucherResult);

            txtVoucherCode = new TextBox
            {
                Location = new Point(0, 305),
                Size = new Size(250, 35),
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.Gray,
                Text = "Nhập mã voucher"
            };
            pnlRight.Controls.Add(txtVoucherCode);

            btnApplyVoucher = new Button
            {
                Text = "Áp dụng",
                Location = new Point(260, 305),
                Size = new Size(95, 35),
                BackColor = Color.FromArgb(160, 40, 40),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnApplyVoucher.FlatAppearance.BorderSize = 0;
            pnlRight.Controls.Add(btnApplyVoucher);

            btnReset = new Button
            {
                Text = "Làm lại",
                Location = new Point(0, 360),
                Size = new Size(170, 52),
                BackColor = Color.FromArgb(160, 40, 40),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            };
            btnReset.FlatAppearance.BorderSize = 0;
            pnlRight.Controls.Add(btnReset);

            btnOk = new Button
            {
                Text = "OK",
                Location = new Point(185, 360),
                Size = new Size(170, 52),
                BackColor = Color.FromArgb(30, 140, 140),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            };
            btnOk.FlatAppearance.BorderSize = 0;
            pnlRight.Controls.Add(btnOk);
        }

        private void BuildLeftGrid()
        {
            dgvItems.Columns.Clear();

            dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mô tả", DataPropertyName = "Description" });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giá", DataPropertyName = "Price" });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lượng", DataPropertyName = "Quantity" });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Loại giảm", DataPropertyName = "DiscountType" });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giảm", DataPropertyName = "Discount" });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thành tiền", DataPropertyName = "SubTotal" });

            dgvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(120, 40, 40);
            dgvItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvItems.EnableHeadersVisualStyles = false;
        }

        private void BindCartToGridInitial()
        {
            var dt = new DataTable();
            dt.Columns.Add("Description");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("DiscountType");
            dt.Columns.Add("Discount");
            dt.Columns.Add("SubTotal");

            foreach (var item in _cart)
            {
                dt.Rows.Add(
                    item.Description,
                    item.Price.ToString("N0"),
                    item.Quantity.ToString(),
                    "",
                    "0",
                    item.Total.ToString("N0")
                );
            }

            dgvItems.DataSource = dt;

            lstVoucherResult.Items.Clear();
            if (_appliedVoucher != null)
                lstVoucherResult.Items.Add(_appliedVoucher.VoucherCode);
        }

        private void UpdateSummaryUI()
        {
            pnlLeftSummary.Controls.Clear();
            AddSummary(pnlLeftSummary, "Tổng tiền", _total.ToString("N0"), 10);
            AddSummary(pnlLeftSummary, "Tổng giảm", _discountAmount.ToString("N0"), 190);
            AddSummary(pnlLeftSummary, "Làm tròn", "0", 370);

            decimal payable = _total - _discountAmount;
            if (payable < 0) payable = 0;

            AddSummary(pnlLeftSummary, "Cần thanh toán", payable.ToString("N0"), 530);
        }

        private void AddSummary(Panel pnl, string title, string value, int x)
        {
            var lblT = new Label
            {
                Text = title,
                Location = new Point(x, 10),
                AutoSize = true,
                Font = new Font("Segoe UI", 9)
            };
            var lblV = new Label
            {
                Text = value,
                Location = new Point(x, 35),
                AutoSize = true,
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            };
            pnl.Controls.Add(lblT);
            pnl.Controls.Add(lblV);
        }

        private void WireEvents()
        {
            btnClose.Click += (s, e) => this.Close();

            // Placeholder giả
            txtVoucherCode.Enter += (s, e) =>
            {
                if (txtVoucherCode.ForeColor == Color.Gray)
                {
                    txtVoucherCode.Text = "";
                    txtVoucherCode.ForeColor = Color.Black;
                }
            };
            txtVoucherCode.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtVoucherCode.Text))
                {
                    txtVoucherCode.Text = "Nhập mã voucher";
                    txtVoucherCode.ForeColor = Color.Gray;
                }
            };

            // ENTER = áp dụng
            txtVoucherCode.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    ApplyVoucher();
                }
            };

            btnApplyVoucher.Click += (s, e) => ApplyVoucher();
            btnReset.Click += (s, e) => ResetVoucher();
            btnOk.Click += (s, e) =>
            {
                if (_appliedVoucher == null)
                {
                    MessageBox.Show("Bạn chưa áp dụng voucher. Hãy nhập mã và bấm 'Áp dụng' trước.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            };
        }

        private void ResetVoucher()
        {
            _appliedVoucher = null;
            _discountAmount = 0m;

            txtVoucherCode.Text = "Nhập mã voucher";
            txtVoucherCode.ForeColor = Color.Gray;

            lstVoucherResult.Items.Clear();

            // reset grid về không giảm
            BindCartToGridInitial();
            UpdateSummaryUI();
        }

        private void ApplyVoucher()
        {
            string code = (txtVoucherCode.ForeColor == Color.Gray) ? "" : (txtVoucherCode.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Vui lòng nhập mã voucher.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var v = GetVoucherByCode(code);
            if (v == null)
            {
                MessageBox.Show("Mã voucher không tồn tại / hết hạn / chưa tới ngày.", "Không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check đơn tối thiểu
            if (_total < v.MinimumOrderValue)
            {
                MessageBox.Show(
                    "Đơn hàng chưa đạt giá trị tối thiểu để áp dụng voucher.\n" +
                    $"Tối thiểu: {v.MinimumOrderValue:N0} đ\n" +
                    $"Đơn hiện tại: {_total:N0} đ",
                    "Không đủ điều kiện",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal discount = CalcDiscount(_total, v);
            if (discount < 0) discount = 0;
            if (discount > _total) discount = _total;

            if (discount == 0)
            {
                MessageBox.Show(
                    $"Voucher {v.VoucherCode} có DiscountType='{v.DiscountType}' nhưng hệ thống tính ra giảm = 0.\n" +
                    "Kiểm tra lại DiscountType/DiscountValue trong DB.",
                    "Không áp được",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _appliedVoucher = v;
            _discountAmount = discount;

            lstVoucherResult.Items.Clear();
            lstVoucherResult.Items.Add(v.VoucherCode);

            ApplyDiscountToGrid(v, discount);
            UpdateSummaryUI();

            MessageBox.Show(
                $"Áp dụng {v.VoucherCode} thành công.\nGiảm: {discount:N0} đ\n{v.Description}",
                "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private VoucherInfo GetVoucherByCode(string code)
        {
            string clean = (code ?? "").Trim().ToUpper();

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(@"
SELECT TOP 1
    VoucherID, VoucherCode, Description, DiscountType, DiscountValue, MinimumOrderValue, StartDate, EndDate
FROM Voucher
WHERE UPPER(LTRIM(RTRIM(VoucherCode))) = @code
  AND (StartDate IS NULL OR GETDATE() >= StartDate)
  AND (EndDate   IS NULL OR GETDATE() <= EndDate)
", conn))
            {
                cmd.Parameters.Add("@code", SqlDbType.NVarChar, 50).Value = clean;

                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;

                    return new VoucherInfo
                    {
                        VoucherID = Convert.ToInt32(r["VoucherID"]),
                        VoucherCode = Convert.ToString(r["VoucherCode"] ?? ""),
                        Description = Convert.ToString(r["Description"] ?? ""),
                        DiscountType = Convert.ToString(r["DiscountType"] ?? ""),
                        DiscountValue = Convert.ToDecimal(r["DiscountValue"] ?? 0m),
                        MinimumOrderValue = Convert.ToDecimal(r["MinimumOrderValue"] ?? 0m),
                        StartDate = r["StartDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["StartDate"]),
                        EndDate = r["EndDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["EndDate"])
                    };
                }
            }
        }


        private decimal CalcDiscount(decimal total, VoucherInfo v)
        {
            string t = (v.DiscountType ?? "").Trim().ToLower();

            // DB của bạn đang dùng "Percent"
            if (t == "percent" || t == "percentage")
            {
                if (v.DiscountValue <= 0) return 0m;
                if (v.DiscountValue > 100) return Math.Round(total, 0);
                return Math.Round(total * (v.DiscountValue / 100m), 0);
            }

            if (t == "fixed")
            {
                if (v.DiscountValue <= 0) return 0m;
                return v.DiscountValue;
            }

            return 0m;
        }


        private string MapDiscountTypeVN(VoucherInfo v)
        {
            string t = (v.DiscountType ?? "").Trim().ToLower();
            if (t == "percent" || t == "percentage") return "Giảm theo %";
            if (t == "fixed") return "Giảm tiền";
            return "Khác";
        }

        private void ApplyDiscountToGrid(VoucherInfo v, decimal totalDiscount)
        {
            // Chia discount theo tỉ lệ từng dòng để nhìn giống form mẫu
            decimal cartTotal = _cart.Sum(x => x.Total);
            if (cartTotal <= 0) cartTotal = 1;

            var dt = new DataTable();
            dt.Columns.Add("Description");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("DiscountType");
            dt.Columns.Add("Discount");
            dt.Columns.Add("SubTotal");

            decimal sumLineDiscount = 0m;

            for (int i = 0; i < _cart.Count; i++)
            {
                var item = _cart[i];
                decimal ratio = item.Total / cartTotal;
                decimal lineDiscount = Math.Round(totalDiscount * ratio, 0);
                sumLineDiscount += lineDiscount;

                decimal sub = item.Total - lineDiscount;

                dt.Rows.Add(
                    item.Description,
                    item.Price.ToString("N0"),
                    item.Quantity.ToString(),
                    MapDiscountTypeVN(v),
                    lineDiscount.ToString("N0"),
                    sub.ToString("N0")
                );
            }

            // bù sai số do làm tròn
            decimal diff = totalDiscount - sumLineDiscount;
            if (_cart.Count > 0 && diff != 0)
            {
                // sửa dòng cuối
                int lastRow = dt.Rows.Count - 1;
                decimal lastDiscount = decimal.Parse(dt.Rows[lastRow]["Discount"].ToString(), NumberStyles.Any, CultureInfo.CurrentCulture);
                decimal lastSub = decimal.Parse(dt.Rows[lastRow]["SubTotal"].ToString(), NumberStyles.Any, CultureInfo.CurrentCulture);


                lastDiscount += diff;
                lastSub -= diff;

                dt.Rows[lastRow]["Discount"] = lastDiscount.ToString("N0");
                dt.Rows[lastRow]["SubTotal"] = lastSub.ToString("N0");
            }

            dgvItems.DataSource = dt;
        }

        private class VoucherInfo
        {
            public int VoucherID { get; set; }
            public string VoucherCode { get; set; }
            public string Description { get; set; }
            public string DiscountType { get; set; }   // "Percent" hoặc "Fixed"
            public decimal DiscountValue { get; set; }
            public decimal MinimumOrderValue { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
        }
    }


}
