using System;

public interface IPaymentStrategy
{
    void Pay(double amount);
}

public class CreditCardPayment : IPaymentStrategy
{
    private string cardNumber;

    public CreditCardPayment(string cardNumber)
    {
        this.cardNumber = cardNumber;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount:C} using Credit Card (Card No: {cardNumber})");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    private string email;

    public PayPalPayment(string email)
    {
        this.email = email;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount:C} using PayPal (Email: {email})");
    }
}

public class PaymentContext
{
    private IPaymentStrategy paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        this.paymentStrategy = strategy;
    }

    public void MakePayment(double amount)
    {
        if (paymentStrategy == null)
        {
            Console.WriteLine("No payment strategy selected.");
        }
        else
        {
            paymentStrategy.Pay(amount);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        PaymentContext context = new PaymentContext();

        context.SetPaymentStrategy(new CreditCardPayment("1234-5678-9876-5432"));
        context.MakePayment(1500.00);

        Console.WriteLine();

        context.SetPaymentStrategy(new PayPalPayment("user@example.com"));
        context.MakePayment(750.50);
    }
}
