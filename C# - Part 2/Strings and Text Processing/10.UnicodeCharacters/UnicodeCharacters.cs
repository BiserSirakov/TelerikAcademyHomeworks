//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string : ");
        string input = Console.ReadLine();

        Console.WriteLine("Unicode characters : " + ParseToUnicode(input));
    }

    static string ParseToUnicode(string text)
    {
        StringBuilder result = new StringBuilder();

        foreach (var letter in text)
        {
            result.Append(String.Format("\\u{0:X4}", (int)letter));
        }

        return result.ToString();
    }
}