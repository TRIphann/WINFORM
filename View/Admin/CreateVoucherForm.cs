using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace JumpArena.View.Admin
{
    public partial class CreateVoucherForm : Form
    {
        private readonly string _cs =
            System.Configuration.ConfigurationManager
                .ConnectionStrings["JumpArenaContextDB"].ConnectionString;

        private DataTable _dtVouchers;

        public CreateVoucherForm()
        {
            InitializeComponent();

            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddDays(7);

            SetupGrid();
            LoadVouchersFromDb();
        }

        private void SetupGrid()
        {
            dgvVouchers.AutoGenerateColumns = true;
            dgvVouchers.ReadOnly = true;
            dgvVouchers.AllowUserToAddRows = false;
            dgvVouchers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVouchers.MultiSelect = false;
            dgvVouchers.RowHeadersVisible = false;

            dgvVouchers.CellClick -= dgvVouchers_CellClick;
            dgvVouchers.CellClick += dgvVouchers_CellClick;
        }

        // ===================== LOAD LIST =====================
        private void LoadVouchersFromDb()
        {
            const string sql = @"
SELECT
    VoucherID,
    VoucherCode,
    Description,
    DiscountType,
    DiscountValue,
    MinimumOrderValue,
    StartDate,
    EndDate
FROM Voucher
ORDER BY VoucherID DESC;";

            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                _dtVouchers = new DataTable();
                da.Fill(_dtVouchers);
                dgvVouchers.DataSource = _dtVouchers;
            }

            // Header
            if (dgvVouchers.Columns["VoucherID"] != null) dgvVouchers.Columns["VoucherID"].HeaderText = "ID";
            if (dgvVouchers.Columns["VoucherCode"] != null) dgvVouchers.Columns["VoucherCode"].HeaderText = "Mã";
            if (dgvVouchers.Columns["Description"] != null) dgvVouchers.Columns["Description"].HeaderText = "Mô tả";
            if (dgvVouchers.Columns["DiscountType"] != null) dgvVouchers.Columns["DiscountType"].HeaderText = "Loại giảm";
            if (dgvVouchers.Columns["DiscountValue"] != null) dgvVouchers.Columns["DiscountValue"].HeaderText = "Giá trị giảm";
            if (dgvVouchers.Columns["MinimumOrderValue"] != null) dgvVouchers.Columns["MinimumOrderValue"].HeaderText = "Đơn tối thiểu";
            if (dgvVouchers.Columns["StartDate"] != null) dgvVouchers.Columns["StartDate"].HeaderText = "Bắt đầu";
            if (dgvVouchers.Columns["EndDate"] != null) dgvVouchers.Columns["EndDate"].HeaderText = "Kết thúc";

            dgvVouchers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // ===================== PICK ROW -> FILL TOP =====================
        private void dgvVouchers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvVouchers.Rows[e.RowIndex];

            txtCodeVoucher.Text = Convert.ToString(row.Cells["VoucherCode"].Value ?? "");
            txtProgramName.Text = Convert.ToString(row.Cells["Description"].Value ?? "");

            dtpStartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
            dtpEndDate.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);

            txtMin.Text = Convert.ToDecimal(row.Cells["MinimumOrderValue"].Value ?? 0m)
                .ToString(CultureInfo.InvariantCulture);

            // reset 2 ô giảm
            txtPercentValue.Text = "0";
            txtFixedValue.Text = "0";

            string type = Convert.ToString(row.Cells["DiscountType"].Value ?? "");
            decimal value = Convert.ToDecimal(row.Cells["DiscountValue"].Value ?? 0m);

            if (type.Equals("Percent", StringComparison.OrdinalIgnoreCase))
                txtPercentValue.Text = value.ToString(CultureInfo.InvariantCulture);
            else
                txtFixedValue.Text = value.ToString(CultureInfo.InvariantCulture);
        }

        // ===================== VALIDATE INPUT =====================
        private bool TryGetInput(
            out string code,
            out string desc,
            out DateTime start,
            out DateTime end,
            out string discountType,
            out decimal discountValue,
            out decimal minOrder)
        {
            code = (txtCodeVoucher.Text ?? "").Trim();
            desc = (txtProgramName.Text ?? "").Trim();
            start = dtpStartDate.Value;
            end = dtpEndDate.Value;

            discountType = "";
            discountValue = 0m;
            minOrder = 0m;

            if (string.IsNullOrWhiteSpace(desc))
            {
                MessageBox.Show("Nhập Tên chương trình (Description).");
                return false;
            }

            if (end <= start)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu.");
                return false;
            }

            // Minimum order
            if (!decimal.TryParse((txtMin.Text ?? "0").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out minOrder))
                minOrder = 0m;

            if (minOrder < 0) minOrder = 0m;

            // Discount
            decimal percent = 0m;
            decimal fixedAmt = 0m;

            decimal.TryParse((txtPercentValue.Text ?? "0").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out percent);
            decimal.TryParse((txtFixedValue.Text ?? "0").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out fixedAmt);

            if (percent < 0) percent = 0;
            if (fixedAmt < 0) fixedAmt = 0;

            if (percent > 0 && fixedAmt > 0)
            {
                MessageBox.Show("Chỉ chọn 1: giảm theo % hoặc giảm theo số tiền.");
                return false;
            }
            if (percent == 0 && fixedAmt == 0)
            {
                MessageBox.Show("Phải nhập giảm theo % hoặc giảm theo số tiền.");
                return false;
            }
            if (percent > 100)
            {
                MessageBox.Show("Giảm (%) không được > 100.");
                return false;
            }

            if (percent > 0)
            {
                discountType = "Percent";
                discountValue = percent;
            }
            else
            {
                discountType = "Fixed";
                discountValue = fixedAmt;
            }

            // Voucher code: nếu trống thì tự sinh
            if (string.IsNullOrWhiteSpace(code))
                code = "VCH" + DateTime.Now.ToString("yyMMddHHmmss");

            return true;
        }

        // ===================== CREATE =====================
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!TryGetInput(out var code, out var desc, out var start, out var end,
                    out var dtype, out var dvalue, out var minOrder))
                return;

            // Check trùng mã
            if (VoucherCodeExists(code))
            {
                MessageBox.Show("Mã voucher đã tồn tại. Đổi mã khác.");
                return;
            }

            const string sql = @"
INSERT INTO Voucher (VoucherCode, Description, DiscountType, DiscountValue, MinimumOrderValue, StartDate, EndDate)
VALUES (@Code, @Desc, @Type, @Value, @MinOrder, @Start, @End);";

            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Code", SqlDbType.NVarChar, 50).Value = code;
                cmd.Parameters.Add("@Desc", SqlDbType.NVarChar, 400).Value = desc;
                cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 20).Value = dtype;
                cmd.Parameters.Add("@Value", SqlDbType.Decimal).Value = dvalue;
                cmd.Parameters.Add("@MinOrder", SqlDbType.Decimal).Value = minOrder;
                cmd.Parameters.Add("@Start", SqlDbType.DateTime).Value = start;
                cmd.Parameters.Add("@End", SqlDbType.DateTime).Value = end;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadVouchersFromDb();
                    MessageBox.Show("Tạo voucher OK.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo voucher:\n" + ex.Message);
                }
            }
        }

        private bool VoucherCodeExists(string code)
        {
            const string sql = "SELECT COUNT(1) FROM Voucher WHERE VoucherCode = @Code;";
            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Code", SqlDbType.NVarChar, 50).Value = code;
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // ===================== UPDATE =====================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVouchers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn voucher bên dưới để sửa.");
                return;
            }

            if (!TryGetInput(out var code, out var desc, out var start, out var end,
                    out var dtype, out var dvalue, out var minOrder))
                return;

            int id = Convert.ToInt32(dgvVouchers.SelectedRows[0].Cells["VoucherID"].Value);

            // Check trùng mã (ngoại trừ chính nó)
            if (VoucherCodeExistsOtherId(code, id))
            {
                MessageBox.Show("Mã voucher đã tồn tại (ở voucher khác). Đổi mã khác.");
                return;
            }

            const string sql = @"
UPDATE Voucher
SET VoucherCode=@Code,
    Description=@Desc,
    DiscountType=@Type,
    DiscountValue=@Value,
    MinimumOrderValue=@MinOrder,
    StartDate=@Start,
    EndDate=@End
WHERE VoucherID=@Id;";

            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Code", SqlDbType.NVarChar, 50).Value = code;
                cmd.Parameters.Add("@Desc", SqlDbType.NVarChar, 400).Value = desc;
                cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 20).Value = dtype;
                cmd.Parameters.Add("@Value", SqlDbType.Decimal).Value = dvalue;
                cmd.Parameters.Add("@MinOrder", SqlDbType.Decimal).Value = minOrder;
                cmd.Parameters.Add("@Start", SqlDbType.DateTime).Value = start;
                cmd.Parameters.Add("@End", SqlDbType.DateTime).Value = end;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadVouchersFromDb();
                    MessageBox.Show("Sửa voucher OK.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa voucher:\n" + ex.Message);
                }
            }
        }

        private bool VoucherCodeExistsOtherId(string code, int id)
        {
            const string sql = "SELECT COUNT(1) FROM Voucher WHERE VoucherCode=@Code AND VoucherID<>@Id;";
            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Code", SqlDbType.NVarChar, 50).Value = code;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // ===================== DELETE =====================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVouchers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn voucher để xóa.");
                return;
            }

            int id = Convert.ToInt32(dgvVouchers.SelectedRows[0].Cells["VoucherID"].Value);
            string code = Convert.ToString(dgvVouchers.SelectedRows[0].Cells["VoucherCode"].Value ?? "");

            if (MessageBox.Show($"Xóa voucher {code}?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand("DELETE FROM Voucher WHERE VoucherID=@Id;", conn))
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadVouchersFromDb();
                    MessageBox.Show("Xóa OK.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa voucher:\n" + ex.Message);
                }
            }
        }
    }
}
