using System;

class PascalTriangle
{
    static void Main()
    {
        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        int rows = int.Parse(Console.ReadLine());

        int[,] triangle = new int[rows, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    triangle[i, j] = 1; // Edges are 1
                }
                else
                {
                    triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j]; 
                }
            }
        }

        Console.WriteLine("\nPascal's Triangle:");
        for (int i = 0; i < rows; i++)
        {
            for (int space = 0; space < rows - i - 1; space++)
            {
                Console.Write("  ");
            }

            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{triangle[i, j],4}");
            }

            Console.WriteLine();
        }
    }
}
