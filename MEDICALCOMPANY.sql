CREATE DATABASE MEDICALCOMPANY
--DROP DATABASE MEDICALCOMPANY
GO
USE MEDICALCOMPANY
GO

CREATE TABLE userLogin(
	username nvarchar(50),
	userPass varchar(50),
	primary key(username)
)
go

insert into userLogin values('Duy', '1234')
insert into userLogin values('Huy', '1234')
--SELECT * FROM userLogin

CREATE TABLE [Admin](
	ADMIN_ID varchar(10)
	primary key(ADMIN_ID)
)
go

create table Accountant(
	ACCOUNTANT_ID varchar(10),
	ACCOUNTANT_NAME nvarchar(50),
	GENDER varchar(5),
	SDT varchar(11)
	primary key(ACCOUNTANT_ID)
)
GO

create table Agent(
	AGENT_ID varchar(10),
	AGENT_NAME nvarchar(50),
	[ADDRESS] varchar(30)
	primary key(AGENT_ID)
)

CREATE TABLE PRODUCT(
	PRO_ID VARCHAR(10),
	PRO_NAME NVARCHAR(50),
	SALEPRICE DECIMAL(10,0),
	QUANTITY INT,
	PRIMARY KEY(PRO_ID)
)
GO

CREATE TABLE IMPORT(
	IMPORT_ID VARCHAR(10),
	PRO_ID VARCHAR(10) FOREIGN KEY REFERENCES PRODUCT(PRO_ID),
	PRODUCT_NAME NVARCHAR(50),
	IMPORT_DATE DATE,
	PRICE DECIMAL(10,0),
	QUANTITY INT

	PRIMARY KEY(IMPORT_ID)
)
GO

CREATE TABLE Temp_IMPORT(
	IMPORT_ID VARCHAR(10),
	PRO_ID VARCHAR(10) FOREIGN KEY REFERENCES PRODUCT(PRO_ID),
	PRODUCT_NAME NVARCHAR(50),
	IMPORT_DATE DATE,
	PRICE DECIMAL(10,0),
	QUANTITY INT

	PRIMARY KEY(IMPORT_ID)
)
GO
--DROP TABLE Temp_IMPORT

CREATE TABLE EXPORT(
	EXPORT_ID VARCHAR(10),
	PRO_ID VARCHAR(10) FOREIGN KEY REFERENCES PRODUCT(PRO_ID),
	PRODUCT_NAME NVARCHAR(50),
	AGENT_ID VARCHAR(10) FOREIGN KEY REFERENCES AGENT(AGENT_ID),
	EXPORT_DATE DATE,
	QUANTITY INT,
	PRICE DECIMAL(10,0),
	DELIVERY_STATUS NVARCHAR(30),
	PAYMENT_STATUS NVARCHAR(30),
	PRIMARY KEY(EXPORT_ID)
)
GO

--DROP TABLE EXPORT
CREATE TABLE Temp_EXPORT(
	EXPORT_ID VARCHAR(10),
	PRO_ID VARCHAR(10) FOREIGN KEY REFERENCES PRODUCT(PRO_ID),
	PRODUCT_NAME NVARCHAR(50),
	AGENT_ID VARCHAR(10) FOREIGN KEY REFERENCES AGENT(AGENT_ID),
	EXPORT_DATE DATE,
	QUANTITY INT,
	PRICE DECIMAL(10,0),
	DELIVERY_STATUS NVARCHAR(30),
	PAYMENT_STATUS NVARCHAR(30),
	PRIMARY KEY(EXPORT_ID)
)
GO
--table chua gia tri revenue
CREATE TABLE monthRevenue(
	STT int identity,
	SELECTED_MONTH INT,
	REVENUE decimal(10,0)
	PRIMARY KEY(STT)
)
--drop table monthRevenue

INSERT INTO PRODUCT VALUES ('P1', 'Dong Trung Ha Thao', '800000', 100)
INSERT INTO PRODUCT VALUES ('P2', 'Nuoc Hong Sam', '900000', 150)
INSERT INTO PRODUCT VALUES ('P3', 'Alipas', '500000', 50)
INSERT INTO PRODUCT VALUES ('P4', 'Vien Uong Sua Ong Chua', '550000', 75)
INSERT INTO PRODUCT VALUES ('P5', 'Nutra Vision', '300000', 40)
INSERT INTO PRODUCT VALUES ('P6', 'Suntory Sesamin Ex', '450000', 100)
INSERT INTO PRODUCT VALUES ('P7', 'Vitamin tong hop', '200000', 100)
GO

INSERT INTO [Admin] VALUES('AD1')
GO

INSERT INTO [Accountant] VALUES('ACC1', 'Huy', 'Male', '0123456789')
INSERT INTO [Accountant] VALUES('ACC2', 'Duy', 'Male', '0123456798')
go

INSERT INTO Agent VALUES('AG1', 'HEALTHCARE corp.', 'Ho Chi Minh City')
INSERT INTO Agent VALUES('AG2', 'MEDICINE THANH TAM', 'Ha Noi')
INSERT INTO Agent VALUES('AG3', 'HOSPITAL 3', 'Hue')

-- set date format
SET DATEFORMAT dmy
GO

--proc add import
CREATE PROC IMPORT_ORDER
	@IID VARCHAR(10),
	@Pro_id VARCHAR(10),
	@pro_name NVARCHAR(50),
	@IDATE DATE,
	@PRICE DECIMAL(10, 0),
	@QUANTITY INT
AS
BEGIN
	INSERT INTO IMPORT VALUES(@IID, @Pro_id, @pro_name, @IDATE, @PRICE, @QUANTITY)
	INSERT INTO Temp_IMPORT VALUES(@IID, @Pro_id, @pro_name, @IDATE, @PRICE, @QUANTITY)
END
GO
--DROP PROC IMPORT_ORDER
--EXEC IMPORT_ORDER @IID = 'I21', @Pro_id = 'P7', @pro_name = 'Vitamin tong hop', @IDATE = '20/01/2022', @PRICE = '400000', @QUANTITY = 50
--SELECT * FROM IMPORT

CREATE PROC UPDATE_IMPORT_ORDER
	@IID VARCHAR(10),
	@Pro_id VARCHAR(10),
	@pro_name NVARCHAR(50),
	@IDATE DATE,
	@PRICE DECIMAL(10, 0),
	@QUANTITY INT
AS
BEGIN
	UPDATE IMPORT SET IMPORT_ID = @IID, PRO_ID = @Pro_id, PRODUCT_NAME = @pro_name, IMPORT_DATE = @IDATE, PRICE = @PRICE, QUANTITY = @QUANTITY
	WHERE IMPORT_ID = @IID;
	UPDATE Temp_IMPORT SET IMPORT_ID = @IID, PRO_ID = @Pro_id, PRODUCT_NAME = @pro_name, IMPORT_DATE = @IDATE, PRICE = @PRICE, QUANTITY = @QUANTITY
	WHERE IMPORT_ID = @IID;
END
GO

--delete import information
CREATE PROC DELETE_IMPORT_ORDER
	@id varchar(10)
as
BEGIN
	DELETE FROM IMPORT WHERE IMPORT_ID = @id;
	DELETE FROM Temp_IMPORT WHERE IMPORT_ID = @id;
END
GO

--display import information
CREATE PROC showIMPORT
@month int
AS
BEGIN
	SELECT * FROM IMPORT WHERE MONTH(IMPORT_DATE) = @month
END
GO

--display temporary import table when input
CREATE PROC showTempIMPORT
AS
BEGIN
	SELECT * FROM Temp_IMPORT
END
GO

--delete temporary import table values
CREATE PROC delTempImportValue
as
begin
	DELETE FROM Temp_IMPORT
end
go
--select * from IMPORT
--delete from IMPORT where IMPORT_ID = 'I1'

-- proc add export
CREATE PROC EXPORT_ORDER
	@EID VARCHAR(10),
	@Pro_id VARCHAR(10),
	@pro_name NVARCHAR(50),
	@agent_id varchar(10),
	@EDATE DATE,
	@QUANTITY INT,
	@PRICE DECIMAL(10, 0),
	@deliver_status nvarchar(30),
	@payment_status nvarchar(30)
AS
BEGIN
	INSERT INTO EXPORT VALUES(@EID, @Pro_id, @pro_name, @agent_id, @EDATE, @QUANTITY, @PRICE, @deliver_status, @payment_status);
	INSERT INTO Temp_EXPORT VALUES(@EID, @Pro_id, @pro_name, @agent_id, @EDATE, @QUANTITY, @PRICE, @deliver_status, @payment_status);
END
GO
--drop proc EXPORT_ORDER

CREATE PROC UPDATE_EXPORT_ORDER
	@EID VARCHAR(10),
	@Pro_id VARCHAR(10),
	@pro_name NVARCHAR(50),
	@agent_id varchar(10),
	@EDATE DATE,
	@QUANTITY INT,
	@PRICE DECIMAL(10, 0),
	@deliver_status nvarchar(30),
	@payment_status nvarchar(30)
AS
BEGIN
	UPDATE EXPORT SET EXPORT_ID = @EID, PRO_ID = @Pro_id, PRODUCT_NAME = @pro_name, AGENT_ID = @agent_id, EXPORT_DATE = @EDATE, QUANTITY = @QUANTITY, 
	PRICE = @PRICE, DELIVERY_STATUS = @deliver_status, PAYMENT_STATUS = @payment_status
	WHERE EXPORT_ID = @EID;
	UPDATE Temp_EXPORT SET EXPORT_ID = @EID, PRO_ID = @Pro_id, PRODUCT_NAME = @pro_name, AGENT_ID = @agent_id, EXPORT_DATE = @EDATE, QUANTITY = @QUANTITY, 
	PRICE = @PRICE, DELIVERY_STATUS = @deliver_status, PAYMENT_STATUS = @payment_status
	WHERE EXPORT_ID = @EID;
END
GO
--drop proc UPDATE_EXPORT_ORDER

--delete export information
CREATE PROC DELETE_EXPORT_ORDER
	@id varchar(10)
as
BEGIN
	DELETE FROM EXPORT WHERE EXPORT_ID = @id;
	DELETE FROM Temp_EXPORT WHERE EXPORT_ID = @id;
END
GO

--display Export information
CREATE PROC showEXPORT
@month int
AS
BEGIN
	SELECT * FROM EXPORT WHERE MONTH(EXPORT_DATE) = @month
END
GO

--display temporary export table when input
CREATE PROC showTempEXPORT
AS
BEGIN
	SELECT * FROM Temp_EXPORT
END
GO

--delete temporary export values
CREATE PROC delTempExportValue
as
begin
	DELETE FROM Temp_EXPORT
end
go
--select * from EXPORT
--delete from EXPORT

--income per month (thu nhap moi thang)
CREATE PROC showREVENUE
	@month int
as
begin
	--select SUM(PRICE) from EXPORT where MONTH(EXPORT_DATE) = @month
	declare @revenue decimal(10,0)
	set @revenue = (SELECT SUM(PRICE) FROM EXPORT WHERE MONTH(EXPORT_DATE) = @month) - 
				(SELECT SUM(PRICE) FROM IMPORT WHERE MONTH(IMPORT_DATE) = @month)
	insert into monthRevenue values (@month, @revenue)
	select * from monthRevenue
end
go
--drop proc showREVENUE

-- delete Revenue value
create proc delRevenueValue
as
begin
	DELETE FROM monthRevenue
	dbcc checkident ('monthRevenue', RESEED, 0)
END
GO
--drop proc delRevenueValue

--proc to add product
create proc addProduct
	@proID varchar(10),
	@proName nvarchar(50),
	@price decimal(10,0),
	@quantity int
as
begin
	INSERT INTO PRODUCT VALUES(@proID, @proName, @price, @quantity);
end
go

--proc update product
CREATE PROC updateProduct
	@proId VARCHAR(10),
	@proName NVARCHAR(50),
	@PRICE DECIMAL(10, 0),
	@QUANTITY INT
AS
BEGIN
	UPDATE PRODUCT SET PRO_ID = @proId, PRO_NAME = @proName, SALEPRICE = @PRICE, QUANTITY = @QUANTITY
	WHERE PRO_ID = @proId;
END
GO

--proc delete product
CREATE PROC deleteProduct
	@id varchar(10)
as
BEGIN
	DELETE FROM PRODUCT WHERE PRO_ID = @id;
END
GO

--proc show product
create proc showProduct
as
begin
	select * from PRODUCT
end
go

--proc to show agent list
create proc showAgent
as
begin
	select * from Agent
end
go