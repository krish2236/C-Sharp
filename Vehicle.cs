using System;


interface IVehicle
{
    void Stack();
    void Stock();
}


class Car : IVehicle
{
    public void Stack() => Console.WriteLine("Car stacked.");
    public void Stock() => Console.WriteLine("Car stock shown.");
}

class Bike : IVehicle
{
    public void Stack() => Console.WriteLine("Bike stacked.");
    public void Stock() => Console.WriteLine("Bike stock shown.");
}

class Truck : IVehicle
{
    public void Stack() => Console.WriteLine("Truck stacked.");
    public void Stock() => Console.WriteLine("Truck stock shown.");
}


class Program
{
    static void Main()
    {
        IVehicle[] vehicles = { new Car(), new Bike(), new Truck() };

        foreach (IVehicle v in vehicles)
        {
            v.Stack();
            v.Stock();
        }
    }
}
