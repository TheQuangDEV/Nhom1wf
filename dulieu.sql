CREATE DATABASE QLCHMN

USE QLCHMN

select *from dangnhap


CREATE TABLE KhachHang
(
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    TenKhachHang NVARCHAR(100),
    DienThoai NVARCHAR(15),
    DiaChi NVARCHAR(200)
);


CREATE TABLE SanPham
(
    MaSanPham INT IDENTITY(1,1) PRIMARY KEY,
    TenSanPham NVARCHAR(100),
    DonGia FLOAT
);


CREATE TABLE HoaDon
(
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaKhachHang INT,
    NgayLap DATE,
    TongTien FLOAT,

    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);


CREATE TABLE ChiTietHoaDon
(
    MaChiTiet INT IDENTITY(1,1) PRIMARY KEY,
    MaHoaDon INT,
    MaSanPham INT,
    SoLuong INT,
    DonGia FLOAT,
    ThanhTien FLOAT,

    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);

INSERT INTO SanPham (TenSanPham, DonGia)
VALUES 
(N'Táo', 20000),
(N'Cam', 15000),
(N'Chuối', 10000),
(N'Dưa hấu', 30000);


select * from SanPham

-- Tạo bảng Nhân Viên
CREATE TABLE NhanVien
(
    -- Đặt Tài khoản làm Khóa chính để đảm bảo không bao giờ bị trùng lặp
    TaiKhoan VARCHAR(50) PRIMARY KEY, 
    TenNhanVien NVARCHAR(100),
    NgaySinh DATE,
    DiaChi NVARCHAR(200),
    GioiTinh NVARCHAR(10),
    MatKhau VARCHAR(50),
    ChucVu NVARCHAR(50),
    TrangThai NVARCHAR(50)
);

-- Thêm thử 1 tài khoản Quản lý mẫu để test
INSERT INTO NhanVien (TaiKhoan, TenNhanVien, NgaySinh, DiaChi, GioiTinh, MatKhau, ChucVu, TrangThai)
VALUES 
('admin', N'Thế Anh', '2000-10-03', N'Bà Rịa - Vũng Tàu', N'Nam', '123456', N'Quản lý', N'Đang làm');

-- Kiểm tra xem bảng đã có dữ liệu chưa
SELECT * FROM NhanVien;