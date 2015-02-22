//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Globalization;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number : ");
        string hexadecimal = Console.ReadLine();

        int result = int.Parse(hexadecimal, NumberStyles.HexNumber);

        Console.WriteLine("Decimal : " + result);
    }
}