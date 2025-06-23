using System;

interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

class PayPalGateway
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"PayPal: Payment of ${amount} processed.");
    }
}

class StripeGateway
{
    public void ExecuteTransaction(float total)
    {
        Console.WriteLine($"Stripe: Payment of ${total} completed.");
    }
}

class PayPalAdapter : IPaymentProcessor
{
    private PayPalGateway _paypal = new PayPalGateway();

    public void ProcessPayment(decimal amount)
    {
        _paypal.MakePayment((double)amount);
    }
}

class StripeAdapter : IPaymentProcessor
{
    private StripeGateway _stripe = new StripeGateway();

    public void ProcessPayment(decimal amount)
    {
        _stripe.ExecuteTransaction((float)amount);
    }
}


class Program
{
    static void Main()
    {
        IPaymentProcessor paypal = new PayPalAdapter();
        paypal.ProcessPayment(100.50m);

        IPaymentProcessor stripe = new StripeAdapter();
        stripe.ProcessPayment(250.75m);
    }
}
