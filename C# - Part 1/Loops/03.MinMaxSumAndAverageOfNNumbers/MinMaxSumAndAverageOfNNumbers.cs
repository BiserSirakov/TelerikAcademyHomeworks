//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you will enter : ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;
        double average = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter an integer : ");
            int number = int.Parse(Console.ReadLine());

            sum += number;

            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }

            average = Math.Round((double)sum / (double)n, 2);
        }

        Console.WriteLine("\nMin = " + min);
        Console.WriteLine("Max = " + max);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + average);

        Console.ReadLine();
    }
}
