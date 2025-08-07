using System;

class SquareCalculator
{
    // Field to store the number
    private int number;

    // Constructor to initialize the number
    public SquareCalculator(int num)
    {
        number = num;
    }

    // Method to calculate square
    public int GetSquare()
    {
        return number * number;
    }

    // Method to display the result
    public void DisplaySquare()
    {
        Console.WriteLine("The square of {0} is {1}", number, GetSquare());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number (positive, negative or zero): ");
        int input = Convert.ToInt32(Console.ReadLine());

        // Create object of SquareCalculator
        SquareCalculator calc = new SquareCalculator(input);

        // Call method to display the square
        calc.DisplaySquare();
    }
}
