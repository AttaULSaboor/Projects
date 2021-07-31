/*I, Atta UL Saboor, student number 000395780, certify that this material is my original work.
No other person's work has been used without due acknowledgment and I have not made my work available to anyone else.*/
/*******************************************************
Script: co859.sql
Author: Atta UL Saboor
Date: Oct 05, 2020
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

--Create INDEX statement
	CREATE INDEX property_description
	ON real_estate_property (property_description);
GO

-- Create properties view
CREATE VIEW properties_view
AS
SELECT SUBSTRING(property_description, 1, 15) as description, sales_ytd 
from real_estate_property
where amount > (SELECT AVG(amount) from real_estate_property)
GO

-- Verify inserts
CREATE TABLE verify (
  table_name varchar(25), 
  actual INT, 
  expected INT);
GO

-- Insert data into varify tables
INSERT INTO verify VALUES('real_estate_property', (SELECT COUNT(*) FROM real_estate_property), 5);
INSERT INTO verify VALUES('sales', (SELECT COUNT(*) FROM sales), 15);
PRINT 'Verification';
SELECT table_name, actual, expected, expected - actual discrepancy FROM verify;
DROP TABLE verify;
GO