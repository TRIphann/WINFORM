using JumpArena.View.Staff;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace JumpArena
{
    public partial class frmCheck_in : Form
    {
        private readonly string _cs;

        private int? _currentStaffId = null;
        private int? _selectedTicketProductId = null;
        private string _selectedTicketName = null;
        private decimal _selectedTicketPrice = 0;
        private List<JumpArena.View.Staff.TicketItem> _selectedTickets = new List<JumpArena.View.Staff.TicketItem>();

        public frmCheck_in()
        {
            InitializeComponent();

            _cs = System.Configuration.ConfigurationManager
                .ConnectionStrings["JumpArenaContextDB"].ConnectionString;

            SetupGrid();
            LoadRolesToCombo();

            btnSearchCustomer.Click += btnSearchCustomer_Click;
            btnCheckDiscount.Click += btnCheckDiscount_Click;
            buttonCheckIn.Click += buttonCheckIn_Click;

            ResetStaffUI();
            ResetTicketUI();
        }

        // ===================== GRID =====================
        private void SetupGrid()
        {
            dgvOrderItems.AutoGenerateColumns = false;
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.RowHeadersVisible = false;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.MultiSelect = false;
            dgvOrderItems.CellContentClick += dgvOrderItems_CellContentClick;

            dgvOrderItems.Columns.Clear();

            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                HeaderText = "Mô tả",
                DataPropertyName = "Description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });

            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Unit",
                HeaderText = "Đơn vị",
                DataPropertyName = "Unit",
                Width = 140,
                ReadOnly = true
            });

            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "Số lượng",
                DataPropertyName = "Quantity",
                Width = 140,
                ReadOnly = true
            });
            dgvOrderItems.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Xóa",
                Text = "❌ Xóa",
                UseColumnTextForButtonValue = true,
                Width = 80
            });
            dgvOrderItems.DataSource = new BindingSource { DataSource = new DataTable() };
            EnsureGridSchema();
        }
        private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvOrderItems.Columns[e.ColumnIndex].Name == "Delete")
            {
                var result = MessageBox.Show(
                    "Bạn có chắc muốn xóa vé này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes) return;

                // Xóa khỏi grid
                dgvOrderItems.Rows.RemoveAt(e.RowIndex);

                // Xóa khỏi danh sách vé đã chọn
                if (e.RowIndex < _selectedTickets.Count)
                {
                    _selectedTickets.RemoveAt(e.RowIndex);
                }

                // Nếu không còn vé thì disable nút xác nhận
                if (_selectedTickets.Count == 0)
                {
                    buttonCheckIn.Enabled = false;
                }
            }
        }

        private DataTable EnsureGridSchema()
        {
            var bs = dgvOrderItems.DataSource as BindingSource;
            var dt = bs?.DataSource as DataTable;

            if (dt == null)
            {
                dt = new DataTable();
                bs.DataSource = dt;
            }

            if (!dt.Columns.Contains("Description")) dt.Columns.Add("Description", typeof(string));
            if (!dt.Columns.Contains("Unit")) dt.Columns.Add("Unit", typeof(string));
            if (!dt.Columns.Contains("Quantity")) dt.Columns.Add("Quantity", typeof(int));

            return dt;
        }

        private void SetGridTicket(string desc, string unit, int qty)
        {
            var dt = EnsureGridSchema();
            dt.Rows.Clear();
            dt.Rows.Add(desc, unit, qty);
        }

        // ===================== ROLES =====================
        private void LoadRolesToCombo()
        {
            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand("SELECT RoleID, RoleName FROM [Role] ORDER BY RoleID", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                conn.Open();
                da.Fill(dt);

                cbDataSource.DisplayMember = "RoleName";
                cbDataSource.ValueMember = "RoleID";
                cbDataSource.DataSource = dt;
            }
        }

        // ===================== SEARCH STAFF BY PHONE =====================
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            ResetStaffUI();
            ResetTicketUI();

            string phone = (txtSearchInput.Text ?? "").Trim();

            // yêu cầu bạn: sai format hoặc không tìm thấy => Not Null
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Not Null (Không tìm kiếm được)", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roleId = cbDataSource.SelectedValue == null ? 0 : Convert.ToInt32(cbDataSource.SelectedValue);

            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(@"
SELECT u.UserID, u.FullName, u.Email, u.Address, r.RoleName
FROM [User] u
LEFT JOIN [Role] r ON u.RoleID = r.RoleID
WHERE u.PhoneNumber = @p
  AND (@rid = 0 OR u.RoleID = @rid)
", conn))
            {
                cmd.Parameters.AddWithValue("@p", phone);
                cmd.Parameters.AddWithValue("@rid", roleId);

                conn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (!rd.Read())
                    {
                        MessageBox.Show("Not Null (Không tìm kiếm được)", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    _currentStaffId = Convert.ToInt32(rd["UserID"]);

                    lblStaffNameValue.Text = rd["FullName"] == DBNull.Value ? "null" : rd["FullName"].ToString();
                    lblStaffEmailValue.Text = rd["Email"] == DBNull.Value ? "null" : rd["Email"].ToString();
                    lblStaffAddressValue.Text = rd["Address"] == DBNull.Value ? "null" : rd["Address"].ToString();

                    // Nếu bạn rename label role value thành lblStaffRoleValue thì dùng dòng này:
                    // lblStaffRoleValue.Text = rd["RoleName"] == DBNull.Value ? "null" : rd["RoleName"].ToString();

                    // Nếu bạn CHƯA rename (vẫn là label1) thì dùng dòng này:
                    lblStaffRoleValue.Text = rd["RoleName"] == DBNull.Value ? "null" : rd["RoleName"].ToString();
                }
            }
        }

        private bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            if (phone.Length < 9 || phone.Length > 15) return false;
            return phone.All(char.IsDigit);
        }

        private void ResetStaffUI()
        {
            _currentStaffId = null;
            lblStaffNameValue.Text = "DEFAUL NAME";
            lblStaffEmailValue.Text = "null";
            lblStaffAddressValue.Text = "null";

            // rename thì đổi cho đúng control
            // lblStaffRoleValue.Text = "null";
            lblStaffRoleValue.Text = "null";
        }

        // ===================== CHECK SECRET CODE -> OPEN PICK TICKET FORM =====================
        private void btnCheckDiscount_Click(object sender, EventArgs e)
        {
            if (_currentStaffId == null)
            {
                MessageBox.Show("Chưa tìm nhân viên. Nhập SĐT và bấm Tìm kiếm trước.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string code = (txtDiscountCode.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Not Null", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidSecretCode(_currentStaffId.Value, code))
            {
                MessageBox.Show("Not Null", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var f = new JumpArena.View.Staff.Checkin(_cs))
            {
                var dr = f.ShowDialog(this);
                if (dr == DialogResult.OK && f.SelectedTicket != null)
                {
                    _selectedTicketProductId = f.SelectedTicket.ProductID;
                    _selectedTicketName = f.SelectedTicket.ProductName;
                    _selectedTicketPrice = f.SelectedTicket.Price;

                    // đơn vị/ số lượng: bạn nói đã có layout rồi, mình chỉ đổ data
                    AppendTicketToGrid(f.SelectedTicket.ProductName, f.SelectedTicket.Unit, f.SelectedTicket.Quantity);

                    // lưu danh sách vé đã chọn để lúc "Xác nhận vé" insert nhiều dòng
                    _selectedTickets.Add(f.SelectedTicket);

                    buttonCheckIn.Enabled = _selectedTickets.Count > 0;

                    // reset mã bí mật để bắt nhập lại lần sau
                    txtDiscountCode.Text = "";
                    txtDiscountCode.Focus();

                }
            }
        }
        private void AppendTicketToGrid(string desc, string unit, int qty)
        {
            var dt = EnsureGridSchema();
            dt.Rows.Add(desc, unit, qty);
        }

        private bool IsValidSecretCode(int userId, string code)
        {
            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE UserID=@id AND SecretCode=@c", conn))
            {
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@c", code);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void ResetTicketUI()
        {
            _selectedTickets.Clear();
            EnsureGridSchema().Rows.Clear();
            buttonCheckIn.Enabled = false;
            txtDiscountCode.Text = "";
        }

        // ===================== CONFIRM TICKET -> SAVE DB =====================
        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            if (_currentStaffId == null || _selectedTickets.Count == 0)
            {
                MessageBox.Show("Chưa chọn vé.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = _selectedTickets.Sum(x => x.Price * x.Quantity);

            using (var conn = new SqlConnection(_cs))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    int invoiceId;
                    using (var cmd = new SqlCommand(@"
INSERT INTO Invoice(CreatedDate, TotalOriginalAmount, DiscountAmount, Status, PaymentStatus, CustomerID, UserID, VoucherID)
VALUES (GETDATE(), @total, @discount, N'Completed', N'Paid', NULL, @uid, NULL);
SELECT SCOPE_IDENTITY();
", conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@discount", total);
                        cmd.Parameters.AddWithValue("@uid", _currentStaffId.Value);
                        invoiceId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    foreach (var t in _selectedTickets)
                    {
                        int invoiceDetailId;
                        using (var cmd = new SqlCommand(@"
INSERT INTO InvoiceDetail(Quantity, PriceAtPurchase, InvoiceID, ProductID)
VALUES (@qty, @price, @invoiceId, @pid);
SELECT SCOPE_IDENTITY();
", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@qty", t.Quantity);
                            cmd.Parameters.AddWithValue("@price", t.Price);
                            cmd.Parameters.AddWithValue("@invoiceId", invoiceId);
                            cmd.Parameters.AddWithValue("@pid", t.ProductID);
                            invoiceDetailId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // tạo 1 code cho mỗi dòng vé (hoặc loop theo qty nếu bạn muốn mỗi vé 1 code)
                        string checkCode = "CHK" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
                        using (var cmd = new SqlCommand(@"
INSERT INTO CheckinCode(Code, CheckinTime, CheckoutTime, ExpiryDate, Status, InvoiceDetailID, CustomerID)
VALUES (@code, GETDATE(), NULL, DATEADD(day, 1, GETDATE()), N'CheckedIn', @invDetailId, NULL);
", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@code", checkCode);
                            cmd.Parameters.AddWithValue("@invDetailId", invoiceDetailId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    tran.Commit();
                }
            }

            MessageBox.Show("Đã xác nhận vé.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetTicketUI();


        }
    }
}
