//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;

class CalculateNK
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("n! / k! = " + factorial(n)/factorial(k));

        Console.ReadLine();
    }

    private static int factorial(int number)
    {
        int result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}
