using System;
using System.Collections.Generic;

public interface IObserver
{
    void Update(string stockName, double price);
}

public interface IStock
{
    void RegisterObserver(IObserver observer);
    void DeregisterObserver(IObserver observer);
    void NotifyObservers();
}

public class StockMarket : IStock
{
    private List<IObserver> observers = new List<IObserver>();
    private string stockName;
    private double stockPrice;

    public void SetStockPrice(string name, double price)
    {
        this.stockName = name;
        this.stockPrice = price;
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void DeregisterObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(stockName, stockPrice);
        }
    }
}

public class MobileApp : IObserver
{
    private string appId;

    public MobileApp(string id)
    {
        this.appId = id;
    }

    public void Update(string stockName, double price)
    {
        Console.WriteLine($"[MobileApp-{appId}] {stockName} price updated to {price}");
    }
}

public class WebApp : IObserver
{
    private string webId;

    public WebApp(string id)
    {
        this.webId = id;
    }

    public void Update(string stockName, double price)
    {
        Console.WriteLine($"[WebApp-{webId}] {stockName} price updated to {price}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        StockMarket stockMarket = new StockMarket();

        IObserver mobileApp = new MobileApp("M1");
        IObserver webApp = new WebApp("W1");

        stockMarket.RegisterObserver(mobileApp);
        stockMarket.RegisterObserver(webApp);

        stockMarket.SetStockPrice("AAPL", 145.60);
        Console.WriteLine();

        stockMarket.SetStockPrice("GOOG", 2734.50);
        Console.WriteLine();

        stockMarket.DeregisterObserver(webApp);

        stockMarket.SetStockPrice("TSLA", 695.30);
    }
}
