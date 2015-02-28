//Write a program that reverses the words in given sentence.

using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

class ReverseSentence
{
    static readonly string[] punctuation = new string[] { ".", ",", "!", "-", ":", "?" };
    static void Main()
    {
        Console.Write("Enter a sentence : ");
        string input = Console.ReadLine();

        string[] separatedSentence = SplitSentence(input);
        string[] result = new string[separatedSentence.Length];

        PrefillPunctuation(separatedSentence, result);
        ReverseWords(separatedSentence, result);

        Console.WriteLine(JoinSentence(result));
    }

    private static string[] SplitSentence(string input)
    {
        foreach (var character in punctuation)
        {
            input = input.Replace(character, (" " + character + " "));
        }

        string[] separatedSentence = input
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return separatedSentence;
    }

    private static void PrefillPunctuation(string[] separatedSentence, string[] result)
    {
        for (int index = 0; index < separatedSentence.Length; index++)
        {
            if (punctuation.Contains(separatedSentence[index]))
            {
                result[index] = separatedSentence[index];
            }
        }
    }

    private static void ReverseWords(string[] separatedSentence, string[] result)
    {
        for (int index = 0, sentenceIndex = separatedSentence.Length - 1;
            index < result.Length && sentenceIndex >= 0;
            index++, sentenceIndex--)
        {
            while (result[index] != null)
                ++index;

            while (punctuation.Contains(separatedSentence[sentenceIndex]))
                --sentenceIndex;

            result[index] = separatedSentence[sentenceIndex];
        }
    }

    private static string JoinSentence(string[] result)
    {
        StringBuilder output = new StringBuilder();
        foreach (var item in result)
        {
            if (punctuation.Contains(item))
                output.Append(item);
            else
                output.Append(" " + item);
        }

        return output.ToString().Trim();
    }
}