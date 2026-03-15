CREATE DATABASE QLSinhVien
GO

USE QLSinhVien
GO

CREATE TABLE SinhVien
(
    ID INT IDENTITY(1,1) PRIMARY KEY,   -- tự tăng
    MaSV CHAR(7) UNIQUE,                -- ví dụ 0008368
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    GioiTinh NVARCHAR(5),
    Lop VARCHAR(10)
)

INSERT INTO SinhVien(MaSV,HoTen,NgaySinh,GioiTinh,Lop)
VALUES
('0008368',N'Nguyễn Minh Khang','2003-05-14',N'Nam','68PM3'),
('0004721',N'Trần Gia Huy','2003-11-02',N'Nam','68PM1'),
('0001954',N'Lê Khánh Linh','2004-01-22',N'Nữ','68PM2'),
('0006632',N'Phạm Hoàng Anh','2003-09-09',N'Nam','68PM3'),
('0002845',N'Đặng Thuỳ Dương','2004-04-17',N'Nữ','68PM1')