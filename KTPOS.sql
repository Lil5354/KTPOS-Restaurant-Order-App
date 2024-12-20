﻿USE MASTER
GO
DROP DATABASE IF EXISTS KTPOS
GO
CREATE DATABASE KTPOS
GO
USE KTPOS	
GO
CREATE TABLE ACCOUNT (
	EMAIL       NVARCHAR(50) PRIMARY KEY,
	FULLNAME    NVARCHAR(50) NOT NULL,
    [PASSWORD]  NVARCHAR(50) NOT NULL CHECK(LEN([Password]) >= 6) DEFAULT 'ktpos123',
	EXPY		TINYINT		  NOT NULL DEFAULT 0,
    [ROLE]      NVARCHAR(20) CHECK([Role] IN ('Staff', 'Manager','Chef')),
	VISIBLE		int not null default 1 --0: FALSE 1: TRUE 
);
GO
CREATE TABLE [TABLE] (
	ID			INT IDENTITY PRIMARY KEY,
	FNAME		NVARCHAR(50) UNIQUE,
	STATUS		INT NOT NULL DEFAULT 1, --1: AVAILABLE/ 0:UNAVAILABLE
	VISIBLE		INT NOT NULL DEFAULT 1 --0: FALSE 1: TRUE 
);
GO
CREATE TABLE [F&BCATEGORY](
	ID			INT IDENTITY PRIMARY KEY,
	FNAME		NVARCHAR(50) UNIQUE NOT NULL,
	VISIBLE		INT NOT NULL DEFAULT 1 --0: FALSE 1: TRUE 
);
GO
CREATE TABLE ITEM(
	ID			INT IDENTITY PRIMARY KEY,
	FNAME		NVARCHAR(50) NOT NULL,
	IDCATEGORY	INT NOT NULL,
	PRICE		FLOAT NOT NULL,
	VISIBLE		INT NOT NULL DEFAULT 1, --0: FALSE 1: TRUE 

	CONSTRAINT UQ_ITEM_NAME_CATEGORY UNIQUE (FNAME, IDCATEGORY),
	FOREIGN KEY (IDCATEGORY) REFERENCES DBO.[F&BCATEGORY](ID)
);
GO
CREATE TABLE BILL(
	ID			INT IDENTITY PRIMARY KEY,
	DATEPAYMENT DATE NOT NULL DEFAULT GETDATE(),
	IDTABLE		INT NOT NULL,
	STATUS		INT NOT NULL DEFAULT 0, --1: HAVE PAY 0: NOT PAY YET

	FOREIGN KEY (IDTABLE) REFERENCES DBO.[TABLE](ID)
);
GO 
CREATE TABLE BILLINF(
	ID		INT IDENTITY PRIMARY KEY,
	IDBILL	INT NOT NULL,
	IDFD	INT NOT NULL,
	COUNT	INT NOT NULL DEFAULT 0,

	FOREIGN KEY (IDBILL) REFERENCES DBO.BILL(ID),
	FOREIGN KEY (IDFD)	 REFERENCES DBO.ITEM(ID)
);

GO
INSERT INTO ACCOUNT (FULLNAME, EMAIL, [PASSWORD],	EXPY,		[ROLE]		 ) 
VALUES
    (N'Võ Đăng Khoa',				'khoavd2809@gmail.com',     'khoavo123',		2,		'Manager'),
    (N'Dương Thị Thanh Thảo',		'thaott26@gmail.com',		'pupu123',			0,		'Manager'),
    (N'Hoàng Văn Thiên',			'hvt2003@gmail.com',		'chillguy1',		1,		'Staff'),
    (N'Lê Thiện Nhân',				'nhanle@gmail.com',			'cuchuoi2xu',		1,		'Staff'),
	(N'Từ Tuấn Sang',				'tsang@gmail.com',			'tsang123',			1,		'Chef'),
    (N'Nguyễn Thành Đạt',			'dathphong@gmail.com',		'hoangtusitinh',	0,		'Staff'),
	(N'Nguyễn Giang Gia Huy',		'huybo@gmail.com',			'huybo123',			0,		'Chef');
GO
INSERT INTO [TABLE] (FNAME, STATUS)
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
GO
-- Insert data into [F&BCATEGORY]
INSERT INTO [F&BCATEGORY] (FNAME)
VALUES
('Food'),
('Drinks'),
('Best Sellers'),
('New Arrivals'),
('Featured Dishes'),
('Combo Deals'),
('Most Loved');
GO
-- Insert data into ITEM
INSERT INTO ITEM (FNAME, IDCATEGORY, PRICE)
VALUES 
('Coffee', 2, 2.0), 
('Tea', 2, 1.0), 
('Fried Rice', 1, 10.0), 
('Pizza', 1, 15.0), 
('Cheesecake', 1, 6.0), 
('Coke', 2, 1.5), 
('Beer', 2, 3.0), 
('Spring Rolls', 1, 5.0), 
('Steak', 1, 20.0),

('Coffee', 3, 2.0),
('Tea', 4, 1.0),
('Fried Rice', 5, 10.0),
('Pizza', 6, 15.0),
('Cheesecake', 7, 6.0);
GO
-- Insert data into Bill
INSERT INTO BILL (DATEPAYMENT, IDTABLE, STATUS)
VALUES 
('2024-12-08', 1, 0),
('2024-12-12', 2, 0),
(GETDATE(), 3, 0),
(GETDATE(), 4, 0),
(GETDATE(), 6, 1),
('2024-12-07', 7, 0),
('2024-12-01', 8, 0), -- Unpaid bill
('2024-12-05', 9, 0); -- Paid bill
GO
-- Insert data into BILLINF
INSERT INTO BILLINF (IDBILL, IDFD, COUNT)
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
GO
SELECT B.ID AS [ID BILL], T.FNAME AS [TABLE NAME], SUM(I.PRICE * BI.COUNT) AS [TOTAL PRICE], B.DATEPAYMENT AS [DATE CHECKOUT] FROM BILLINF BI
JOIN BILL B ON BI.IDBILL = B.ID JOIN [TABLE] T ON B.IDTABLE = T.ID JOIN ITEM I ON BI.IDFD = I.ID GROUP BY B.ID, T.FNAME, B.DATEPAYMENT ORDER BY B.ID;

SELECT B.ID AS [ID BILL], 
       T.FNAME AS [TABLE NAME], 
       SUM(I.PRICE * BI.COUNT) AS [TOTAL PRICE], 
       B.DATEPAYMENT AS [DATE CHECKOUT] 
FROM BILLINF BI 
JOIN BILL B ON BI.IDBILL = B.ID 
JOIN [TABLE] T ON B.IDTABLE = T.ID 
JOIN ITEM I ON BI.IDFD = I.ID 
WHERE B.DATEPAYMENT BETWEEN '2024-12-01' AND '2024-12-5'
GROUP BY B.ID, T.FNAME, B.DATEPAYMENT 
ORDER BY B.ID;
SELECT * FROM ACCOUNT

select*from BILLINF

GO --LỆNH KHI ADD BÀN MỚI TỰ INSERT THEO SỐ BÀN ĐÃ CÓ
CREATE PROCEDURE INSERTNEWTABLE
AS
BEGIN
    DECLARE @MAXID INT;
    DECLARE @TABLENAME NVARCHAR(50);

    -- LẤY ID LỚN NHẤT HIỆN CÓ TRONG BẢNG TABLE
    SELECT @MAXID = ISNULL(MAX(ID), 0) FROM [TABLE];

    -- TẠO TÊN BÀN MỚI
    SET @TABLENAME = CONCAT('TABLE ', @MAXID + 1);

    -- THÊM BÀN MỚI VÀO TABLE
    INSERT INTO [TABLE] (FNAME, STATUS)
    VALUES (@TABLENAME, 1); -- STATUS MẶC ĐỊNH LÀ AVAILABLE
END;