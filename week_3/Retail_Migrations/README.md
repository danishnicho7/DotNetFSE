# Lab 3: Using EF Core CLI to Create and Apply Migrations – Retail_Migrations

---

## Objective

To use the **EF Core Command Line Interface (CLI)** to generate migrations and create a SQL Server database schema based on C# model classes.

---

## Technologies Used

- C# (.NET Core Console App)
- Entity Framework Core
- SQL Server
- EF Core CLI
- Visual Studio Code

---

## Project Structure
Retail_Migrations/
│
├── Program.cs // Entry point with EnsureCreated() or context instantiation
├── Product.cs // Product entity
├── Category.cs // Category entity
├── AppDbContext.cs // DbContext with connection string
├── Migrations/ // Auto-generated migration files
├── Retail_Migrations.csproj


---

## Key Concepts

- EF Core CLI:
  - Generate migration files
  - Apply migrations to update/create the database
- Understanding how schema changes are tracked and managed using migrations
- Database-first vs code-first approach (this lab uses code-first)

## Key Concepts

- EF Core CLI:
  - Generate migration files
  - Apply migrations to update/create the database
- Understanding how schema changes are tracked and managed using migrations
- Database-first vs code-first approach (this lab uses code-first)

### Step 1: Prerequisites

- SQL Server running (`SQLEXPRESS` or `LocalDB`)
- .NET SDK installed
- EF Core CLI installed globally (if not already):

->bash
dotnet tool install --global dotnet-ef

### Step 2: Install EF Core Packages

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design

### Step 3: Create Initial Migration

dotnet ef migrations add InitialCreate

### Step 4: Apply the Migration

dotnet ef database update

### Database Created

Database Name: RetailStoreMigrationsDB

Tables:

  Products
  Categories

## Output
![image](https://github.com/user-attachments/assets/cad6843e-2375-417f-9ed9-cc09942412ef)


