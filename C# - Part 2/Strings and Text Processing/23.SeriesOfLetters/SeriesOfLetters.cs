//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter some string: ");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        char lastChar = '\0';

        foreach (var letter in input)
        {
            if (letter != lastChar) result.Append(letter);

            lastChar = letter;
        }

        Console.WriteLine(result);
    }
}