using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string department, double salary)
    {
        Id = id;
        Name = name;
        Department = department;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Dept: {Department}, Salary: ₹{Salary}");
    }
}

class EmployeeManager
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee emp)
    {
        employees.Add(emp);
        Console.WriteLine("Employee added.");
    }

    public void DisplayAll()
    {
        Console.WriteLine("\nAll Employees:");
        foreach (var emp in employees)
        {
            emp.Display();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeManager manager = new EmployeeManager();

        manager.AddEmployee(new Employee(1, "Alice", "HR", 35000));
        manager.AddEmployee(new Employee(2, "Bob", "IT", 50000));
        manager.AddEmployee(new Employee(3, "Charlie", "Finance", 40000));

        manager.DisplayAll();
    }
}
