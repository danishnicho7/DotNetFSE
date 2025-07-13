USE EmployeeDB;
GO

-- Test 1: Department 1
EXEC dbo.sp_GetEmployeeCountByDepartment @DepartmentID = 1;
GO

-- Test 2: Department 2
EXEC dbo.sp_GetEmployeeCountByDepartment @DepartmentID = 2;
GO
