# Lab 5: Retrieving Data from the Database – Retail_ReadData


## Objective

To use **Entity Framework Core** to retrieve data from a SQL Server database using methods like `ToListAsync()`, `FindAsync()`, and `FirstOrDefaultAsync()`.


## Technologies Used

- C# (.NET Core Console App)
- Entity Framework Core
- SQL Server
- Visual Studio Code

---

## Project Structure
Retail_ReadData/
│
├── Program.cs // Reads and displays product data
├── Product.cs // Product entity
├── Category.cs // Category entity
├── AppDbContext.cs // EF Core DbContext setup
├── Retail_ReadData.csproj

## Key Concepts

- Querying data using EF Core’s async LINQ methods:
  - `ToListAsync()` – fetch all records
  - `FindAsync(id)` – find by primary key
  - `FirstOrDefaultAsync(condition)` – fetch first match or default
- Reading from a pre-populated database (`RetailStoreInsertDB`)
- Displaying formatted output in the console

---

## Steps to Run the Project

### Step 1: Prerequisites

- SQL Server running (`SQLEXPRESS` or `LocalDB`)
- The database `RetailStoreInsertDB` must already exist with sample data
- .NET SDK installed

---

### Step 2: Install EF Core Packages

->bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design

### Step 3: Run the Application

dotnet run
## Functionality Demonstrated

Read all products and print them with name and price

Find a product by ID using FindAsync(1)

Get the first expensive product using FirstOrDefaultAsync()

## Output
![image](https://github.com/user-attachments/assets/8f930e05-ab18-4ee4-873e-6e2f5ac006ef)
