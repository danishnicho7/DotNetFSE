using System;

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            Console.WriteLine("Ready for migration!");
        }
    }
}
