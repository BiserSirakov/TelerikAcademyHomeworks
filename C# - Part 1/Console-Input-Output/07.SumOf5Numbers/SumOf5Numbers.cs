//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter 5 numbers, sepereted by space : ");
        string[] fiveNumbers = Console.ReadLine().Split(' ');

        double sum = 0;

        for (int i = 0; i <= 4; i++)
        {
            sum += Convert.ToDouble(fiveNumbers[i]);
        }

        Console.WriteLine("Their sum is : " + sum);

        Console.ReadLine();
    }
}
