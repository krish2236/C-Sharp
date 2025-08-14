using System;

class Counter
{
    public static int Count;

    static Counter()
    {
        Count = 0;
        Console.WriteLine("Static constructor called.");
    }

    public Counter()
    {
        Count++;
        Console.WriteLine("Instance created. Count = " + Count);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Before creating any objects.");
        Counter c1 = new Counter();
        Counter c2 = new Counter();
        Console.WriteLine($"Total objects created: {Counter.Count}");
    }
}
