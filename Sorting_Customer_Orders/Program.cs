using System;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalPrice { get; set; }

    public Order(int id, string name, double price)
    {
        OrderId = id;
        CustomerName = name;
        TotalPrice = price;
    }

    public void Display()
    {
        Console.WriteLine($"Order ID: {OrderId}, Customer: {CustomerName}, Total Price: ₹{TotalPrice}");
    }
}

class SortOrders
{
    public void BubbleSort(Order[] orders)
    {
        for (int i = 0; i < orders.Length - 1; i++)
        {
            for (int j = 0; j < orders.Length - i - 1; j++)
            {
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                {
                    var temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    public void QuickSort(Order[] orders, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(orders, low, high);
            QuickSort(orders, low, pivotIndex - 1);
            QuickSort(orders, pivotIndex + 1, high);
        }
    }

    private int Partition(Order[] orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (orders[j].TotalPrice <= pivot)
            {
                i++;
                var temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }

        var temp2 = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = temp2;

        return i + 1;
    }
}

class Program
{
    static void Main()
    {
        Order[] orders = {
            new Order(101, "Alice", 4500.50),
            new Order(102, "Bob", 2200.75),
            new Order(103, "Charlie", 8800.00),
            new Order(104, "Diana", 3100.25)
        };

        SortOrders sorter = new SortOrders();

        Console.WriteLine("🔽 Bubble Sort by Total Price:");
        sorter.BubbleSort(orders);
        foreach (var order in orders) order.Display();

        Console.WriteLine("\n🔽 Quick Sort by Total Price:");
        Order[] ordersForQuickSort = {
            new Order(101, "Alice", 4500.50),
            new Order(102, "Bob", 2200.75),
            new Order(103, "Charlie", 8800.00),
            new Order(104, "Diana", 3100.25)
        };
        sorter.QuickSort(ordersForQuickSort, 0, ordersForQuickSort.Length - 1);
        foreach (var order in ordersForQuickSort) order.Display();
    }
}
