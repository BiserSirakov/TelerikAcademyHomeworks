//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15}", number);
        Console.WriteLine("{0,15:X}", number);
        Console.WriteLine("{0,15:P}", number/100.00);
        Console.WriteLine("{0,15:E}", number);
    }
}