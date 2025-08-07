using System;

class Singleton
{
    private static Singleton instance = null;
    public string Name;

    private Singleton()
    {
        Name = "Singleton Instance";
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
            instance = new Singleton();
        return instance;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

class Program
{
    static void Main()
    {
        Singleton s1 = Singleton.GetInstance();
        s1.Display();

        Singleton s2 = Singleton.GetInstance();
        s2.Display();

        Console.WriteLine(ReferenceEquals(s1, s2) 
            ? "Both references are same instance." 
            : "Different instances.");
    }
}
