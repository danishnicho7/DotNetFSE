# Exercise: Create a Stored Procedure

## Goal

To create and use a stored procedure that inserts employee records into the database using structured parameters.

---

## Scenario

A company needs to manage employee data efficiently. To ensure structured data entry and enforce schema constraints, you are tasked with:

- Creating `Departments` and `Employees` tables.
- Writing a stored procedure named `sp_InsertEmployee` to insert employee data.
- Verifying the inserted data by querying the `Employees` table.

---

## Steps Taken

### 1. Create the Database

Created a new database named `EmployeeDB` to isolate the employee management system.

### 2. Define the Tables

- **Departments**
  - Columns: `DepartmentID` (Primary Key), `DepartmentName`
- **Employees**
  - Columns: `EmployeeID` (Primary Key, auto-increment), `FirstName`, `LastName`, `DepartmentID` (FK), `Salary`, `JoinDate`

### 3. Insert Sample Departments

Inserted sample department records to enable foreign key references from the `Employees` table.

### 4. Create the Stored Procedure

Defined `sp_InsertEmployee` to accept parameters like name, department, salary, and join date, and insert them into the `Employees` table.

### 5. Execute the Stored Procedure

Inserted two sample employees:
- **Alice Johnson**, Engineering, ₹80,000, Joined on 2023-03-01
- **Bob Smith**, Engineering, ₹75,000, Joined on 2022-07-15

### 6. Query the `Employees` Table

Verified that both employees were successfully added.

### Output
![output1](https://github.com/user-attachments/assets/1be75bcf-a9f8-4a39-a971-476d31807e30)
![output2](https://github.com/user-attachments/assets/56a578e6-f9aa-486b-95b4-12531cb3364a)
![output3](https://github.com/user-attachments/assets/311a481e-98ef-41a4-b5c2-d7ca8bc956bc)





