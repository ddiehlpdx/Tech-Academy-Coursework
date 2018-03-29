CREATE DATABASE db_library

USE db_library

CREATE TABLE lib_books (
	BookID INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	Title VARCHAR(100),
	Publisher VARCHAR(50)
);

CREATE TABLE lib_authors (
	BookID INT PRIMARY KEY NOT NULL,
	Author VARCHAR(50),
);

CREATE TABLE lib_publisher (
	PubName VARCHAR(30) PRIMARY KEY NOT NULL,
	PubAddress VARCHAR(100),
	PubPhone VARCHAR(10)
);

CREATE TABLE lib_loans (
	BookID INT NOT NULL,
	BranchID INT NOT NULL,
	CardNo INT NOT NULL,
	DateOut DATE NOT NULL,
	DueDate DATE NOT NULL
);

CREATE TABLE lib_copies (
	BookID INT NOT NULL,
	BranchID INT NOT NULL,
	NoOfCopies INT NOT NULL
);

CREATE TABLE lib_borrower (
	CardNo INT PRIMARY KEY NOT NULL IDENTITY(1000,1),
	BorrowerName VARCHAR(50) NOT NULL,
	BorrowerAddress VARCHAR(100) NOT NULL,
	BorrowerPhone VARCHAR(10) NOT NULL
);

CREATE TABLE lib_branch (
	BranchID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	BranchName VARCHAR(30) NOT NULL,
	BranchAddress VARCHAR(100) NOT NULL
);

INSERT INTO lib_books (Title, Publisher)
	VALUES ('The Lost Tribe', 'Books and Stuff'),
			('The Demon Hanuted World', 'Smart Press'),
			('The Elegant Universe', 'Smart Press'),
			('A Brief History of Time', 'Smart Press'),
			('Waking Up', 'Killin'' it Press'),
			('The End of Faith', 'Killin'' it Press'),
			('A Game of Thrones', 'Penguin'),
			('A Clash of Kings', 'Penguin'),
			('A Storm of Swords', 'Penguin'),
			('A Feast for Crows', 'Penguin'),
			('A Dance With Dragons', 'Penguin'),
			('Winds of Winter', 'Penguin'),
			('A Dream of Spring', 'Penguin'),
			('Fevre Dream', 'Penguin'),
			('The Cave', 'Porto'),
			('Blindness', 'Porto'),
			('The Once and Future King', 'Penguin'),
			('The Alphabet of Manliness', 'Maddox'),
			('Johnny Got His Gun', 'Depressing'),
			('Finnigans Wake', 'Confusing'),
			('Crime and Punishment', 'Angry'),
			('The Stand', 'King Books'),
			('Needful Things', 'King Books')

INSERT INTO lib_authors (BookID, Author)
	VALUES (1, 'Some Dude'),
			(2, 'Carl Sagan'),
			(3, 'Brian Greene'),
			(4, 'Stephen Hawking'),
			(5, 'Sam Harris'),
			(6, 'Sam Harris'),
			(7, 'George RR Martin'),
			(8, 'George RR Martin'),
			(9, 'George RR Martin'),
			(10, 'George RR Martin'),
			(11, 'George RR Martin'),
			(12, 'George RR Martin'),
			(13, 'George RR Martin'),
			(14, 'George RR Martin'),
			(15, 'Jose Saramago'),
			(16, 'Jose Saramago'),
			(17, 'T.H. White'),
			(18, 'Maddox'),
			(19, 'Dalton Trumbo'),
			(20, 'James Joyce'),
			(21, 'Fyodor Dostoyevsky'),
			(22, 'Stephen King'),
			(23, 'Stephen King')

INSERT INTO lib_publisher (PubName, PubAddress, PubPhone)
	VALUES ('Books and Stuff', '521 NW Book St, Book City, BS 99666', '5551234567'),
			('Smart Press', '666 SW Reason Ave, Book Town, BT 87123', '9997778888'),
			('Penguin', '1234 Arctic Ave, Glacier, NP 65456', '1234567890'),
			('Porto', '88915 Portugal St, Portugal, WR 22521', '9876543210'),
			('Maddox', '33 Nope St, Uh Uh, NO 75579', '5658987898'),
			('Depressing', '1 Lonely Ave, Downer, SH 11111', '0000000000'),
			('Confusing', '50 Nonlinear Way, Wherever, AN 64469', '9882223333'),
			('Angry', '9 Go To Hell Ln, Getout, FK 33221', '7411477891'),
			('King Books', '43 Maine Ave, Derry, MN 34567', '1112445657')

INSERT INTO lib_loans (BookID, BranchID, CardNo, DateOut, DueDate)
	VALUES (1, 1, 1000, '2018-01-07', '2018-01-21'),
			(2, 1, 1000, '2018-01-07', '2018-01-21'),
			(3, 1, 1000, '2018-01-07', '2018-01-21'),
			(4, 1, 1000, '2018-01-07', '2018-01-21'),
			(5, 1, 1000, '2018-01-07', '2018-01-21'),
			(2, 2, 1001, '2017-04-01', '2017-04-25'),
			(3, 2, 1001, '2017-04-01', '2017-04-25'),
			(4, 3, 1002, '2017-09-05', '2017-09-26'),
			(5, 4, 1003, '2017-12-30', '2018-01-20'),
			(6, 4, 1004, '2017-12-31', '2018-01-21'),
			(6, 5, 1005, '2018-01-01', '2018-01-26'),
			(7, 5, 1005, '2018-02-02', '2018-02-23'),
			(8, 5, 1005, '2018-02-02', '2018-02-23'),
			(9, 5, 1005, '2018-02-02', '2018-02-23'),
			(10, 5, 1005, '2018-02-04', '2018-02-26'),
			(10, 2, 1006, '2018-01-01', '2018-01-25'),
			(10, 1, 1007, '2018-01-12', '2018-02-24'),
			(11, 2, 1008, '2018-01-13', '2018-02-03'),
			(12, 2, 1009, '2018-02-05', '2018-02-26'),
			(12, 1, 1010, '2018-02-15', '2018-03-07'),
			(13, 4, 1009, '2018-02-22', '2018-03-18'),
			(11, 5, 1007, '2018-02-01', '2018-02-22'),
			(14, 1, 1004, '2018-02-03', '2018-02-24'),
			(15, 3, 1003, '2018-01-01', '2018-01-22'),
			(16, 3, 1004, '2018-01-02', '2018-01-23'),
			(17, 5, 1001, '2018-02-01', '2018-02-22'),
			(18, 3, 1001, '2018-01-03', '2018-01-24'),
			(19, 4, 1002, '2018-01-02', '2018-01-23'),
			(20, 1, 1004, '2018-02-01', '2018-02-25'),
			(21, 5, 1005, '2018-02-24', '2018-03-18'),
			(21, 3, 1000, '2018-01-15', '2018-02-25'),
			(1, 1, 1002, '2018-01-01', '2018-01-23'),
			(2, 1, 1004, '2017-05-01', '2017-05-22'),
			(4, 5, 1006, '2017-03-02', '2017-03-23'),
			(3, 2, 1001, '2017-01-05', '2017-01-25'),
			(12, 3, 1002, '2018-01-04', '2017-01-25'),
			(13, 4, 1003, '2018-02-01', '2018-02-22'),
			(11, 2, 1006, '2018-01-02', '2018-01-23'),
			(8, 5, 1009, '2017-12-01', '2017-12-22'),
			(9, 3, 1010, '2018-02-19', '2018-03-12'),
			(18, 4, 1000, '2018-01-04', '2018-01-25'),
			(20, 1, 1010, '2017-04-01', '2017-04-23'),
			(19, 4, 1009, '2018-02-05', '2018-02-26'),
			(7, 1, 1003, '2017-03-30', '2017-04-20'),
			(6, 2, 1009, '2017-01-04', '2017-01-25'),
			(9, 2, 1000, '2017-02-02', '2017-02-24'),
			(1, 3, 1001, '2018-01-01', '2018-01-22'),
			(4, 5, 1002, '2018-02-01', '2018-02-24'),
			(6, 2, 1010, '2018-01-04', '2018-01-25'),
			(3, 3, 1001, '2016-12-12', '2017-01-03'),
			(4, 4, 1010, '2018-01-07', '2018-01-28'),
			(9, 2, 1009, '2016-03-03', '2016-03-24')

INSERT INTO lib_copies (BookID, BranchID, NoOfCopies)
	VALUES (1, 1, 5),
			(1, 2, 10),
			(1, 3, 5),
			(1, 4, 2),
			(1, 5, 0),
			(2, 1, 10),
			(2, 2, 10),
			(2, 3, 1),
			(2, 4, 10),
			(2, 5, 5),
			(3, 1, 10),
			(3, 2, 5),
			(3, 3, 4),
			(3, 4, 1),
			(3, 5, 20),
			(4, 1, 2),
			(4, 2, 3),
			(4, 3, 5),
			(4, 4, 10),
			(4, 5, 12),
			(5, 1, 10),
			(5, 2, 10),
			(5, 3, 10),
			(5, 4, 12),
			(5, 5, 15),
			(6, 1, 12),
			(6, 2, 10),
			(6, 3, 12),
			(6, 4, 15),
			(6, 5, 8),
			(7, 1, 2),
			(7, 2, 12),
			(7, 3, 10),
			(7, 4, 10),
			(7, 5, 8),
			(8, 1, 2),
			(8, 2, 1),
			(8, 3, 12),
			(8, 4, 4),
			(8, 5, 14),
			(9, 1, 12),
			(9, 2, 10),
			(9, 3, 3),
			(9, 4, 13),
			(9, 5, 8),
			(10, 1, 2),
			(10, 2, 3),
			(10, 3, 5),
			(10, 4, 4),
			(10, 5, 15),
			(11, 1, 5),
			(11, 2, 10),
			(11, 3, 5),
			(11, 4, 2),
			(11, 5, 0),
			(12, 1, 10),
			(12, 2, 10),
			(12, 3, 1),
			(12, 4, 10),
			(12, 5, 5),
			(13, 1, 10),
			(13, 2, 5),
			(13, 3, 4),
			(13, 4, 1),
			(13, 5, 20),
			(14, 1, 2),
			(14, 2, 3),
			(14, 3, 5),
			(14, 4, 10),
			(14, 5, 12),
			(15, 1, 10),
			(15, 2, 10),
			(15, 3, 10),
			(15, 4, 12),
			(15, 5, 15),
			(16, 1, 12),
			(16, 2, 10),
			(16, 3, 12),
			(16, 4, 15),
			(16, 5, 8),
			(17, 1, 2),
			(17, 2, 12),
			(17, 3, 10),
			(17, 4, 10),
			(17, 5, 8),
			(18, 1, 2),
			(18, 2, 1),
			(18, 3, 12),
			(18, 4, 4),
			(18, 5, 14),
			(19, 1, 12),
			(19, 2, 10),
			(19, 3, 3),
			(19, 4, 13),
			(19, 5, 8),
			(20, 1, 5),
			(20, 2, 6),
			(20, 3, 5),
			(20, 4, 4),
			(20, 5, 10),
			(21, 1, 5),
			(21, 2, 6),
			(21, 3, 5),
			(21, 4, 4),
			(21, 5, 10),
			(22, 1, 5),
			(22, 2, 6),
			(22, 3, 5),
			(22, 4, 4),
			(22, 5, 10),
			(23, 1, 5),
			(23, 2, 6),
			(23, 3, 5),
			(23, 4, 4),
			(23, 5, 10)

INSERT INTO lib_borrower (BorrowerName, BorrowerAddress, BorrowerPhone)
	VALUES ('This Guy', '499 Fake St', '1234567890'),
			('That Guy', '500 Fake St', '2345678901'),
			('Other Guy', '501 Fake St', '3456789012'),
			('Last Guy', '502 Fake St', '4567890123'),
			('This Girl', '503 Fake St', '5678901234'),
			('Other Girl', '504 Fake St', '6789012345'),
			('Last Girl', '505 Fake St', '7890123456'),
			('Runnin Out', '506 Fake St', '8901234567'),
			('Of Names', '507 Fake St', '9012345678'),
			('To Use', '508 Fake St', '0123456789'),
			('Last One', '509 Fake St', '1234543210'),
			('Added One', '510 Fake St', '0000000000')

INSERT INTO lib_branch (BranchName, BranchAddress)
	VALUES ('Sharpstown', '123 Book St'),
			('Central', '234 Book St'),
			('Dullstown', '345 Book St'),
			('Outer', '456 Book St'),
			('Space', '567 Book St')

GO
	CREATE PROC uspLostTribeCount
	AS
	DECLARE @Title varchar(50) = 'The Lost Tribe'
	DECLARE @Branch varchar(50) = 'Sharpstown'
	SELECT lib_copies.NoOfCopies
	FROM lib_copies
	INNER JOIN lib_books ON lib_books.BookID = lib_copies.BookID
	INNER JOIN lib_branch ON lib_branch.BranchID = lib_copies.BranchID
	WHERE lib_books.Title = @Title AND lib_branch.BranchName = @Branch
GO

GO
	CREATE PROC uspLostTribesAll
	AS
	DECLARE @Title varchar(50) = 'The Lost Tribe'
	SELECT lib_branch.BranchName, lib_copies.NoOfCopies
	FROM lib_copies
	INNER JOIN lib_books ON lib_books.BookID = lib_copies.BookID
	INNER JOIN lib_branch ON lib_branch.BranchID = lib_copies.BranchID
	WHERE Title = @Title
GO

GO
	CREATE PROC uspNoCheckOuts
	AS
	SELECT lib_borrower.BorrowerName 
	FROM lib_borrower
	WHERE lib_borrower.CardNo NOT IN (SELECT lib_loans.CardNo FROM lib_loans)
GO

GO
	CREATE PROC uspDueTodayList
	AS
	SELECT lib_books.Title, lib_borrower.BorrowerName, lib_borrower.BorrowerAddress
	FROM lib_books
	INNER JOIN lib_loans ON lib_loans.BookID = lib_books.BookID
	INNER JOIN lib_borrower ON lib_borrower.CardNo = lib_loans.CardNo
	INNER JOIN lib_branch ON lib_branch.BranchID = lib_loans.BranchID
	WHERE lib_branch.BranchName = 'Sharpstown' AND lib_loans.DueDate = CONVERT (date, GETDATE());
GO
	
GO
	CREATE PROC uspLoanedByBranch
	AS
	SELECT lib_branch.BranchName, COUNT(lib_loans.BranchID)
	FROM lib_branch
	INNER JOIN lib_loans ON lib_branch.BranchID = lib_loans.BranchID
	GROUP BY lib_branch.BranchName
GO
	
GO
	CREATE PROC uspBigBorrowers
	AS
	SELECT lib_borrower.BorrowerName, lib_borrower.BorrowerAddress, lib_borrower.BorrowerPhone, COUNT(lib_loans.CardNo) AS 'Checked Out'
	FROM lib_borrower
	INNER JOIN lib_loans ON lib_borrower.CardNo = lib_loans.CardNo
	GROUP BY lib_loans.CardNo, lib_borrower.BorrowerName, lib_borrower.BorrowerAddress, lib_borrower.BorrowerPhone
	HAVING COUNT(lib_loans.CardNo) > 4
GO

GO
	CREATE PROC uspKingBooks
	AS
	SELECT lib_books.Title, lib_copies.NoOfCopies
	FROM lib_books
	INNER JOIN lib_copies ON lib_books.BookID = lib_copies.BookID
	INNER JOIN lib_authors ON lib_books.BookID = lib_authors.BookID
	INNER JOIN lib_branch ON lib_copies.BranchID = lib_branch.BranchID
	WHERE lib_authors.Author = 'Stephen King' AND lib_branch.BranchName = 'Central'
GO