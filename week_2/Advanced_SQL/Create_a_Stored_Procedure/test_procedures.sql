USE EmployeeDB;

-- Insert employees
EXEC sp_InsertEmployee 
    @FirstName = 'Charlie',
    @LastName = 'Brown',
    @DepartmentID = 2,
    @Salary = 72000.00,
    @JoinDate = '2024-01-10';
GO

EXEC sp_InsertEmployee 
    @FirstName = 'Emily',
    @LastName = 'Clark',
    @DepartmentID = 1,
    @Salary = 82000.00,
    @JoinDate = '2023-08-01';
GO

-- Retrieve employees by department
EXEC sp_GetEmployeesByDepartment @DepartmentID = 2;
GO
EXEC sp_GetEmployeesByDepartment @DepartmentID = 1;
GO

-- See all employees
SELECT * FROM Employees;
GO

-- Group count by department
SELECT DepartmentID, COUNT(*) AS EmployeeCount
FROM Employees
GROUP BY DepartmentID;
GO
