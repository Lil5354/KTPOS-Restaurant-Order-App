USE MASTER
GO
DROP DATABASE IF EXISTS KTPOS
CREATE DATABASE KTPOS
GO

USE KTPOS	
GO
CREATE TABLE ACCOUNT (
	Email       NVARCHAR(50) primary key,
	FullName    NVARCHAR(50) NOT NULL,
    [Password]  NVARCHAR(50) NOT NULL CHECK(LEN([Password]) >= 6),
	ExpY			TINYINT	NULL,
    [Role]      NVARCHAR(20) CHECK([Role] IN ('Staff', 'Manager','Chef','Customer'))
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
    (N'Dương Thị Thanh Thảo',		'thaott26@gmail.com',		'pupu123',		NULL,   'Manager'),
    (N'Hoàng Văn Thiên',				'hvt2003@gmail.com',			'chillguy1',		1,		'Staff'),
    (N'Lê Thiện Nhân',				'nhanle@gmail.com',			'cuchuoi2Xu',   1,		'Staff'),
    (N'Nguyễn Thành Đạt',			'dathphong@gmail.com',		'hoangtusitinh',NULL,	'Staff');

INSERT INTO [TABLE] (fname, status)
VALUES 
('Table 1', 1),
('Table 2', 1),
('Table 3', 0); -- Unavailable table

-- Insert data into [F&BCATEGORY]
INSERT INTO [F&BCATEGORY] (fname)
VALUES 
('Drinks'),
('Appetizers'),
('Main Course'),
('Desserts');

-- Insert data into ITEM
INSERT INTO ITEM (fname, idCategory, price)
VALUES 
('Coke', 1, 1.5),
('Beer', 1, 3.0),
('Spring Rolls', 2, 5.0),
('Steak', 3, 20.0),
('Ice Cream', 4, 4.0);

-- Insert data into Bill
INSERT INTO Bill (Datepayment, idTable, status)
VALUES 
(GETDATE(), 1, 0), -- Unpaid bill
(GETDATE(), 2, 1); -- Paid bill

-- Insert data into BILLINF
INSERT INTO BILLINF (idBill, idFD, count)
VALUES 
(1, 1, 2), -- 2 Cokes on the first bill
(1, 3, 1), -- 1 Spring Roll on the first bill
(2, 4, 1), -- 1 Steak on the second bill
(2, 5, 3); -- 3 Ice Creams on the second bill

GO
SELECT * FROM ACCOUNT 
