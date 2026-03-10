SELECT * FROM SanPham;

ALTER TABLE SanPham
ADD LoaiHang NVARCHAR(100) NULL,
    SoLuongTon INT NOT NULL DEFAULT 0;

UPDATE SanPham SET LoaiHang = N'Trái cây' WHERE TenSanPham IN (N'Táo', N'Cam', N'Chuối', N'Dưa hấu');

ALTER TABLE SanPham
ADD MaSPHienThi NVARCHAR(20) NULL;

UPDATE SanPham SET MaSPHienThi = 'SP01' WHERE MaSanPham = 1;
UPDATE SanPham SET MaSPHienThi = 'SP02' WHERE MaSanPham = 2;
UPDATE SanPham SET MaSPHienThi = 'SP03' WHERE MaSanPham = 3;
UPDATE SanPham SET MaSPHienThi = 'SP04' WHERE MaSanPham = 4;