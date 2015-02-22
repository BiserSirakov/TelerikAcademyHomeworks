//Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        decimal number = decimal.Parse(Console.ReadLine());

        number = Reverse(number);
        Console.WriteLine("Reversed number : {0}", number);
    }

    private static decimal Reverse(decimal input)
    {
        char[] number = input.ToString().ToCharArray();
        Array.Reverse(number);
        string result = new string(number);
        return Convert.ToDecimal(result);
    }
}