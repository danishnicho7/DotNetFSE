# Lab 2: Setting Up the Database Context for a Retail Store

This project is part of the Cognizant Deep Skilling Nurture program (Week 3 - Lab 2).

##  Objective

Configure `DbContext` using Entity Framework Core to represent product and category data for a retail store in SQL Server.

##  Technologies Used

- .NET Core Console App
- C#
- Entity Framework Core
- SQL Server

##  Project Structure
    Retail_DbContext/
    ├── Program.cs
    ├── Product.cs
    ├── Category.cs
    ├── AppDbContext.cs
    ├── Retail_DbContext.csproj

##  Concepts Demonstrated

- Creating entity classes (`Product` and `Category`)
- Defining relationships using navigation properties
- Configuring `DbContext` using EF Core
- Connecting to SQL Server with a connection string
- Creating the database using `EnsureCreated()`

## How to Run

1. Make sure SQL Server is running locally.
2. Update the connection string in `AppDbContext.cs` if needed.
3. Run the project


## Output
![image](https://github.com/user-attachments/assets/bfebf5f8-6abd-4218-9177-ece8e129de25)


