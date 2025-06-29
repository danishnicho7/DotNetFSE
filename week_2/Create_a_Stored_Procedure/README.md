# Exercise 1: Create a Stored Procedure

## Goal
Create a SQL stored procedure to:
1. Retrieve employee details by department.
2. Insert a new employee into the `Employees` table.

---

## Scenario

As part of an HR management system, we want to:
- Fetch a list of employees working in a particular department.
- Insert new employee data through a reusable stored procedure.

These tasks are commonly performed using **parameterized stored procedures**, which help modularize logic and prevent SQL injection.

---

## Steps Performed

### 1️⃣ Defined Stored Procedure to Retrieve Employees by Department

- Procedure Name: `sp_GetEmployeesByDepartment`
- Input Parameter: `@DepartmentID INT`
- Logic: Fetch all employees belonging to the given department ID.

```sql
CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO
