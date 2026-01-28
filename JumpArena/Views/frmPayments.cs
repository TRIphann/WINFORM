using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace JumpArena
{
    public partial class frmPayments : Form
    {
        private readonly string _cs;
        private readonly int _invoiceId;
        private readonly decimal _total;

        private int? _selectedRowIndex = null;

        // PaymentMethodID theo DB
        private int _pmBankTransferId;
        private int _pmCashId;
        private int _pmCreditCardId;
        private int _pmEWalletId;

        public frmPayments(int invoiceId, string customerName, string phone, decimal total)
        {
            InitializeComponent();

            _cs = System.Configuration.ConfigurationManager
                .ConnectionStrings["JumpArenaContextDB"].ConnectionString;

            _invoiceId = invoiceId;
            _total = total;

            lblCustomer.Text = string.IsNullOrWhiteSpace(customerName) ? "DEFAULT CUSTOMER" : customerName.Trim();
            lblPhone.Text = string.IsNullOrWhiteSpace(phone) ? "" : phone.Trim();

            SetupGrid();
            LoadPaymentMethodIdsFromDb();
            SetupButtons();
            SetupKeypad();

            lblTotalValue.Text = _total.ToString("N0");
            RecalcSummary();
        }

        private void SetupGrid()
        {
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.MultiSelect = false;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var refCol = dgvPayments.Columns["Ref"] as DataGridViewComboBoxColumn;
            if (refCol != null)
            {
                refCol.Items.Clear();
                refCol.Items.Add("");
                refCol.Items.Add("MoMo");
                refCol.Items.Add("ZaloPay");
            }

            dgvPayments.CellClick += DgvPayments_CellClick;
            dgvPayments.CellBeginEdit += DgvPayments_CellBeginEdit;
            dgvPayments.CellEndEdit += DgvPayments_CellEndEdit;
            dgvPayments.EditingControlShowing += DgvPayments_EditingControlShowing;
            dgvPayments.CellContentClick += DgvPayments_CellContentClick;
        }

        private void LoadPaymentMethodIdsFromDb()
        {
            using (var conn = new SqlConnection(_cs))
            {
                conn.Open();

                _pmCashId = GetOrCreatePaymentMethod(conn, "Tiền mặt", 0);
                _pmBankTransferId = GetOrCreatePaymentMethod(conn, "Chuyển khoản ngân hàng", 1);
                _pmCreditCardId = GetOrCreatePaymentMethod(conn, "Thẻ tín dụng (Credit Card)", 1);
                _pmEWalletId = GetOrCreatePaymentMethod(conn, "Ví điện tử", 1);
            }
        }

        private int GetOrCreatePaymentMethod(SqlConnection conn, string name, int isDigital)
        {
            using (var cmd = new SqlCommand("SELECT TOP 1 PaymentMethodID FROM PaymentMethod WHERE MethodName = @n", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                var obj = cmd.ExecuteScalar();
                if (obj != null && obj != DBNull.Value) return Convert.ToInt32(obj);
            }

            using (var cmd = new SqlCommand(
                "INSERT INTO PaymentMethod(MethodName, IsDigital) VALUES(@n, @d); SELECT SCOPE_IDENTITY();", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@d", isDigital);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void SetupButtons()
        {
            btnBankTransfer.Text = "Chuyển khoản\nngân hàng";
            btnCashQ2.Text = "Tiền mặt";
            btnCreditCard_Q2.Text = "Thẻ tín dụng\n(Credit Card)";
            btnOther.Text = "Ví điện tử";

            btnBankTransfer.Click += (_, __) => AddPaymentLine(_pmBankTransferId, "Chuyển khoản ngân hàng");
            btnCashQ2.Click += (_, __) => AddPaymentLine(_pmCashId, "Tiền mặt");
            btnCreditCard_Q2.Click += (_, __) => AddPaymentLine(_pmCreditCardId, "Thẻ tín dụng (Credit Card)");
            btnOther.Click += (_, __) => AddPaymentLine(_pmEWalletId, "Ví điện tử");

            btnSubmit.Click += BtnSubmit_Click;
            btnClose.Click += btnClose_Click;
        }

        private void SetupKeypad()
        {
            numPadButtons1.Tag = "1";
            numPadButtons2.Tag = "2";
            numPadButtons3.Tag = "3";
            numPadButtons4.Tag = "4";
            numPadButtons5.Tag = "5";
            numPadButtons6.Tag = "6";
            numPadButtons7.Tag = "7";
            numPadButtons8.Tag = "8";
            numPadButtons9.Tag = "9";
            numPadButtons10.Tag = "0";
            numPadButtons11.Tag = "000";

            numPadButtons1.Click += Keypad_Click;
            numPadButtons2.Click += Keypad_Click;
            numPadButtons3.Click += Keypad_Click;
            numPadButtons4.Click += Keypad_Click;
            numPadButtons5.Click += Keypad_Click;
            numPadButtons6.Click += Keypad_Click;
            numPadButtons7.Click += Keypad_Click;
            numPadButtons8.Click += Keypad_Click;
            numPadButtons9.Click += Keypad_Click;
            numPadButtons10.Click += Keypad_Click;
            numPadButtons11.Click += Keypad_Click;

            numPadButtons12.Click -= Keypad_Click;
            numPadButtons12.Click += BtnArrowFillTotal_Click;
        }

        private void BtnArrowFillTotal_Click(object sender, EventArgs e)
        {
            if (dgvPayments.Rows.Count == 0)
            {
                dgvPayments.Rows.Add();
                dgvPayments.Rows[0].Cells["ColNo"].Value = "1";
                dgvPayments.Rows[0].Cells["PaymentMethod"].Value = "";
                dgvPayments.Rows[0].Cells["Amount"].Value = "0";
                dgvPayments.Rows[0].Cells["Remarks"].Value = "";
                dgvPayments.Rows[0].Cells["Ref"].Value = "";
                _selectedRowIndex = 0;
            }

            int rowIndex = dgvPayments.CurrentCell?.RowIndex ?? (_selectedRowIndex ?? 0);
            if (rowIndex < 0) rowIndex = 0;

            dgvPayments.Rows[rowIndex].Cells["Amount"].Value = _total.ToString("N0");

            dgvPayments.ClearSelection();
            dgvPayments.Rows[rowIndex].Selected = true;
            dgvPayments.CurrentCell = dgvPayments.Rows[rowIndex].Cells["Amount"];
            _selectedRowIndex = rowIndex;

            RecalcSummary();
        }

        private void AddPaymentLine(int paymentMethodId, string methodName)
        {
            int nextNo = dgvPayments.Rows.Count + 1;

            int rowIndex = dgvPayments.Rows.Add();
            var row = dgvPayments.Rows[rowIndex];

            row.Cells["ColNo"].Value = nextNo;
            row.Cells["PaymentMethod"].Value = methodName;
            row.Cells["PaymentMethod"].Tag = paymentMethodId;

            row.Cells["Amount"].Value = "0";
            row.Cells["Remarks"].Value = "";
            row.Cells["Ref"].Value = "";

            dgvPayments.ClearSelection();
            dgvPayments.Rows[rowIndex].Selected = true;
            _selectedRowIndex = rowIndex;

            dgvPayments.CurrentCell = dgvPayments.Rows[rowIndex].Cells["Amount"];
            dgvPayments.BeginEdit(true);

            RecalcSummary();
        }

        private void Keypad_Click(object sender, EventArgs e)
        {
            if (_selectedRowIndex == null || _selectedRowIndex < 0 || _selectedRowIndex >= dgvPayments.Rows.Count)
                return;

            var tag = (sender as Button)?.Tag?.ToString();
            if (string.IsNullOrEmpty(tag)) return;

            var cell = dgvPayments.Rows[_selectedRowIndex.Value].Cells["Amount"];
            string current = (cell.Value?.ToString() ?? "0").Replace(".", "").Replace(",", "").Trim();

            if (current == "0") current = "";
            current += tag;
            if (string.IsNullOrEmpty(current)) current = "0";

            if (!decimal.TryParse(current, out decimal amount))
                amount = 0;

            cell.Value = amount.ToString("N0");
            RecalcSummary();
        }

        private void DgvPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) _selectedRowIndex = e.RowIndex;
        }

        private void DgvPayments_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _selectedRowIndex = e.RowIndex;
        }

        private void DgvPayments_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPayments.Columns[e.ColumnIndex].Name == "Amount")
            {
                var cell = dgvPayments.Rows[e.RowIndex].Cells["Amount"];
                string raw = (cell.Value?.ToString() ?? "0").Replace(".", "").Replace(",", "").Trim();
                if (!decimal.TryParse(raw, out decimal amount)) amount = 0;
                cell.Value = amount.ToString("N0");
            }

            RecalcSummary();
        }

        private void DgvPayments_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvPayments.CurrentCell == null) return;

            if (dgvPayments.CurrentCell.OwningColumn.Name == "Amount")
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress -= Amount_KeyPress;
                    tb.KeyPress += Amount_KeyPress;
                }
            }
            else if (e.Control is TextBox tb2)
            {
                tb2.KeyPress -= Amount_KeyPress;
            }
        }

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void DgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPayments.Columns[e.ColumnIndex].Name == "ColX")
            {
                dgvPayments.Rows.RemoveAt(e.RowIndex);

                for (int i = 0; i < dgvPayments.Rows.Count; i++)
                    dgvPayments.Rows[i].Cells["ColNo"].Value = (i + 1);

                _selectedRowIndex = dgvPayments.Rows.Count > 0 ? 0 : (int?)null;
                RecalcSummary();
            }
        }

        private decimal SumCollected()
        {
            decimal sum = 0;
            foreach (DataGridViewRow r in dgvPayments.Rows)
            {
                if (r.IsNewRow) continue;
                string raw = (r.Cells["Amount"].Value?.ToString() ?? "0").Replace(".", "").Replace(",", "").Trim();
                if (decimal.TryParse(raw, out decimal a)) sum += a;
            }
            return sum;
        }

        private void RecalcSummary()
        {
            decimal collected = SumCollected();
            decimal due = collected < _total ? _total - collected : 0;
            decimal change = collected > _total ? collected - _total : 0;

            lblTotalValue.Text = _total.ToString("N0");
            lblCollectedValue.Text = collected.ToString("N0");
            lblDueValue.Text = due.ToString("N0");
            lblChangeValue.Text = change.ToString("N0");
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (_invoiceId <= 0)
            {
                MessageBox.Show("InvoiceID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvPayments.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phương thức thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ CHẶN nếu còn thiếu tiền
            decimal dueNow = ParseMoney(lblDueValue.Text);
            if (dueNow > 0)
            {
                MessageBox.Show(
                    $"Khách hàng còn thiếu {dueNow:N0} đ.\nVui lòng thanh toán đủ trước khi hoàn tất.",
                    "Chưa đủ tiền",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate từng dòng
            foreach (DataGridViewRow r in dgvPayments.Rows)
            {
                if (r.IsNewRow) continue;

                int pmId = r.Cells["PaymentMethod"].Tag == null ? 0 : Convert.ToInt32(r.Cells["PaymentMethod"].Tag);

                string rawAmount = (r.Cells["Amount"].Value?.ToString() ?? "0").Replace(".", "").Replace(",", "").Trim();
                if (!decimal.TryParse(rawAmount, out decimal amount)) amount = 0;

                if (amount <= 0)
                {
                    MessageBox.Show("Có dòng thanh toán Amount = 0. Nhập số tiền trước.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string remark = (r.Cells["Remarks"].Value?.ToString() ?? "").Trim();
                string refVal = (r.Cells["Ref"].Value?.ToString() ?? "").Trim();

                if (pmId == _pmBankTransferId || pmId == _pmCreditCardId)
                {
                    if (remark.Length != 4 || !remark.All(char.IsDigit))
                    {
                        MessageBox.Show("Remark bắt buộc 4 số đuôi cho Chuyển khoản / Thẻ tín dụng.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (pmId == _pmEWalletId)
                {
                    if (refVal != "MoMo" && refVal != "ZaloPay")
                    {
                        MessageBox.Show("Ví điện tử bắt buộc chọn Ref = MoMo hoặc ZaloPay.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Save PaymentTransaction
            try
            {
                using (var conn = new SqlConnection(_cs))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            using (var del = new SqlCommand("DELETE FROM PaymentTransaction WHERE InvoiceID = @id", conn, tran))
                            {
                                del.Parameters.AddWithValue("@id", _invoiceId);
                                del.ExecuteNonQuery();
                            }

                            foreach (DataGridViewRow r in dgvPayments.Rows)
                            {
                                if (r.IsNewRow) continue;

                                int pmId = Convert.ToInt32(r.Cells["PaymentMethod"].Tag);
                                string rawAmount = (r.Cells["Amount"].Value?.ToString() ?? "0").Replace(".", "").Replace(",", "").Trim();
                                decimal amount = decimal.TryParse(rawAmount, out var a) ? a : 0;

                                string remark = (r.Cells["Remarks"].Value?.ToString() ?? "").Trim();
                                string refVal = (r.Cells["Ref"].Value?.ToString() ?? "").Trim();

                                string transactionCode = "";
                                if (pmId == _pmEWalletId) transactionCode = refVal;
                                else if (pmId == _pmBankTransferId || pmId == _pmCreditCardId) transactionCode = remark;

                                using (var ins = new SqlCommand(@"
INSERT INTO PaymentTransaction(Amount, PaymentDate, TransactionCode, Note, InvoiceID, PaymentMethodID)
VALUES (@Amount, GETDATE(), @Code, @Note, @InvoiceID, @PMID);", conn, tran))
                                {
                                    ins.Parameters.AddWithValue("@Amount", amount);
                                    ins.Parameters.AddWithValue("@Code", (object)transactionCode ?? DBNull.Value);
                                    ins.Parameters.AddWithValue("@Note", (object)remark ?? DBNull.Value);
                                    ins.Parameters.AddWithValue("@InvoiceID", _invoiceId);
                                    ins.Parameters.AddWithValue("@PMID", pmId);
                                    ins.ExecuteNonQuery();
                                }
                            }

                            using (var upd = new SqlCommand(@"
UPDATE Invoice
SET PaymentStatus = 'Paid',
    Status = 'Completed'
WHERE InvoiceID = @id;", conn, tran))
                            {
                                upd.Parameters.AddWithValue("@id", _invoiceId);
                                upd.ExecuteNonQuery();
                            }

                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }

                // Thông báo thành công + excess cash nếu có
                decimal change = ParseMoney(lblChangeValue.Text);
                if (change > 0)
                {
                    MessageBox.Show($"Thanh toán thành công.\nExcess cash: {change:N0} đ", "Hoàn tất",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thanh toán thành công.", "Hoàn tất",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi Submit thanh toán: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ParseMoney(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;
            var cleaned = new string(s.Where(ch => char.IsDigit(ch) || ch == '-').ToArray());
            if (decimal.TryParse(cleaned, out var v)) return v;
            return 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            // để trống cũng được
        }
    }
}
