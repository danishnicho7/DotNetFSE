# Lab 1: Understanding ORM with a Retail Inventory System – Retail_Inventory
---

## Objective

To understand the basics of **Object-Relational Mapping (ORM)** and how **Entity Framework Core** bridges the gap between C# classes and SQL Server database tables.

---

## Technologies Used

- C# (.NET Core Console App)
- Entity Framework Core
- SQL Server
- Visual Studio Code

---

## Project Structure
Retail_Inventory/
│
├── Program.cs // Main entry point (calls EnsureCreated)
├── Product.cs // Product entity
├── Category.cs // Category entity
├── AppDbContext.cs // EF Core DbContext
├── Retail_Inventory.csproj


---

## Key Concepts

- What is ORM:
  - It maps C# classes to database tables automatically.
  - You interact with the DB using objects instead of SQL queries.
- Benefits:
  - Increased productivity
  - Better maintainability
  - SQL abstraction
- EF Core 8 Features (theoretical):
  - JSON column mapping
  - Compiled models for performance
  - Interceptors and bulk operations

---

## Steps to Run the Project

### Step 1: Prerequisites

- SQL Server running (`SQLEXPRESS` or `LocalDB`)
- .NET SDK installed
- Visual Studio Code

---

### Step 2: Install EF Core Packages

->bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design

### Step 3: Run the Application
dotnet run

### Expected Output:
Database created successfully!

### Database Created

Database Name: RetailStoreDB

Tables:
  Products
  Categories

## Output
![image](https://github.com/user-attachments/assets/d5ac9bf5-f80d-4ef6-b23b-fd6e9d1caf75)



