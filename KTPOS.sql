USE MASTER
GO
ALTER DATABASE KTPOS SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
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
	status int not null default 1, --1: AVAILABLE/ 0:UNAVAILABLE
	Visible		int not null default 1 --0: FALSE 1: TRUE 
);
GO
CREATE TABLE [F&BCATEGORY](
	ID INT IDENTITY PRIMARY KEY,
	fname nvarchar(50),
	Visible		int not null default 1 --0: FALSE 1: TRUE 
);
GO
CREATE TABLE ITEM(
	ID INT IDENTITY PRIMARY KEY,
	fname NVARCHAR(50) NOT NULL,
	idCategory INT NOT NULL,
	price float not null,
	Visible		int not null default 1 --0: FALSE 1: TRUE 

	FOREIGN KEY (idCategory) REFERENCES dbo.[F&BCATEGORY](ID)
);
GO
CREATE TABLE Bill(
	ID INT IDENTITY PRIMARY KEY,
	Datepayment DATE NOT NULL default getdate(),
	idTable		int not null,
	status int not null default 0, --1: Have pay 0: Not pay yet

	FOREIGN KEY (idTable) REFERENCES dbo.[TABLE](ID)
);
GO 
CREATE TABLE BILLINF(
	ID INT IDENTITY PRIMARY KEY,
	idBill int not null,
	idFD int not null,
	count int not null default 0,

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFD)	 REFERENCES dbo.ITEM(id)
);
INSERT INTO ACCOUNT (FullName, Email, [Password],	ExpY,		[Role]		 ) 
VALUES
    (N'Võ Đăng Khoa',				'khoavd2809@gmail.com',     'khoavo123',		2,		'Manager'),
    (N'Dương Thị Thanh Thảo',		'thaott26@gmail.com',		'pupu123',			0,		'Manager'),
    (N'Hoàng Văn Thiên',			'hvt2003@gmail.com',		'chillguy1',		1,		'Staff'),
    (N'Lê Thiện Nhân',				'nhanle@gmail.com',			'cuchuoi2xu',		1,		'Staff'),
	(N'Từ Tuấn Sang',				'tsang@gmail.com',			'tsang123',			1,		'Chef'),
    (N'Nguyễn Thành Đạt',			'dathphong@gmail.com',		'hoangtusitinh',	0,		'Staff'),
	(N'Nguyễn Giang Gia Huy',		'huybo@gmail.com',			'huybo123',			0,		'Chef');


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
(1, 1, 2), -- 2 Coffee on the first bill
(1, 3, 1), -- 1 Fried Rice on the first bill
(2, 4, 1), -- 1 Pizza on the second bill
(2, 5, 3); -- 3 Cheesecake on the second bill


SELECT fb.fname [TYPE], i.fname AS [NAME], price[PRICE] FROM ITEM i JOIN [F&BCATEGORY] fb ON idCategory = fb.ID  WHERE i.Visible = 1 Order by [Type] ASC

use KTPOS select * from BILLINF;