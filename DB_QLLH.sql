CREATE DATABASE QLLH
GO

USE QLLH
GO

CREATE TABLE LopHoc
(
    MaLop VARCHAR(10) PRIMARY KEY,
    TenLop NVARCHAR(100),
    Khoa NVARCHAR(100),
    KhoaHoc VARCHAR(10)
)

INSERT INTO LopHoc VALUES
('68PM1', N'Lập trình phần mềm 1', N'Công nghệ thông tin', 'K68'),
('68PM2', N'Lập trình phần mềm 2', N'Công nghệ thông tin', 'K68'),
('67HT1', N'Hệ thống thông tin 1', N'Hệ thống thông tin', 'K67'),
('67MM1', N'Mạng máy tính 1', N'Mạng máy tính', 'K67'),
('66KT1', N'Kỹ thuật máy tính 1', N'Kỹ thuật máy tính', 'K66')