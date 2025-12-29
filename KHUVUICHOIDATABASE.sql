-- ===================================================================
-- SCRIPT TẠO DATABASE HOÀN CHỈNH CHO JUMP ARENA
-- Bao gồm: Tạo bảng, Chèn dữ liệu mẫu, và Stored Procedures
-- ===================================================================

-- Xóa database cũ nếu tồn tại để tránh lỗi
IF DB_ID('JumpArenaDB') IS NOT NULL
BEGIN
    ALTER DATABASE JumpArenaDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE JumpArenaDB;
END
GO

-- 1. TẠO DATABASE
CREATE DATABASE JumpArenaDB;
GO
USE JumpArenaDB;
GO

-- ===========================
-- TẠO CÁC BẢNG
-- ===========================

-- Bảng Vai Trò
CREATE TABLE VaiTro (
    VaiTroID INT PRIMARY KEY IDENTITY(1,1),
    TenVaiTro NVARCHAR(50) NOT NULL UNIQUE
);
GO

-- Bảng Người Dùng (Nhân sự)
CREATE TABLE NguoiDung (
    NguoiDungID INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    DiaChi NVARCHAR(255),
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(255) NOT NULL,
    VaiTroID INT,
    FOREIGN KEY (VaiTroID) REFERENCES VaiTro(VaiTroID)
);
GO

-- Bảng Khách Hàng
CREATE TABLE KhachHang (
    KhachHangID INT PRIMARY KEY IDENTITY(1,1),
    SoDienThoai VARCHAR(15) NOT NULL UNIQUE,
    Ho NVARCHAR(50) NOT NULL,
    TenDem NVARCHAR(50),
    Ten NVARCHAR(50) NOT NULL,
    NgaySinh DATE,
    DiaChi NVARCHAR(255),
    TenCongTy NVARCHAR(255),
    DiaChiCongTy NVARCHAR(255),
    MaSoThue VARCHAR(20),
    NguoiDaiDienPhapLuat NVARCHAR(100)
);
GO

-- Bảng Loại Sản Phẩm
CREATE TABLE LoaiSanPham (
    LoaiID INT PRIMARY KEY IDENTITY(1,1),
    TenLoai NVARCHAR(100) NOT NULL UNIQUE
);
GO

-- Bảng Sản Phẩm
CREATE TABLE SanPham (
    SanPhamID INT PRIMARY KEY IDENTITY(1,1),
    TenSanPham NVARCHAR(150) NOT NULL,
    LoaiID INT,
    DonGia DECIMAL(18, 0) NOT NULL,
    SoLuongTonKho INT DEFAULT 0,
    MoTa NVARCHAR(500),
    FOREIGN KEY (LoaiID) REFERENCES LoaiSanPham(LoaiID)
);
GO

-- Bảng Voucher
CREATE TABLE Voucher (
    VoucherID INT PRIMARY KEY IDENTITY(1,1),
    MaVoucher VARCHAR(50) NOT NULL UNIQUE,
    MoTa NVARCHAR(255),
    LoaiGiamGia NVARCHAR(20),
    GiaTriGiam DECIMAL(18, 0) NOT NULL,
    DonHangToiThieu DECIMAL(18, 0) DEFAULT 0,
    NgayBatDau DATE,
    NgayKetThuc DATE
);
GO

-- Bảng Hóa Đơn
CREATE TABLE HoaDon (
    HoaDonID INT PRIMARY KEY IDENTITY(1,1),
    KhachHangID INT,
    NguoiDungID INT,
    NgayTao DATETIME DEFAULT GETDATE(),
    VoucherID INT NULL,
    TongTienGoc DECIMAL(18, 0),
    SoTienGiam DECIMAL(18, 0) DEFAULT 0,
    ThanhTien AS (TongTienGoc - SoTienGiam),
    TrangThai NVARCHAR(50) DEFAULT N'Hoàn thành',
    TrangThaiThanhToan NVARCHAR(50) DEFAULT N'Chưa thanh toán',
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID),
    FOREIGN KEY (NguoiDungID) REFERENCES NguoiDung(NguoiDungID),
    FOREIGN KEY (VoucherID) REFERENCES Voucher(VoucherID)
);
GO

-- Bảng Chi Tiết Hóa Đơn
CREATE TABLE ChiTietHoaDon (
    ChiTietID INT PRIMARY KEY IDENTITY(1,1),
    HoaDonID INT,
    SanPhamID INT,
    SoLuong INT NOT NULL,
    DonGiaTaiThoiDiemMua DECIMAL(18, 0) NOT NULL,
    ThanhTien AS (SoLuong * DonGiaTaiThoiDiemMua),
    FOREIGN KEY (HoaDonID) REFERENCES HoaDon(HoaDonID),
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(SanPhamID)
);
GO

-- Bảng Mã Check-in
CREATE TABLE MaCheckin (
    CheckinID INT PRIMARY KEY IDENTITY(1,1),
    MaCode VARCHAR(20) NOT NULL UNIQUE,
    ChiTietHoaDonID INT UNIQUE,
    KhachHangID INT,
    ThoiGianCheckin DATETIME NULL,
    ThoiGianCheckout DATETIME NULL,
    ThoiHanSuDung DATETIME NOT NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Chưa sử dụng',
    FOREIGN KEY (ChiTietHoaDonID) REFERENCES ChiTietHoaDon(ChiTietID),
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID)
);
GO

-- Bảng Lịch Sử Hoạt Động
CREATE TABLE LichSuHoatDong (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    HoaDonID INT,
    NguoiDungID INT,
    HanhDong NVARCHAR(50),
    ThoiGian DATETIME DEFAULT GETDATE(),
    NoiDungThayDoi NVARCHAR(MAX)
);
GO

-- Bảng Phương Thức Thanh Toán
CREATE TABLE PhuongThucThanhToan (
    PhuongThucID INT PRIMARY KEY IDENTITY(1,1),
    TenPhuongThuc NVARCHAR(100) NOT NULL UNIQUE,
    IsDigital BIT DEFAULT 0
);
GO

-- Bảng Giao Dịch Thanh Toán
CREATE TABLE ThanhToan (
    ThanhToanID INT PRIMARY KEY IDENTITY(1,1),
    HoaDonID INT NOT NULL,
    PhuongThucID INT NOT NULL,
    SoTien DECIMAL(18, 0) NOT NULL,
    NgayThanhToan DATETIME DEFAULT GETDATE(),
    MaGiaoDich VARCHAR(100) NULL,
    GhiChu NVARCHAR(255) NULL,
    FOREIGN KEY (HoaDonID) REFERENCES HoaDon(HoaDonID),
    FOREIGN KEY (PhuongThucID) REFERENCES PhuongThucThanhToan(PhuongThucID)
);
GO

-- ===========================
-- CHÈN DỮ LIỆU MẪU
-- ===========================

-- Vai Trò
INSERT INTO VaiTro (TenVaiTro) VALUES (N'Nhân viên'), (N'Quản lý'), (N'Kế toán trưởng');
GO

-- Người Dùng
INSERT INTO NguoiDung (HoTen, NgaySinh, DiaChi, TenDangNhap, MatKhau, VaiTroID) VALUES
(N'Nguyễn Văn Hiệp', '1990-05-20', N'Quận 1, TPHCM', 'HiepJAQL00078', 'Hiep@2025', 2),
(N'Trần Thị Bích Loan', '1992-08-15', N'Thành phố Thủ Đức', 'LoanJAQL00079', 'Loan@2025', 2),
(N'Lê Thị Mai', '1988-12-01', N'Quận 3, TPHCM', 'MaiJAKT00001', 'Mai@2025', 3),
(N'Trần Minh Hoàng', '2003-04-10', N'Gò Vấp, TPHCM', 'HoangJAGV0001', 'Hoang@2025', 1),
(N'Phạm Thị Yến', '2004-07-22', N'Bình Thạnh, TPHCM', 'YenJAGV0002', 'Yen@2025', 1),
(N'Lý Văn Dũng', '2002-11-05', N'Quận 12, TPHCM', 'DungJAGV0003', 'Dung@2025', 1),
(N'Đỗ Huyền Anh', '2005-01-30', N'Tân Bình, TPHCM', 'AnhJAGV0004', 'Anh@2025', 1),
(N'Võ Thành Trung', '2003-09-18', N'Phú Nhuận, TPHCM', 'TrungJAGV0005', 'Trung@2025', 1);
GO

-- Loại Sản Phẩm và Sản Phẩm
INSERT INTO LoaiSanPham (TenLoai) VALUES (N'Vé vui chơi'), (N'Vớ'), (N'Đồ uống');
GO
INSERT INTO SanPham (TenSanPham, LoaiID, DonGia, SoLuongTonKho) VALUES
(N'Vé người lớn (Trong tuần)', 1, 140000, -1),
(N'Vé trẻ em (Trong tuần)', 1, 98000, -1),
(N'Combo Sinh viên (Vé + Vớ)', 1, 1000, -1),
(N'Vé người lớn (Cuối tuần)', 1, 180000, -1),
(N'Vé trẻ em (Cuối tuần)', 1, 126000, -1),
(N'Vé Sự Kiện Halloween', 1, 250000, 100),
(N'Vớ bám bạt thường', 2, 29000, 500),
(N'Vớ Giáng Sinh', 2, 29000, 200),
(N'Vớ Summer', 2, 29000, 150),
(N'Vớ Sinh nhật', 2, 29000, 150),
(N'Trà Đào Cam Sả', 3, 45000, 100),
(N'Trà Vải', 3, 42000, 100),
(N'Trà Chanh', 3, 30000, 100),
(N'Pocari Sweat', 3, 20000, 200),
(N'Sting Dâu', 3, 15000, 200),
(N'Red Bull', 3, 20000, 200),
(N'Coca-Cola', 3, 15000, 300),
(N'7 Up', 3, 15000, 300),
(N'Pepsi', 3, 15000, 300),
(N'Olong Tea Plus', 3, 18000, 200),
(N'Trà xanh không độ', 3, 18000, 200),
(N'Nước suối Aquafina 500ml', 3, 10000, 500);
GO

-- Voucher
INSERT INTO Voucher (MaVoucher, MoTa, LoaiGiamGia, GiaTriGiam, DonHangToiThieu, NgayBatDau, NgayKetThuc) VALUES
('GIAM50K', N'Giảm 50.000 VNĐ cho đơn hàng từ 250.000 VNĐ', 'Fixed', 50000, 250000, '2025-01-01', '2025-12-31'),
('SINHVIEN10', N'Giảm 10% cho sinh viên', 'Percentage', 10, 0, '2025-01-01', '2025-12-31'),
('QUOCKHANH', N'Mừng Quốc Khánh 2/9, giảm 20% tổng hóa đơn', 'Percentage', 20, 0, '2025-09-01', '2025-09-03'),
('HALLOWEEN', N'Lễ Halloween giảm 30.000đ cho đơn >200k', 'Fixed', 30000, 200000, '2025-10-28', '2025-10-31');
GO

-- Phương Thức Thanh Toán
INSERT INTO PhuongThucThanhToan (TenPhuongThuc, IsDigital) VALUES
(N'Tiền mặt', 0), (N'Chuyển khoản ngân hàng', 1), (N'Thẻ tín dụng (Credit Card)', 1), (N'Ví MoMo', 1), (N'Ví ZaloPay', 1);
GO


-- ===========================
-- STORED PROCEDURES (CÁC THỦ TỤC HỖ TRỢ)
-- ===========================

-- 1. Tìm hoặc tạo khách hàng
CREATE PROCEDURE sp_TimHoacTaoKhachHang
    @SoDienThoai VARCHAR(15),
    @Ho NVARCHAR(50),
    @TenDem NVARCHAR(50),
    @Ten NVARCHAR(50),
    @NgaySinh DATE = NULL,
    @DiaChi NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @ID INT;
    SELECT @ID = KhachHangID FROM KhachHang WHERE SoDienThoai = @SoDienThoai;
    IF @ID IS NULL
    BEGIN
        INSERT INTO KhachHang (SoDienThoai, Ho, TenDem, Ten, NgaySinh, DiaChi)
        VALUES (@SoDienThoai, @Ho, @TenDem, @Ten, @NgaySinh, @DiaChi);
        SET @ID = SCOPE_IDENTITY();
    END
    SELECT * FROM KhachHang WHERE KhachHangID = @ID;
END;
GO

-- 2. Đăng nhập
CREATE PROCEDURE sp_DangNhapNguoiDung
    @TenDangNhap VARCHAR(50),
    @MatKhau VARCHAR(255)
AS
BEGIN
    SELECT NguoiDungID, HoTen, VaiTroID
    FROM NguoiDung
    WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau;
END;
GO

-- 3. Ghi nhận thanh toán
CREATE PROCEDURE sp_GhiNhanThanhToan
    @HoaDonID INT,
    @PhuongThucID INT,
    @SoTien DECIMAL(18, 0),
    @MaGiaoDich VARCHAR(100) = NULL,
    @GhiChu NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        INSERT INTO ThanhToan (HoaDonID, PhuongThucID, SoTien, MaGiaoDich, GhiChu)
        VALUES (@HoaDonID, @PhuongThucID, @SoTien, @MaGiaoDich, @GhiChu);

        DECLARE @TongDaThanhToan DECIMAL(18, 0);
        DECLARE @TongTienPhaiTra DECIMAL(18, 0);

        SELECT @TongDaThanhToan = SUM(SoTien) FROM ThanhToan WHERE HoaDonID = @HoaDonID;
        SELECT @TongTienPhaiTra = (TongTienGoc - SoTienGiam) FROM HoaDon WHERE HoaDonID = @HoaDonID;

        IF @TongDaThanhToan >= @TongTienPhaiTra
            UPDATE HoaDon SET TrangThaiThanhToan = N'Đã thanh toán' WHERE HoaDonID = @HoaDonID;
        ELSE IF @TongDaThanhToan > 0
            UPDATE HoaDon SET TrangThaiThanhToan = N'Thanh toán một phần' WHERE HoaDonID = @HoaDonID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

PRINT 'Tạo Database JumpArenaDB và các đối tượng thành công!';
GO