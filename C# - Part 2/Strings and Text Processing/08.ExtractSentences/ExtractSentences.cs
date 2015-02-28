//Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";

        List<string> matches = GetMatches(text, word);

        if (matches.Count == 0)
        {
            Console.WriteLine("No matches found!");
        }
        else
        {
            foreach (var sentence in matches)
            {
                Console.Write(sentence + ". ");
            }
            Console.WriteLine();
        }
    }

    private static List<string> GetMatches(string text, string word)
    {
        char[] separators = { '.', '!', '?' };

        string[] separatedSentences = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        List<string> matches = new List<string>();

        foreach (var sentence in separatedSentences)
        {
            if (Regex.IsMatch(sentence.ToLower(),
                        String.Format("{0}{1}{2}", "(^|[.;,:!? -])", word.ToLower(), "([.;,:!? -]|$)"),
                        RegexOptions.IgnoreCase))
            {
                matches.Add(sentence.Trim());
            }
        }

        return matches;
    }
}