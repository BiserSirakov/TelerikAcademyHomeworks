//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class Sum
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter another number : ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number : ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Their sum is : " + (a + b +c));

        Console.ReadLine();

    }
}
