//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a decimal number : ");
        int number = int.Parse(Console.ReadLine());

        string result = number.ToString("X");
        Console.WriteLine("Hexadecimal : " + result);
    }
}