//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) 
//is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("n! / (k! * (n-k)!) = " + factorial(n) / (factorial(k) * factorial(n - k)));

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
