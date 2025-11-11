// Thêm các thư viện (using) cần thiết ở đầu file
using JumpArena.DataAccess;
using JumpArena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// Đảm bảo namespace này khớp với tên dự án của bạn
namespace JumpArena.Views
{
    public partial class frmSelectRole : Form
    {
        // === KHAI BÁO BIẾN ===
        private List<Role> _allRoles; // Biến lưu danh sách vai trò

        public frmSelectRole()
        {
            InitializeComponent();
            _allRoles = new List<Role>();
        }

        // === GIAI ĐOẠN 1: FORM LOAD (TẢI VAI TRÒ) ===
        // (Kết nối sự kiện 'Load' của Form với hàm này)
        private void frmSelectRole_Load(object sender, EventArgs e)
        {
            // Ẩn các panel (nếu bạn có)
            // pnlSelectRole.Visible = false;
            // lblError.Visible = false;

            // 1. Tải vai trò từ DB
            if (LoadRolesFromDatabase())
            {
                // 2. Gán vai trò cho các nút (để biết nút nào là vai trò gì)
                AssignRolesToButtons();

                // 3. Hiện Panel chọn vai trò (Nếu bạn dùng Panel)
                 pnlSelectRole.Visible = true;
            }
            else
            {
                // Lỗi không tải được vai trò (ví dụ: lỗi DB)
                // ShowError("Không thể tải danh sách vai trò. Vui lòng liên hệ quản trị.");
                MessageBox.Show("Không thể tải danh sách vai trò. Vui lòng liên hệ quản trị.");
            }
        }

        // === GIAI ĐOẠN 2: NGƯỜI DÙNG CHỌN VAI TRÒ ===
        // (Kết nối sự kiện 'Click' của cả 4 nút vai trò với hàm này)
        private void RoleButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Role role = (Role)clickedButton.Tag; // Lấy vai trò đã gán

            if (role == null)
            {
                MessageBox.Show($"Vai trò '{clickedButton.Text}' chưa được cấu hình trong database.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TẠO VÀ MỞ FORM ĐĂNG NHẬP MỚI (frmLogin)
            // Chúng ta truyền 'role' (vai trò đã chọn) sang cho Form mới
            frmLogin loginForm = new frmLogin(role);

            // Mở form mới
            loginForm.Show();

            // Ẩn form chọn vai trò này đi
            this.Hide();
        }

        // === CÁC HÀM HỖ TRỢ (Nằm bên dưới) ===

        private bool LoadRolesFromDatabase()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    _allRoles = context.Roles.ToList(); // Tải tất cả vai trò vào biến
                }
                return _allRoles.Any(); // Trả về true nếu có ít nhất 1 vai trò
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        // Gán đối tượng Role từ DB vào thuộc tính 'Tag' của mỗi Nút
        private void AssignRolesToButtons()
        {
            // Chúng ta tìm vai trò bằng Tên (RoleName) để linh hoạt
            // Đảm bảo bạn đã có 4 nút (btnRoleNV, btnRoleManager,...) trong trình thiết kế
            btnRoleNV.Tag = _allRoles.FirstOrDefault(r => r.RoleName == "Nhân viên");
            btnRoleManager.Tag = _allRoles.FirstOrDefault(r => r.RoleName == "Quản lý");
            btnRoleAccountant.Tag = _allRoles.FirstOrDefault(r => r.RoleName == "Kế toán trưởng");
            // btnRoleAdmin.Tag = _allRoles.FirstOrDefault(r => r.RoleName == "Admin"); 
            // (Lưu ý: "Admin" chưa có trong data mẫu, nên nút này Tag sẽ là null)
        }
    }
}