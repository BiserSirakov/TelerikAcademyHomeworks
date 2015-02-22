//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Globalization;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number : ");
        string hexadec = Console.ReadLine();

        int dec = int.Parse(hexadec, NumberStyles.HexNumber);

        Console.WriteLine("Binary : " + DecToBinary(dec));
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