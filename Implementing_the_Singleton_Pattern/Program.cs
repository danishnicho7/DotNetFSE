using System;

class Logger
{
    private static Logger instance = null;
    private static readonly object lockObj = new object();

    
    private Logger()
    {
        Console.WriteLine("Logger Initialized.");
    }

    
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
            }
        }
        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}

class Program
{
    static void Main()
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("First log message");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("Second log message");

        Console.WriteLine($"Are both logger instances the same? {object.ReferenceEquals(logger1, logger2)}");
    }
}
