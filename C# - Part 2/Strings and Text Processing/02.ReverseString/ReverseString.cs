//Write a program that reads a string, reverses it and prints the result at the console.

using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string : ");
        string input = Console.ReadLine();

        Console.WriteLine("Reversed string : " + ReverseStr(input));
    }

    static string ReverseStr(string input)
    {
        char[] charInput = input.ToCharArray();
        Array.Reverse(charInput);
        string result = new string(charInput);

        return result;
    }
}