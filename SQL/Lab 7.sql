/*******************************************************
Script: co859.sql
Date: November 24, 2020
Description: Create co859 Database objects for Real Estate Property
********************************************************/

-- Setting NOCOUNT ON suppresses completion messages for each INSERT
SET NOCOUNT ON

-- Set date format to year, month, day
SET DATEFORMAT ymd;

-- Make the master database the current database
USE master

-- If database co859 exists, drop it
IF EXISTS (SELECT * FROM sysdatabases WHERE name = 'co859')
  DROP DATABASE co859;
GO

-- Create the co859 database
CREATE DATABASE co859;
GO

-- Make the co859 database the current database
USE co859;

-- Create real_estate_property table
CREATE TABLE real_estate_property (
  property_id INT PRIMARY KEY, 
  property_description VARCHAR(25), 
  property_type CHAR(1) CHECK (property_type IN ('R', 'C', 'I', 'L')), 
  amount MONEY,
  sales_ytd MONEY); 
GO

-- Create sales table
CREATE TABLE sales (
	sales_id INT PRIMARY KEY, 
	sales_date DATE, 
	amount MONEY, 
	property_id INT FOREIGN KEY REFERENCES real_estate_property(property_id));
GO

-- Insert real_estate_property records
INSERT INTO real_estate_property VALUES(150, 'residential', 'R', 500000, 1500000);
INSERT INTO real_estate_property VALUES(250, 'commercial', 'C', 800000, 2400000);
INSERT INTO real_estate_property VALUES(350, 'commercial_rental', 'C', 5000, 15000);
INSERT INTO real_estate_property VALUES(450, 'industrial', 'I', 2000000, 6000000);
INSERT INTO real_estate_property VALUES(550, 'land', 'L', 300000, 300000);

-- Insert sales records
INSERT INTO sales VALUES(1, '2020-01-03', 500000, 150);
INSERT INTO sales VALUES(2, '2020-02-01', 300000, 550);
INSERT INTO sales VALUES(3, '2020-02-15', 2000000, 450);
INSERT INTO sales VALUES(4, '2020-03-30', 500000, 150);
INSERT INTO sales VALUES(5, '2020-04-03', 5000, 350);
INSERT INTO sales VALUES(6, '2020-04-12', 300000, 550);
INSERT INTO sales VALUES(7, '2020-04-30', 5000, 350);
INSERT INTO sales VALUES(8, '2020-05-13', 300000, 550);
INSERT INTO sales VALUES(9, '2020-05-28', 2000000, 450);
INSERT INTO sales VALUES(10, '2020-06-05', 800000, 250);
INSERT INTO sales VALUES(11, '2020-06-16', 500000, 150);
INSERT INTO sales VALUES(12, '2020-07-06', 800000, 250);
INSERT INTO sales VALUES(13, '2020-08-14', 5000, 350);
INSERT INTO sales VALUES(14, '2020-09-09', 800000, 250);
INSERT INTO sales VALUES(15, '2020-09-22', 2000000, 450);
GO

-- CREATE trigger for insert
CREATE TRIGGER MySales_Insert 
	ON sales
	AFTER INSERT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	DECLARE @property_id INT;
	DECLARE @amount MONEY;
	
	-- Insert statement for trigger
	SELECT @property_id = property_id FROM inserted;

	SELECT @amount = amount FROM inserted;

	UPDATE real_estate_property set sales_ytd = sales_ytd + @amount where property_id = @property_id;
END
GO


-- CREATE trigger for Delete
CREATE TRIGGER MySales_Delete 
	ON Sales
	AFTER DELETE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	DECLARE @property_id INT;
	DECLARE @amount Money;
	
	-- Delete statement for trigger
	SELECT @property_id = property_id FROM deleted;
	SELECT @amount = amount FROM deleted;

	

	UPDATE real_estate_property set sales_ytd = sales_ytd - @amount where property_id = @property_id;	
END
GO

-- Create trigger for Update
CREATE TRIGGER MySales_Update
	ON Sales
	AFTER UPDATE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	DECLARE @property_id INT;
	DECLARE @new_amount MONEY;
	DECLARE @old_amount MONEY;
	DECLARE @oldAmount MONEY;

	-- Update statement for trigger
	SELECT @property_id = inserted.property_id FROM inserted
	SELECT @new_amount = inserted.amount FROM inserted
	SELECT @old_amount = deleted.amount FROM deleted

	IF @new_amount > @old_amount
		UPDATE real_estate_property set sales_ytd = sales_ytd + @new_amount where property_id = @property_id;
	ELSE
		UPDATE real_estate_property set sales_ytd = sales_ytd - @new_amount where property_id = @property_id;
END
GO

-- Verification
PRINT 'Verify triggers'
PRINT 'Master Table Before Changes'
--SELECT all rows and columns from the master table
SELECT * FROM real_estate_property;

--INSERT a row into the sales table (ensure transaction amount is not zero, pick a large or unusual amount)
INSERT INTO sales VALUES(16, '2020-11-23', 5000, 150);

PRINT 'After INSERT'
--SELECT all rows and columns from the master table
SELECT * FROM real_estate_property;

--DELETE the row that just got inserted in the sales table
DELETE FROM sales WHERE sales_id = 16;

PRINT 'After DELETE'
--SELECT all rows and columns from the master table
SELECT * FROM real_estate_property;

--UPDATE the transaction amount in one row in the sales table (ensure transaction amount is not zero, pick a large or unusual amount, this will make it stand out in the output)
UPDATE sales 
SET amount = 222222
WHERE property_id = 150;

PRINT 'After UPDATE'
--SELECT all rows and columns from the master table
SELECT * FROM real_estate_property;
