﻿USE MASTER
GO
DROP DATABASE IF EXISTS KTPOS
GO
CREATE DATABASE KTPOS
GO
USE KTPOS	
GO
CREATE TABLE ACCOUNT (
	Email       NVARCHAR(50) primary key,
	FullName    NVARCHAR(50) NOT NULL,
    [Password]  NVARCHAR(50) NOT NULL CHECK(LEN([Password]) >= 6) DEFAULT 'ktpos123',
	ExpY		TINYINT		  NOT NULL DEFAULT 0,
    [Role]      NVARCHAR(20) CHECK([Role] IN ('Staff', 'Manager','Chef','Customer')),
	Visible		int not null default 1 --0: FALSE 1: TRUE 
);
GO
CREATE TABLE [TABLE] (
	ID int identity primary key,
	fname NVARCHAR(50),
	status int not null default 1 --1: AVAILABLE/ 0:UNAVAILABLE
);
GO
CREATE TABLE [F&BCATEGORY](
	ID INT IDENTITY PRIMARY KEY,
	fname nvarchar(50)
);
GO
CREATE TABLE ITEM(
	ID INT IDENTITY PRIMARY KEY,
	fname NVARCHAR(50) NOT NULL,
	idCategory INT NOT NULL,
	price float not null,

	FOREIGN KEY (idCategory) REFERENCES dbo.[F&BCATEGORY](ID)
);
GO
CREATE TABLE Bill(
	ID INT IDENTITY PRIMARY KEY,
	Datepayment DATE NOT NULL default getdate(),
	idTable		int not null,
	status int not null default 0 --1: Have pay 0: Not pay yet

	FOREIGN KEY (idTable) REFERENCES dbo.[TABLE](ID)
);
GO 
CREATE TABLE BILLINF(
	ID INT IDENTITY PRIMARY KEY,
	idBill int not null,
	idFD int not null,
	count int not null default 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFD)	 REFERENCES dbo.ITEM(id)
);
INSERT INTO ACCOUNT (FullName, Email, [Password],	ExpY,		[Role]		 ) 
VALUES
    (N'Võ Đăng Khoa',				'khoavd2809@gmail.com',     'khoavo123',		2,		'Manager'),
    (N'Dương Thị Thanh Thảo',		'thaott26@gmail.com',		'pupu123',			0,	'Manager'),
    (N'Hoàng Văn Thiên',			'hvt2003@gmail.com',		'chillguy1',		1,		'Staff'),
    (N'Lê Thiện Nhân',				'nhanle@gmail.com',			'cuchuoi2xu',		1,		'Staff'),
	(N'Từ Tuấn Sang',				'tsang@gmail.com',			'tsang123',			1,		'Chef'),
    (N'Nguyễn Thành Đạt',			'dathphong@gmail.com',		'hoangtusitinh',	0,	'Staff');

INSERT INTO [TABLE] (fname, status)
VALUES 
('Table 1', 0),
('Table 2', 0),
('Table 3', 0),
('Table 4', 0),
('Table 5', 1),
('Table 6', 0),
('Table 7', 0),
('Table 8', 0),
('Table 9', 0), --Available table
('Table 10', 1); -- Unavailable table

-- Insert data into [F&BCATEGORY]
INSERT INTO [F&BCATEGORY] (fname)
VALUES
('Food'),
('Drinks'),
('Appetizers'),
('Main Course'),
('Desserts');

-- Insert data into ITEM
INSERT INTO ITEM (fname, idCategory, price)
VALUES 
('Coffee', 2, 2.0),
('Tea', 2, 1.0),
('Fried Rice', 1, 10.0),
('Pizza', 1, 15.0),
('Cheesecake', 4, 6.0),
('Coke', 2, 1.5),
('Beer', 2, 3.0),
('Spring Rolls', 1, 5.0),
('Steak', 1, 20.0),
('Ice Cream', 4, 4.0);

-- Insert data into Bill
INSERT INTO Bill (Datepayment, idTable, status)
VALUES 
(GETDATE(), 1, 0),
(GETDATE(), 2, 0),
(GETDATE(), 3, 0),
(GETDATE(), 4, 0),
(GETDATE(), 6, 1),
(GETDATE(), 7, 0),
(GETDATE(), 8, 0), -- Unpaid bill
(GETDATE(), 9, 0); -- Paid bill

-- Insert data into BILLINF
INSERT INTO BILLINF (idBill, idFD, count)
VALUES 
(1, 1, 2), -- 2 Cokes on the first bill
(1, 3, 1), -- 1 Spring Roll on the first bill
(2, 4, 1), -- 1 Steak on the second bill
(2, 5, 3), -- 3 Ice Creams on the second bill
(3, 1, 4),
(4, 2, 2),
(4, 3, 2),
(4, 1, 3),
(4, 4, 5),
(5, 1, 5),
(6, 2, 10),
(7, 3, 5),
(7, 4, 5),
(7, 2, 2),
(8, 4, 2);

select * from ACCOUNT
select * from [TABLE]
select * from [F&BCATEGORY]
select * from ITEM
select * from Bill
select * from BILLINF