-- Step 1: Create a new database
IF DB_ID('EmployeeDB') IS NOT NULL
    DROP DATABASE EmployeeDB;
GO

CREATE DATABASE EmployeeDB;
GO

-- Step 2: Use the new database
USE EmployeeDB;
GO

-- Step 3: Create Departments table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);
GO

-- Step 4: Create Employees table
CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Salary DECIMAL(10, 2),
    JoinDate DATE
);
GO

-- Step 5: Insert sample data into Departments
INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES (1, 'HR'), (2, 'IT'), (3, 'Sales');
GO

-- Step 6: Create stored procedure to insert an employee
CREATE PROCEDURE sp_InsertEmployee 
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;
GO

-- Step 7: Create stored procedure to get employees by department
CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

-- Step 8: Insert employee data using stored procedure
EXEC sp_InsertEmployee 
    @FirstName = 'Alice',
    @LastName = 'Johnson',
    @DepartmentID = 2,
    @Salary = 80000.00,
    @JoinDate = '2023-03-01';

EXEC sp_InsertEmployee 
    @FirstName = 'Bob',
    @LastName = 'Smith',
    @DepartmentID = 2,
    @Salary = 75000.00,
    @JoinDate = '2022-07-15';
GO

-- Step 9: Retrieve employees by department
EXEC sp_GetEmployeesByDepartment @DepartmentID = 2;
GO
