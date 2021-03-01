CREATE DATABASE EmployeeDB;
GO

USE EmployeeDB; 
GO
  
IF OBJECT_ID ('dbo.new_employees', 'U') IS NOT NULL  
   DROP TABLE new_employees;  
GO  
CREATE TABLE Employee  
(  
 Id int NOT NULL PRIMARY KEY IDENTITY(1,1),  
 FirstName nvarchar (50) NOT NULL,  
 City nvarchar (50) NOT NULL,
 Phone nvarchar (10) NOT NULL,  
 Email nvarchar (50) NOT NULL
);  
  
INSERT INTO Employee (FirstName, City, Phone, Email)
VALUES ('John', 'Toronto', '9999999999', 'john@example.com');

INSERT INTO Employee (FirstName, City, Phone, Email)
VALUES ('Peter', 'Hamilton', '8885554444', 'peter@example.com');

INSERT INTO Employee (FirstName, City, Phone, Email)
VALUES ('Justin', 'Ottawa', '6664447777', 'justin@example.com');