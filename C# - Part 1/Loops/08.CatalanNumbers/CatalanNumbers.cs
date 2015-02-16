//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Catalan(n) = " + factorial(2 * n) / (factorial(n + 1) * factorial(n)));

        Console.ReadLine();
    }

    private static BigInteger factorial(int number)
    {
        BigInteger result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}


