using System;

class Number
{
    public int num;

    public void Reverse()
    {
        int rev = 0, n = num;
        while (n != 0)
        {
            rev = rev * 10 + n % 10;
            n /= 10;
        }
        Console.WriteLine("Reversed: " + rev);
    }
}

class Program
{
    static void Main()
    {
        Number n = new Number();
        Console.Write("Enter number: ");
        n.num = Convert.ToInt32(Console.ReadLine());
        n.Reverse();
    }
}
