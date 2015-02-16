//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());

        if (min == max)
        {
            Console.WriteLine("min should be != max");
            return;
        }
        else
        {
            Random rand = new Random();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", rand.Next(min, max + 1));
            }
        }

        Console.ReadLine();
    }
}