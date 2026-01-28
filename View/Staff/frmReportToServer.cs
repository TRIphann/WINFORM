using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JumpArena
{
    public partial class frmReportToServer : Form
    {
        // Connection string của bạn
        private readonly string _connStr =
            @"Server=.\SQL2022NEW;Database=JumpArenaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        private bool _isVerified = false;
        private string _verifiedUsername = "";
        private string _verifiedRole = "";
        private string _attachmentPath = null;

        public frmReportToServer()
        {
            InitializeComponent();

            this.Load += frmReportToServer_Load;

            btnVerify.Click += btnVerify_Click;
            btnCancel.Click += btnCancel_Click;
            btnAttachFile.Click += btnAttachFile_Click;
            btnSendReport.Click += btnSendReport_Click;

            cbReportType.SelectedIndexChanged += AnyInputChanged_Revalidate;
            cbPriority.SelectedIndexChanged += AnyInputChanged_Revalidate;
            txtRelatedBillID.TextChanged += AnyInputChanged_Revalidate;
            txtSubject.TextChanged += AnyInputChanged_Revalidate;
            txtReportContent.TextChanged += AnyInputChanged_Revalidate;
        }

        // ================= FORM LOAD =================

        private void frmReportToServer_Load(object sender, EventArgs e)
        {
            cbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPriority.DropDownStyle = ComboBoxStyle.DropDownList;

            cbReportType.Items.AddRange(new object[]
            {
                "Bán hàng (POS)",
                "Check-in / Check-out",
                "Sản phẩm",
                "Hết hàng / Tồn kho",
                "Voucher / Khuyến mãi",
                "Thanh toán",
                "Máy in / Hóa đơn",
                "Lỗi hệ thống",
                "Góp ý cải tiến",
                "Khác"
            });

            cbPriority.Items.AddRange(new object[]
            {
                "Cao", "Vừa", "Thấp"
            });

            cbPriority.SelectedItem = "Vừa";

            pnlContent.Enabled = false;
            btnSendReport.Enabled = false;

            SetAuthStatus("Chưa xác thực", Color.DarkRed);
        }

        // ================= AUTH =================

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string user = txtStaffUser.Text.Trim();
            string pass = txtStaffPass.Text.Trim();

            if (user == "" || pass == "")
            {
                SetAuthStatus("Thiếu tài khoản hoặc mật khẩu", Color.Red);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connStr))
                {
                    string sql = @"
SELECT TOP 1 Username, FullName, RoleID
FROM dbo.[User]
WHERE Username = @u AND [Password] = @p";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@p", pass);

                    conn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();

                    if (!rd.Read())
                    {
                        _isVerified = false;
                        pnlContent.Enabled = false;

                        SetAuthStatus("Sai tài khoản hoặc mật khẩu", Color.Red);
                        RevalidateSendButton();
                        return;
                    }

                    _verifiedUsername = rd["Username"].ToString();
                    string fullName = rd["FullName"].ToString();
                    int roleId = Convert.ToInt32(rd["RoleID"]);

                    // Map role theo DB của bạn
                    _verifiedRole = roleId == 1 ? "Manager" : "Staff";

                    _isVerified = true;
                    pnlContent.Enabled = true;

                    SetAuthStatus($"Đăng nhập OK: {fullName} ({_verifiedRole})", Color.Green);

                    AutoFillSubjectAndContent();
                    RevalidateSendButton();
                }
            }
            catch (Exception ex)
            {
                _isVerified = false;
                pnlContent.Enabled = false;

                MessageBox.Show(ex.Message, "SQL ERROR");
                SetAuthStatus("Lỗi kết nối SQL", Color.Red);
            }
        }

        private void SetAuthStatus(string text, Color color)
        {
            lblAuthStatus.Text = "Trạng thái: " + text;
            lblAuthStatus.ForeColor = color;
        }

        // ================= AUTO FILL =================

        private void AnyInputChanged_Revalidate(object sender, EventArgs e)
        {
            AutoFillSubjectAndContent();
            RevalidateSendButton();
        }

        private void AutoFillSubjectAndContent()
        {
            if (!_isVerified) return;

            string type = cbReportType.SelectedItem?.ToString() ?? "";
            string priority = cbPriority.SelectedItem?.ToString() ?? "";
            string bill = txtRelatedBillID.Text.Trim();

            if (txtSubject.Text.Trim() == "" && type != "")
            {
                txtSubject.Text = $"[{type}] Bill {bill} - {priority}";
            }

            if (txtReportContent.Text.Trim() == "")
            {
                txtReportContent.Text =
$@"Thời gian: {DateTime.Now:yyyy-MM-dd HH:mm:ss}
Người gửi: {_verifiedUsername} ({_verifiedRole})
Phân loại: {type}
Ưu tiên: {priority}
Mã Bill: {bill}

Mô tả vấn đề:
- ...

Hướng xử lý mong muốn:
- ...
";
            }
        }

        private void RevalidateSendButton()
        {
            bool allowSend =
                _isVerified &&
                cbReportType.SelectedItem != null &&
                cbPriority.SelectedItem != null &&
                txtRelatedBillID.Text.Trim() != "" &&
                txtSubject.Text.Trim() != "" &&
                txtReportContent.Text.Trim() != "";

            btnSendReport.Enabled = allowSend;
        }

        // ================= CANCEL =================

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn muốn hủy report và thoát form?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
                this.Close();
        }

        // ================= ATTACH =================

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.png;*.jpg;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _attachmentPath = ofd.FileName;
                MessageBox.Show("Đã chọn file: " + Path.GetFileName(_attachmentPath));
            }
        }

        // ================= SEND =================

        private void btnSendReport_Click(object sender, EventArgs e)
        {
            if (!btnSendReport.Enabled) return;

            byte[] fileBytes = null;
            string fileName = null;

            if (_attachmentPath != null && File.Exists(_attachmentPath))
            {
                fileBytes = File.ReadAllBytes(_attachmentPath);
                fileName = Path.GetFileName(_attachmentPath);
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connStr))
                {
                    string sql = @"
INSERT INTO ReportToServer
(
    CreatedByUsername,
    CreatedByRole,
    IsActiveUser,
    ReportType,
    Priority,
    RelatedBillId,
    Subject,
    Content,
    AttachmentFileName,
    AttachmentData
)
VALUES
(
    @User,
    @Role,
    1,
    @Type,
    @Priority,
    @Bill,
    @Subject,
    @Content,
    @FileName,
    @FileData
)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = _verifiedUsername;
                    cmd.Parameters.Add("@Role", SqlDbType.NVarChar).Value = _verifiedRole;
                    cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = cbReportType.Text;
                    cmd.Parameters.Add("@Priority", SqlDbType.NVarChar).Value = MapPriority(cbPriority.Text);
                    cmd.Parameters.Add("@Bill", SqlDbType.NVarChar).Value = txtRelatedBillID.Text.Trim();
                    cmd.Parameters.Add("@Subject", SqlDbType.NVarChar).Value = txtSubject.Text.Trim();
                    cmd.Parameters.Add("@Content", SqlDbType.NVarChar).Value = txtReportContent.Text.Trim();

                    // ===== FIX LỖI VARBINARY =====

                    cmd.Parameters.Add("@FileName", SqlDbType.NVarChar).Value =
                        fileName == null ? (object)DBNull.Value : fileName;

                    cmd.Parameters.Add("@FileData", SqlDbType.VarBinary, -1).Value =
                        fileBytes == null ? (object)DBNull.Value : fileBytes;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Gửi report thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi report: " + ex.Message);
            }
        }


        private string MapPriority(string vn)
        {
            vn = vn.ToLower();

            if (vn.Contains("cao")) return "High";
            if (vn.Contains("thấp")) return "Low";

            return "Medium";
        }
    }
}
