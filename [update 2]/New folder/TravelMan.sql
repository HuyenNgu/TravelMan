--CREATE DATABASE TRAVELMAN
USE TRAVELMAN
GO
drop table thongtinkhachhang
--drop table chonve
CREATE TABLE THONGTINKHACHHANG(
	[Số Thứ Tự] int primary key IDENTITY(1,1) NOT NULL,
	[ID] nvarchar(50) NOT NULL,
	[Họ] nvarchar(50)NOT NULL,
	[Tên đệm] nvarchar(50)NOT NULL,
	[Tên] nvarchar(50)NOT NULL,
	[Địa chỉ] nvarchar(50)NOT NULL,
	[Mã vùng] int,
	[Số Điện Thoại] varchar(50),
	[Khởi hành] nvarchar(50) NOT NULL,
	[Nơi đến] nvarchar(50) NOT NULL,
	[Phương Tiện] nvarchar(50) NOT NULL,
	[Loại vé] nvarchar(50) NOT NULL,
	[Người sử dụng] nvarchar(50) NOT NULL,
	[Số lượng] INT,
	[Tiền] INT
)

--drop table GIATIEN
--CREATE TABLE GIATIEN(
--	[Số Thứ Tự] int primary key IDENTITY(1,1) NOT NULL,
--	[Quận 1] INT,
--	[Quận 2] INT,
--	[Quận 3] INT,
--	[Quận 4] INT,
--	[Quận 5] INT,
--	[Quận 6]INT,
--	[Quận 7] INT,
--	[Quận 8] INT,
--	[Quận 9] INT,
--	[Quận 10] INT,
--	[Quận 11] INT,
--	[Quận 12] INT,
--	[Quận khác] INT,
--	[Xe máy] INT,
--	[Xe hơi] INT,
--	[Tàu hỏa] INT,
--	[Tiết kiệm] INT,
--	[Thường] INT,
--	[Thương gia] INT,
--	[Người lớn] INT,
--	[Trẻ em] INT
--)
