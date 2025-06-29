USE EmployeeDB;
GO

IF OBJECT_ID('dbo.sp_GetEmployeeCountByDepartment', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_GetEmployeeCountByDepartment;
GO

CREATE PROCEDURE dbo.sp_GetEmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    -- Count employees in the given department
    SELECT COUNT(*) AS EmployeeCount
    FROM dbo.Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO
