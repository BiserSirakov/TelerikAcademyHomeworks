//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number : ");
        string binary = Console.ReadLine();

        string dec = Convert.ToInt32(binary, 2).ToString();
        int number = int.Parse(dec);

        string result = number.ToString("X");
        Console.WriteLine("Hexadecimal : " + result);
    }
}