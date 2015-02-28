//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ForbiddenWords
{
    static void Main()
    {
        Console.Write("Enter a text : ");
        string text = Console.ReadLine();

        Console.Write("Enter the number of forbidden words : ");
        int n = int.Parse(Console.ReadLine());

        string[] forbiddenWords = new string[n];

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            Console.Write("Forbidden word #{0} = ", i + 1);
            forbiddenWords[i] = Console.ReadLine();
        }

        for (int i = 0; i < forbiddenWords.Length - 1; i++)
        {
            text = ReplaceOneWord(text, forbiddenWords);
        }

        Console.WriteLine(ReplaceOneWord(text, forbiddenWords));
    }

    static string ReplaceOneWord(string text, string[] forbiddenWords)
    {
        string result = string.Empty;

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            if (Regex.IsMatch(text, forbiddenWords[i]))
            {
                result = Regex.Replace(text, forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }
        }

        return result;
    }
}