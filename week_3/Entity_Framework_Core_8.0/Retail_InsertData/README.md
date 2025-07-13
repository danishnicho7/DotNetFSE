# Lab 4: Inserting Initial Data into the Database – Retail_InsertData
---

##  Objective

To use **Entity Framework Core** to insert initial product categories and products into a SQL Server database using asynchronous methods (`AddRangeAsync()` and `SaveChangesAsync()`).

---

##  Technologies Used

- C# (.NET Core Console App)
- Entity Framework Core
- SQL Server
- Visual Studio Code

---

## Project Structure
Retail_InsertData/
│
├── Program.cs // Main logic for inserting data
├── Product.cs // Product entity
├── Category.cs // Category entity
├── AppDbContext.cs // EF Core DbContext setup
├── Migrations/ // EF Core migration files
├── Retail_InsertData.csproj

## Key Concepts

- Using async EF Core methods:  
  - `AddRangeAsync()`  
  - `SaveChangesAsync()`
- Setting up entity relationships (One-to-Many)
- Creating and applying migrations using EF CLI
- Populating the database with sample data
## Steps to Run the Project

### Step 1: Prerequisites

- SQL Server running (`SQLEXPRESS` or `LocalDB`)
- .NET SDK installed
- EF Core CLI installed (if not):

->bash
dotnet tool install --global dotnet-ef

### Step 2: Install EF Core Packages

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design

### Step 3: Generate and Apply Migration

dotnet ef migrations add InitialCreate
dotnet ef database update

### Step 4: Run the Application
dotnet run

### Expected output:
Initial data inserted successfully!

### Data Inserted
Categories:

Electronics
Groceries

Products:

Laptop – ₹75000
Rice Bag – ₹1200

## Output
![image](https://github.com/user-attachments/assets/3cdb3b64-cdbb-42ba-9a07-22527601fd57)



