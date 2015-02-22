//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Enter a number = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter another number = ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter another number = ");
        int c = int.Parse(Console.ReadLine());

        int max = GetMax(a, b);
        if (GetMax(a, b) < GetMax(b, c))
        {
            max = GetMax(b, c);
        }
        else if (GetMax(b, c) < GetMax(c, a))
        {
            max = GetMax(c, a);
        }

        Console.WriteLine("The largest number is {0}", max);
    }

    private static int GetMax(int num1, int num2)
    {
        int max = num1;

        if (num2 > num1)
        {
            max = num2;
        }

        return max;
    }
}