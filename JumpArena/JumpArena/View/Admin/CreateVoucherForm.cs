using System;
using System.Windows.Forms;

namespace YourProjectNamespace
{
    public partial class CreateVoucherForm : Form
    {
        public CreateVoucherForm()
        {
            InitializeComponent();

            // Đặt các giá trị mặc định khi Form khởi tạo
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddDays(7);

            LoadVoucherData(); // Gọi hàm tải dữ liệu
        }

        // --- HÀM TẢI DỮ LIỆU GIẢ CHO DATAGRIDVIEW ---
        private void LoadVoucherData()
        {
            // Thao tác với dgvVouchers
            dgvVouchers.Columns.Clear();
            dgvVouchers.Rows.Clear();

            // Thêm tiêu đề danh sách vào lưới (đã được đặt Dock=Top)
            // dgvVouchers.Controls.Add(lblVoucherListTitle); // Không cần nữa vì đã thêm vào Designer

            // Thiết lập cột
            dgvVouchers.Columns.Add("ID", "Mã Voucher");
            dgvVouchers.Columns.Add("Name", "Chương Trình");
            dgvVouchers.Columns.Add("Value", "Giá Trị");
            dgvVouchers.Columns.Add("Quantity", "SL Còn Lại");
            dgvVouchers.Columns.Add("EndDate", "Hạn Dùng");

            // Tải dữ liệu giả
            dgvVouchers.Rows.Add("VCH001", "Giảm 10% Tháng 12", "10%", 85, DateTime.Now.AddDays(10).ToString("dd/MM/yyyy"));
            dgvVouchers.Rows.Add("VCH002", "Giảm 50K cho đơn hàng mới", "50.000 VND", 150, DateTime.Now.AddDays(30).ToString("dd/MM/yyyy"));
            dgvVouchers.Rows.Add("VCH003", "Black Friday - Chỉ hôm nay", "25%", 12, DateTime.Now.AddHours(5).ToString("dd/MM/yyyy HH:mm"));

            dgvVouchers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // --- CÁC HÀM XỬ LÝ NÚT VÀ SỰ KIỆN ---

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Logic kiểm tra và Tạo Voucher (Giữ nguyên)
            string programName = txtProgramName.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // ... (Logic kiểm tra tính hợp lệ)

            MessageBox.Show("Đã gọi hàm Tạo Voucher thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Sau khi tạo thành công, có thể gọi LoadVoucherData() để cập nhật lưới
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Logic nút SỬA
            if (dgvVouchers.SelectedRows.Count > 0)
            {
                string voucherId = dgvVouchers.SelectedRows[0].Cells["ID"].Value.ToString();

                // Tải dữ liệu VoucherId lên các trường nhập liệu (txtProgramName, dtpStartDate, ...)

                MessageBox.Show($"Tải thông tin Voucher {voucherId} lên các trường để sửa.", "Tác vụ Sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Voucher từ danh sách bên dưới để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Logic nút XÓA
            if (dgvVouchers.SelectedRows.Count > 0)
            {
                string voucherName = dgvVouchers.SelectedRows[0].Cells["Name"].Value.ToString();
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa Voucher '{voucherName}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Logic xóa khỏi DB và lưới
                    dgvVouchers.Rows.RemoveAt(dgvVouchers.SelectedRows[0].Index);
                    MessageBox.Show($"Đã xóa Voucher {voucherName}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Voucher từ danh sách bên dưới để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}