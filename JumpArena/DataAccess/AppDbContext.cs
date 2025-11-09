using JumpArena.Models; // Quan trọng: để nó thấy các Models
using Microsoft.EntityFrameworkCore;
using System;

namespace JumpArena.DataAccess
{
    public class AppDbContext : DbContext
    {
        // === KHAI BÁO TẤT CẢ CÁC BẢNG ===
        // Bước này báo cho "Trình quản lý" biết về 12 Model của bạn
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<CheckinCode> CheckinCodes { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }

        // Hàm này cấu hình kết nối đến file SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=JumpArena.db");
        }

        // === CHÈN DỮ LIỆU MẪU (DATA SEEDING) ===
        // Đây là phần "dịch" các lệnh INSERT INTO từ file SQL của bạn
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --- Vai Trò ---
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleID = 1, RoleName = "Nhân viên" },
                new Role { RoleID = 2, RoleName = "Quản lý" },
                new Role { RoleID = 3, RoleName = "Kế toán trưởng" }
            );

            // --- Người Dùng ---
            // Cảnh báo: Mật khẩu đang lưu rõ. Khi làm thật, chúng ta sẽ mã hóa.
            modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, FullName = "Nguyễn Văn Hiệp", BirthDate = new DateTime(1990, 5, 20), Address = "Quận 1, TPHCM", Username = "HiepJAQL00078", Password = "Hiep@2025", RoleID = 2 },
                new User { UserID = 2, FullName = "Trần Thị Bích Loan", BirthDate = new DateTime(1992, 8, 15), Address = "Thành phố Thủ Đức", Username = "LoanJAQL00079", Password = "Loan@2025", RoleID = 2 },
                new User { UserID = 3, FullName = "Lê Thị Mai", BirthDate = new DateTime(1988, 12, 1), Address = "Quận 3, TPHCM", Username = "MaiJAKT00001", Password = "Mai@2025", RoleID = 3 },
                new User { UserID = 4, FullName = "Trần Minh Hoàng", BirthDate = new DateTime(2003, 4, 10), Address = "Gò Vấp, TPHCM", Username = "HoangJAGV0001", Password = "Hoang@2025", RoleID = 1 },
                new User { UserID = 5, FullName = "Phạm Thị Yến", BirthDate = new DateTime(2004, 7, 22), Address = "Bình Thạnh, TPHCM", Username = "YenJAGV0002", Password = "Yen@2025", RoleID = 1 },
                new User { UserID = 6, FullName = "Lý Văn Dũng", BirthDate = new DateTime(2002, 11, 5), Address = "Quận 12, TPHCM", Username = "DungJAGV0003", Password = "Dung@2025", RoleID = 1 },
                new User { UserID = 7, FullName = "Đỗ Huyền Anh", BirthDate = new DateTime(2005, 1, 30), Address = "Tân Bình, TPHCM", Username = "AnhJAGV0004", Password = "Anh@2025", RoleID = 1 },
                new User { UserID = 8, FullName = "Võ Thành Trung", BirthDate = new DateTime(2003, 9, 18), Address = "Phú Nhuận, TPHCM", Username = "TrungJAGV0005", Password = "Trung@2025", RoleID = 1 }
            );

            // --- Loại Sản Phẩm ---
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Vé vui chơi" },
                new Category { CategoryID = 2, CategoryName = "Vớ" },
                new Category { CategoryID = 3, CategoryName = "Đồ uống" }
            );

            // --- Sản Phẩm ---
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, ProductName = "Vé người lớn (Trong tuần)", CategoryID = 1, Price = 140000, StockQuantity = -1 },
                new Product { ProductID = 2, ProductName = "Vé trẻ em (Trong tuần)", CategoryID = 1, Price = 98000, StockQuantity = -1 },
                new Product { ProductID = 3, ProductName = "Combo Sinh viên (Vé + Vớ)", CategoryID = 1, Price = 1000, StockQuantity = -1 },
                new Product { ProductID = 4, ProductName = "Vé người lớn (Cuối tuần)", CategoryID = 1, Price = 180000, StockQuantity = -1 },
                new Product { ProductID = 5, ProductName = "Vé trẻ em (Cuối tuần)", CategoryID = 1, Price = 126000, StockQuantity = -1 },
                new Product { ProductID = 6, ProductName = "Vé Sự Kiện Halloween", CategoryID = 1, Price = 250000, StockQuantity = 100 },
                new Product { ProductID = 7, ProductName = "Vớ bám bạt thường", CategoryID = 2, Price = 29000, StockQuantity = 500 },
                new Product { ProductID = 8, ProductName = "Vớ Giáng Sinh", CategoryID = 2, Price = 29000, StockQuantity = 200 },
                new Product { ProductID = 9, ProductName = "Vớ Summer", CategoryID = 2, Price = 29000, StockQuantity = 150 },
                new Product { ProductID = 10, ProductName = "Vớ Sinh nhật", CategoryID = 2, Price = 29000, StockQuantity = 150 },
                new Product { ProductID = 11, ProductName = "Trà Đào Cam Sả", CategoryID = 3, Price = 45000, StockQuantity = 100 },
                new Product { ProductID = 12, ProductName = "Trà Vải", CategoryID = 3, Price = 42000, StockQuantity = 100 },
                new Product { ProductID = 13, ProductName = "Trà Chanh", CategoryID = 3, Price = 30000, StockQuantity = 100 },
                new Product { ProductID = 14, ProductName = "Pocari Sweat", CategoryID = 3, Price = 20000, StockQuantity = 200 },
                new Product { ProductID = 15, ProductName = "Sting Dâu", CategoryID = 3, Price = 15000, StockQuantity = 200 },
                new Product { ProductID = 16, ProductName = "Red Bull", CategoryID = 3, Price = 20000, StockQuantity = 200 },
                new Product { ProductID = 17, ProductName = "Coca-Cola", CategoryID = 3, Price = 15000, StockQuantity = 300 },
                new Product { ProductID = 18, ProductName = "7 Up", CategoryID = 3, Price = 15000, StockQuantity = 300 },
                new Product { ProductID = 19, ProductName = "Pepsi", CategoryID = 3, Price = 15000, StockQuantity = 300 },
                new Product { ProductID = 20, ProductName = "Olong Tea Plus", CategoryID = 3, Price = 18000, StockQuantity = 200 },
                new Product { ProductID = 21, ProductName = "Trà xanh không độ", CategoryID = 3, Price = 18000, StockQuantity = 200 },
                new Product { ProductID = 22, ProductName = "Nước suối Aquafina 500ml", CategoryID = 3, Price = 10000, StockQuantity = 500 }
            );

            // --- Voucher ---
            modelBuilder.Entity<Voucher>().HasData(
                new Voucher { VoucherID = 1, VoucherCode = "GIAM50K", Description = "Giảm 50.000 VNĐ cho đơn hàng từ 250.000 VNĐ", DiscountType = "Fixed", DiscountValue = 50000, MinimumOrderValue = 250000, StartDate = new DateTime(2025, 1, 1), EndDate = new DateTime(2025, 12, 31) },
                new Voucher { VoucherID = 2, VoucherCode = "SINHVIEN10", Description = "Giảm 10% cho sinh viên", DiscountType = "Percentage", DiscountValue = 10, MinimumOrderValue = 0, StartDate = new DateTime(2025, 1, 1), EndDate = new DateTime(2025, 12, 31) },
                new Voucher { VoucherID = 3, VoucherCode = "QUOCKHANH", Description = "Mừng Quốc Khánh 2/9, giảm 20% tổng hóa đơn", DiscountType = "Percentage", DiscountValue = 20, MinimumOrderValue = 0, StartDate = new DateTime(2025, 9, 1), EndDate = new DateTime(2025, 9, 3) },
                new Voucher { VoucherID = 4, VoucherCode = "HALLOWEEN", Description = "Lễ Halloween giảm 30.000đ cho đơn >200k", DiscountType = "Fixed", DiscountValue = 30000, MinimumOrderValue = 200000, StartDate = new DateTime(2025, 10, 28), EndDate = new DateTime(2025, 10, 31) }
            );

            // --- Phương Thức Thanh Toán ---
            modelBuilder.Entity<PaymentMethod>().HasData(
                new PaymentMethod { PaymentMethodID = 1, MethodName = "Tiền mặt", IsDigital = false },
                new PaymentMethod { PaymentMethodID = 2, MethodName = "Chuyển khoản ngân hàng", IsDigital = true },
                new PaymentMethod { PaymentMethodID = 3, MethodName = "Thẻ tín dụng (Credit Card)", IsDigital = true },
                new PaymentMethod { PaymentMethodID = 4, MethodName = "Ví MoMo", IsDigital = true },
                new PaymentMethod { PaymentMethodID = 5, MethodName = "Ví ZaloPay", IsDigital = true }
            );
        }
    }
}