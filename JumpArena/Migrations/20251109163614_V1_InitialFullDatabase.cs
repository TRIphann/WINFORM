using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JumpArena.Migrations
{
    /// <inheritdoc />
    public partial class V1_InitialFullDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    CompanyAddress = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    TaxCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    LegalRepresentative = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "LichSuHoatDong",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvoiceID = table.Column<int>(type: "INTEGER", nullable: true),
                    UserID = table.Column<int>(type: "INTEGER", nullable: true),
                    ActionType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Timestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Changes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuHoatDong", x => x.LogID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "PhuongThucThanhToan",
                columns: table => new
                {
                    PaymentMethodID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MethodName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IsDigital = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongThucThanhToan", x => x.PaymentMethodID);
                });

            migrationBuilder.CreateTable(
                name: "VaiTro",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTro", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    VoucherID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VoucherCode = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    DiscountType = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    MinimumOrderValue = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.VoucherID);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    StockQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "LoaiSanPham",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    RoleID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_NguoiDung_VaiTro_RoleID",
                        column: x => x.RoleID,
                        principalTable: "VaiTro",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    InvoiceID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalOriginalAmount = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Status = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PaymentStatus = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CustomerID = table.Column<int>(type: "INTEGER", nullable: true),
                    UserID = table.Column<int>(type: "INTEGER", nullable: true),
                    VoucherID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.InvoiceID);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "KhachHang",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_HoaDon_NguoiDung_UserID",
                        column: x => x.UserID,
                        principalTable: "NguoiDung",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_HoaDon_Voucher_VoucherID",
                        column: x => x.VoucherID,
                        principalTable: "Voucher",
                        principalColumn: "VoucherID");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    InvoiceDetailID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    PriceAtPurchase = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    InvoiceID = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.InvoiceDetailID);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_InvoiceID",
                        column: x => x.InvoiceID,
                        principalTable: "HoaDon",
                        principalColumn: "InvoiceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_SanPham_ProductID",
                        column: x => x.ProductID,
                        principalTable: "SanPham",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThanhToan",
                columns: table => new
                {
                    PaymentTransactionID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Amount = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TransactionCode = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Note = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    InvoiceID = table.Column<int>(type: "INTEGER", nullable: false),
                    PaymentMethodID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToan", x => x.PaymentTransactionID);
                    table.ForeignKey(
                        name: "FK_ThanhToan_HoaDon_InvoiceID",
                        column: x => x.InvoiceID,
                        principalTable: "HoaDon",
                        principalColumn: "InvoiceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThanhToan_PhuongThucThanhToan_PaymentMethodID",
                        column: x => x.PaymentMethodID,
                        principalTable: "PhuongThucThanhToan",
                        principalColumn: "PaymentMethodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaCheckin",
                columns: table => new
                {
                    CheckinID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CheckinTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    InvoiceDetailID = table.Column<int>(type: "INTEGER", nullable: true),
                    CustomerID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaCheckin", x => x.CheckinID);
                    table.ForeignKey(
                        name: "FK_MaCheckin_ChiTietHoaDon_InvoiceDetailID",
                        column: x => x.InvoiceDetailID,
                        principalTable: "ChiTietHoaDon",
                        principalColumn: "InvoiceDetailID");
                    table.ForeignKey(
                        name: "FK_MaCheckin_KhachHang_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "KhachHang",
                        principalColumn: "CustomerID");
                });

            migrationBuilder.InsertData(
                table: "LoaiSanPham",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Vé vui chơi" },
                    { 2, "Vớ" },
                    { 3, "Đồ uống" }
                });

            migrationBuilder.InsertData(
                table: "PhuongThucThanhToan",
                columns: new[] { "PaymentMethodID", "IsDigital", "MethodName" },
                values: new object[,]
                {
                    { 1, false, "Tiền mặt" },
                    { 2, true, "Chuyển khoản ngân hàng" },
                    { 3, true, "Thẻ tín dụng (Credit Card)" },
                    { 4, true, "Ví MoMo" },
                    { 5, true, "Ví ZaloPay" }
                });

            migrationBuilder.InsertData(
                table: "VaiTro",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 1, "Nhân viên" },
                    { 2, "Quản lý" },
                    { 3, "Kế toán trưởng" }
                });

            migrationBuilder.InsertData(
                table: "Voucher",
                columns: new[] { "VoucherID", "Description", "DiscountType", "DiscountValue", "EndDate", "MinimumOrderValue", "StartDate", "VoucherCode" },
                values: new object[,]
                {
                    { 1, "Giảm 50.000 VNĐ cho đơn hàng từ 250.000 VNĐ", "Fixed", 50000m, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 250000m, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GIAM50K" },
                    { 2, "Giảm 10% cho sinh viên", "Percentage", 10m, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SINHVIEN10" },
                    { 3, "Mừng Quốc Khánh 2/9, giảm 20% tổng hóa đơn", "Percentage", 20m, new DateTime(2025, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QUOCKHANH" },
                    { 4, "Lễ Halloween giảm 30.000đ cho đơn >200k", "Fixed", 30000m, new DateTime(2025, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 200000m, new DateTime(2025, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "HALLOWEEN" }
                });

            migrationBuilder.InsertData(
                table: "NguoiDung",
                columns: new[] { "UserID", "Address", "BirthDate", "FullName", "Password", "RoleID", "Username" },
                values: new object[,]
                {
                    { 1, "Quận 1, TPHCM", new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyễn Văn Hiệp", "Hiep@2025", 2, "HiepJAQL00078" },
                    { 2, "Thành phố Thủ Đức", new DateTime(1992, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trần Thị Bích Loan", "Loan@2025", 2, "LoanJAQL00079" },
                    { 3, "Quận 3, TPHCM", new DateTime(1988, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lê Thị Mai", "Mai@2025", 3, "MaiJAKT00001" },
                    { 4, "Gò Vấp, TPHCM", new DateTime(2003, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trần Minh Hoàng", "Hoang@2025", 1, "HoangJAGV0001" },
                    { 5, "Bình Thạnh, TPHCM", new DateTime(2004, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phạm Thị Yến", "Yen@2025", 1, "YenJAGV0002" },
                    { 6, "Quận 12, TPHCM", new DateTime(2002, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lý Văn Dũng", "Dung@2025", 1, "DungJAGV0003" },
                    { 7, "Tân Bình, TPHCM", new DateTime(2005, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đỗ Huyền Anh", "Anh@2025", 1, "AnhJAGV0004" },
                    { 8, "Phú Nhuận, TPHCM", new DateTime(2003, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Võ Thành Trung", "Trung@2025", 1, "TrungJAGV0005" }
                });

            migrationBuilder.InsertData(
                table: "SanPham",
                columns: new[] { "ProductID", "CategoryID", "Description", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, null, 140000m, "Vé người lớn (Trong tuần)", -1 },
                    { 2, 1, null, 98000m, "Vé trẻ em (Trong tuần)", -1 },
                    { 3, 1, null, 1000m, "Combo Sinh viên (Vé + Vớ)", -1 },
                    { 4, 1, null, 180000m, "Vé người lớn (Cuối tuần)", -1 },
                    { 5, 1, null, 126000m, "Vé trẻ em (Cuối tuần)", -1 },
                    { 6, 1, null, 250000m, "Vé Sự Kiện Halloween", 100 },
                    { 7, 2, null, 29000m, "Vớ bám bạt thường", 500 },
                    { 8, 2, null, 29000m, "Vớ Giáng Sinh", 200 },
                    { 9, 2, null, 29000m, "Vớ Summer", 150 },
                    { 10, 2, null, 29000m, "Vớ Sinh nhật", 150 },
                    { 11, 3, null, 45000m, "Trà Đào Cam Sả", 100 },
                    { 12, 3, null, 42000m, "Trà Vải", 100 },
                    { 13, 3, null, 30000m, "Trà Chanh", 100 },
                    { 14, 3, null, 20000m, "Pocari Sweat", 200 },
                    { 15, 3, null, 15000m, "Sting Dâu", 200 },
                    { 16, 3, null, 20000m, "Red Bull", 200 },
                    { 17, 3, null, 15000m, "Coca-Cola", 300 },
                    { 18, 3, null, 15000m, "7 Up", 300 },
                    { 19, 3, null, 15000m, "Pepsi", 300 },
                    { 20, 3, null, 18000m, "Olong Tea Plus", 200 },
                    { 21, 3, null, 18000m, "Trà xanh không độ", 200 },
                    { 22, 3, null, 10000m, "Nước suối Aquafina 500ml", 500 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_InvoiceID",
                table: "ChiTietHoaDon",
                column: "InvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_ProductID",
                table: "ChiTietHoaDon",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_CustomerID",
                table: "HoaDon",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_UserID",
                table: "HoaDon",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_VoucherID",
                table: "HoaDon",
                column: "VoucherID");

            migrationBuilder.CreateIndex(
                name: "IX_MaCheckin_CustomerID",
                table: "MaCheckin",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_MaCheckin_InvoiceDetailID",
                table: "MaCheckin",
                column: "InvoiceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_RoleID",
                table: "NguoiDung",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_CategoryID",
                table: "SanPham",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhToan_InvoiceID",
                table: "ThanhToan",
                column: "InvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhToan_PaymentMethodID",
                table: "ThanhToan",
                column: "PaymentMethodID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LichSuHoatDong");

            migrationBuilder.DropTable(
                name: "MaCheckin");

            migrationBuilder.DropTable(
                name: "ThanhToan");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "PhuongThucThanhToan");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropTable(
                name: "VaiTro");
        }
    }
}
