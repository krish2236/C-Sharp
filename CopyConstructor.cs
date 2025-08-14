using System;

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }

    public Person(Person other)
    {
        Name = other.Name;
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
        Person p1 = new Person("Bob");
        Person p2 = new Person(p1);
        p2.Display();
    }
}
