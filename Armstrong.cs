using System;

class ArmstrongNumbers
{
    static void Main()
    {
        Console.WriteLine("Armstrong numbers between 1 and 1000 are:");

        for (int number = 1; number <= 1000; number++)
        {
            int originalNumber = number;
            int sum = 0;
            int digits = CountDigits(number);

            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, digits);
                number /= 10;
            }

            if (sum == originalNumber)
            {
                Console.WriteLine(originalNumber);
            }

            number = originalNumber; 
        }
    }

    static int CountDigits(int num)
    {
        int count = 0;
        while (num != 0)
        {
            count++;
            num /= 10;
        }
        return count;
    }
}
