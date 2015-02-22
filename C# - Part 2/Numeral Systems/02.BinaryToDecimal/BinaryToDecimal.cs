//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number : ");
        string binary = Console.ReadLine();

        string result = Convert.ToInt32(binary, 2).ToString();

        Console.WriteLine("Decimal : " + result);
    }
}