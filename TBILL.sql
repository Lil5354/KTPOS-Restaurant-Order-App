USE MASTER
GO
DROP DATABASE IF EXISTS TBILL
CREATE DATABASE TBILL
GO

USE TBILL
GO
CREATE TABLE [TABLE] (
	ID int identity primary key,
	fname NVARCHAR(50),
	status int not null default 1 --1: AVAILABLE/ 0:UNAVAILABLE
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
INSERT INTO [TABLE] (fname, status)
VALUES 
('Table 1', 1), -- Table 1 is available
('Table 2', 1), -- Table 2 is available
('Table 3', 0), -- Table 3 is unavailable
('Table 4', 1), -- Table 4 is available
('Table 5', 1), -- Table 5 is available
('Table 6', 0), -- Table 6 is unavailable
('Table 7', 1), -- Table 7 is available
('Table 8', 0); -- Table 8 is unavailable

INSERT INTO Bill (Datepayment, idTable, status)
VALUES 
(GETDATE(), 1, 0), -- Bill for Table 1, unpaid
(GETDATE(), 3, 1), -- Bill for Table 3, paid
(GETDATE(), 2, 1), -- Bill for Table 2, paid
(GETDATE(), 1, 1), -- Bill for Table 1, paid
(GETDATE(), 4, 1), -- Bill for Table 4, paid
(GETDATE(), 5, 0), -- Bill for Table 5, unpaid
(GETDATE(), 6, 0), -- Bill for Table 6, unpaid
(GETDATE(), 7, 1), -- Bill for Table 7, paid
(GETDATE(), 8, 1), -- Bill for Table 8, paid
(GETDATE(), 5, 1); -- Bill for Table 5, paid