using System;

public interface Notifier
{
    void Send(string message);
}

public class EmailNotifier : Notifier
{
    public void Send(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
}

public abstract class NotifierDecorator : Notifier
{
    protected Notifier notifier;

    public NotifierDecorator(Notifier notifier)
    {
        this.notifier = notifier;
    }

    public virtual void Send(string message)
    {
        notifier.Send(message);
    }
}

public class SMSNotifierDecorator : NotifierDecorator
{
    public SMSNotifierDecorator(Notifier notifier) : base(notifier) {}

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine("Sending SMS: " + message);
    }
}

public class SlackNotifierDecorator : NotifierDecorator
{
    public SlackNotifierDecorator(Notifier notifier) : base(notifier) {}

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine("Sending Slack Message: " + message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Notifier baseNotifier = new EmailNotifier();
        Notifier smsNotifier = new SMSNotifierDecorator(baseNotifier);
        Notifier slackNotifier = new SlackNotifierDecorator(smsNotifier);

        slackNotifier.Send("Your order has been shipped!");
    }
}
