using System;
using System.Windows.Forms;

namespace YourProjectNamespace
{
    public partial class ReportAndFeedbackForm : Form
    {
        public ReportAndFeedbackForm()
        {
            InitializeComponent();
            InitializeData();

            // Đặt thời gian check-in mặc định
            dtpCheckInTime.Value = DateTime.Now.Date;
        }

        private void InitializeData()
        {
            // --- Khung Trái: Thống kê Dữ liệu ---

            // Trạng thái Voucher
            cmbVoucherStatus.Items.AddRange(new string[] { "Tất cả", "Đã sử dụng", "Chưa sử dụng" });
            cmbVoucherStatus.SelectedIndex = 0;

            // Người Check-in (Giả định)
            cmbCheckInUser.Items.AddRange(new string[] { "Admin", "User 101", "User 102", "User 103" });
            cmbCheckInUser.SelectedIndex = 0;

            // Sản phẩm còn lại (Giả định các mốc)
            cmbInventory.Items.AddRange(new string[] { "Tất cả", "> 500 SP", "> 100 SP", "< 50 SP" });
            cmbInventory.SelectedIndex = 0;

            // Lịch sử Đơn hàng
            cmbOrderHistory.Items.AddRange(new string[] { "Xem 7 ngày qua", "Xem 30 ngày qua", "Tùy chỉnh" });
            cmbOrderHistory.SelectedIndex = 0;

            // --- Khung Phải: Báo cáo & Phản hồi ---

            // Loại Báo cáo
            cmbReportType.Items.AddRange(new string[] { "Báo cáo Kế toán (Tổng hợp Đơn hàng)", "Báo cáo Quản lý (Hoạt động Voucher)", "Báo cáo Nhân viên (Hiệu suất Check-in)" });
            cmbReportType.SelectedIndex = 0;

            // Nơi gửi trả lời
            cmbReplyTo.Items.AddRange(new string[] { "Quản lý", "Kế toán", "Nhân viên (User ID/Bộ phận)" });
            cmbReplyTo.SelectedIndex = 0;

            // Kích hoạt hàm tải nội dung báo cáo giả định ban đầu
            cmbReportType_SelectedIndexChanged(cmbReportType, EventArgs.Empty);
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logic giả định tải báo cáo chi tiết khi thay đổi loại báo cáo
            string selectedReport = cmbReportType.SelectedItem.ToString();

            if (selectedReport.Contains("Kế toán"))
            {
                txtReportContent.Text = "BÁO CÁO KẾ TOÁN (TÓM TẮT):\nTổng doanh thu: 500,000,000 VND. Số dư: 120,000,000 VND. Voucher đã áp dụng: 500 lượt.";
            }
            else if (selectedReport.Contains("Quản lý"))
            {
                txtReportContent.Text = "BÁO CÁO QUẢN LÝ (VOUCHER):\nHiệu suất Voucher (VCH001): 85%. Lượt Check-in cao nhất: User 101 (30 lượt).";
            }
            else if (selectedReport.Contains("Nhân viên"))
            {
                txtReportContent.Text = "BÁO CÁO NHÂN VIÊN (HIỆU SUẤT):\nTop 3 nhân viên check-in Voucher nhanh nhất. Tỷ lệ lỗi nhập liệu: 0.5%.";
            }
            else
            {
                txtReportContent.Text = "Vui lòng chọn một loại báo cáo để xem chi tiết.";
            }
        }

        private void btnConfirmReply_Click(object sender, EventArgs e)
        {
            // Logic gửi trả lời/phản hồi (XÁC NHẬN CÂU TRẢ LỜI)
            string replyTo = cmbReplyTo.SelectedItem.ToString();
            string replyText = txtReplyText.Text;

            if (string.IsNullOrWhiteSpace(replyText))
            {
                MessageBox.Show("Vui lòng nhập nội dung trả lời/phản hồi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReplyText.Focus();
                return;
            }

            // Gọi hàm lưu/gửi phản hồi
            MessageBox.Show($"Đã gửi phản hồi thành công đến bộ phận: {replyTo}\nNội dung: {replyText}", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa nội dung trả lời sau khi gửi
            txtReplyText.Clear();
        }
    }
}