using System;
using System.Collections.Generic;
class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, int qty, double price)
    {
        ProductId = id;
        ProductName = name;
        Quantity = qty;
        Price = price;
    }
}
class InventorySystem
{
    private Dictionary<int, Product> inventory = new Dictionary<int, Product>();

    public void AddProduct(Product product)
    {
        inventory[product.ProductId] = product;
        Console.WriteLine("Product added or updated.");
    }

    public void UpdateProduct(int productId, int newQty, double newPrice)
    {
        if (inventory.ContainsKey(productId))
        {
            inventory[productId].Quantity = newQty;
            inventory[productId].Price = newPrice;
            Console.WriteLine("Product updated.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void DeleteProduct(int productId)
    {
        if (inventory.Remove(productId))
            Console.WriteLine("Product deleted.");
        else
            Console.WriteLine("Product not found.");
    }

    public void DisplayAll()
    {
        foreach (var product in inventory.Values)
        {
            Console.WriteLine($"{product.ProductId}: {product.ProductName}, Qty: {product.Quantity}, Price: {product.Price}");
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        InventorySystem inv = new InventorySystem();

        inv.AddProduct(new Product(101, "Keyboard", 10, 999.99));
        inv.AddProduct(new Product(102, "Mouse", 20, 499.99));
        inv.DisplayAll();

        inv.UpdateProduct(102, 25, 459.99);
        inv.DeleteProduct(103); // Product not found
    }
}

