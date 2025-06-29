-- Step 0: Drop existing tables if they exist
IF OBJECT_ID('Employees', 'U') IS NOT NULL
    DROP TABLE Employees;
IF OBJECT_ID('Departments', 'U') IS NOT NULL
    DROP TABLE Departments;
GO

-- Step 1: Create database if not exists
IF DB_ID('Week2SQL') IS NULL
    CREATE DATABASE Week2SQL;
GO

-- Step 2: Use the new database
USE Week2SQL;
GO

-- Step 3: Create Departments table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);
GO

-- Step 4: Create Employees table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Salary DECIMAL(10, 2),
    JoinDate DATE
);
GO

-- Step 5: Insert Departments
INSERT INTO Departments VALUES
(1, 'IT'), (2, 'HR'), (3, 'Finance');
GO

-- Step 6: Insert Employees
INSERT INTO Employees VALUES
(1, 'Alice', 'Thomas', 1, 80000.00, '2020-01-10'),
(2, 'Bob', 'Smith', 1, 95000.00, '2019-03-23'),
(3, 'Carol', 'Jones', 1, 95000.00, '2021-08-17'),
(4, 'David', 'Taylor', 2, 60000.00, '2022-02-15'),
(5, 'Eve', 'Brown', 2, 75000.00, '2020-06-11'),
(6, 'Frank', 'White', 2, 60000.00, '2018-09-30'),
(7, 'Grace', 'Black', 3, 82000.00, '2021-12-01'),
(8, 'Heidi', 'Wilson', 3, 85000.00, '2020-04-21'),
(9, 'Ivan', 'Green', 3, 87000.00, '2019-11-05');
GO

-- Step 7: ROW_NUMBER
SELECT 
    D.DepartmentName,
    E.FirstName,
    E.LastName,
    E.Salary,
    ROW_NUMBER() OVER (PARTITION BY D.DepartmentName ORDER BY E.Salary DESC) AS RowNum
FROM Employees E
JOIN Departments D ON E.DepartmentID = D.DepartmentID;
GO

-- Step 8: RANK
SELECT 
    D.DepartmentName,
    E.FirstName,
    E.LastName,
    E.Salary,
    RANK() OVER (PARTITION BY D.DepartmentName ORDER BY E.Salary DESC) AS RankNum
FROM Employees E
JOIN Departments D ON E.DepartmentID = D.DepartmentID;
GO

-- Step 9: DENSE_RANK
SELECT 
    D.DepartmentName,
    E.FirstName,
    E.LastName,
    E.Salary,
    DENSE_RANK() OVER (PARTITION BY D.DepartmentName ORDER BY E.Salary DESC) AS DenseRankNum
FROM Employees E
JOIN Departments D ON E.DepartmentID = D.DepartmentID;
GO
