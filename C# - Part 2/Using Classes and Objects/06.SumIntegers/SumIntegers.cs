//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;

class SumIntegers
{
    static void Main()
    {
        Console.Write("Enter several integers, seperated by space : ");
        string[] input = Console.ReadLine().Split(' ');

        int sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            sum += int.Parse(input[i]);
        }

        Console.WriteLine("Sum = " + sum);
    }
}