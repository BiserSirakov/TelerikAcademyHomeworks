//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number : ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary : {0}", DecToBinary(number));
    }

    static string DecToBinary(int number)
    {
        int remainder = 0;
        string result = "";

        while (number > 0)
        {
            remainder = number % 2;
            number /= 2;
            result += remainder.ToString();
        }

        char[] charResult = result.ToCharArray();
        Array.Reverse(charResult);
        string binResult = new string(charResult);

        return binResult;
    }
}