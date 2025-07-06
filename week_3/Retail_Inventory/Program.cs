using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;


class Program
{
    static void Main()
    {
        using (var context = new RetailContext())
        {
            context.Database.EnsureCreated(); 

            if (!context.Categories.Any())
            {
                var category = new Category { CategoryName = "Electronics" };
                var product = new Product { Name = "Laptop", StockLevel = 10, Category = category };

                context.Categories.Add(category);
                context.Products.Add(product);
                context.SaveChanges();
            }

            foreach (var p in context.Products.Include(p => p.Category))
            {
                Console.WriteLine($"{p.Name} - {p.Category.CategoryName} - Stock: {p.StockLevel}");
            }
        }
    }
}
