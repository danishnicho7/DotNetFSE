using System;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class SearchFunction
{
    public Product LinearSearch(Product[] products, string name)
    {
        foreach (var product in products)
        {
            if (product.ProductName == name)
                return product;
        }
        return null;
    }

    public Product BinarySearch(Product[] products, string name)
    {
        int left = 0, right = products.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            int result = string.Compare(products[mid].ProductName, name);
            if (result == 0) return products[mid];
            if (result < 0) left = mid + 1;
            else right = mid - 1;
        }
        return null;
    }
}

class Program
{
    static void Main()
    {
        Product[] products = {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shoes", "Footwear"),
            new Product(3, "Book", "Stationery"),
            new Product(4, "Mobile", "Electronics")
        };

        SearchFunction search = new SearchFunction();

        Product result1 = search.LinearSearch(products, "Book");
        Console.WriteLine("Linear Search Result: " + (result1?.ProductName ?? "Not found"));

        Array.Sort(products, (p1, p2) => p1.ProductName.CompareTo(p2.ProductName));

    
        Product result2 = search.BinarySearch(products, "Mobile");
        Console.WriteLine("Binary Search Result: " + (result2?.ProductName ?? "Not found"));
    }
}
