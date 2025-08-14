using System;

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
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
        Person p = new Person("Alice");
        p.Display();
    }
}
