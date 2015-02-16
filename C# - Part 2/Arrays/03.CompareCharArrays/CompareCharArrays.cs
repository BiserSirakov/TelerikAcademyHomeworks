//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter the first array of chars (word) : ");
        char[] firstWord = Console.ReadLine().ToCharArray();

        Console.Write("Enter the second array of chars (word) : ");
        char[] secondWord = Console.ReadLine().ToCharArray();

        string lexicographicallyFirst = string.Join("", firstWord);

        int length = Math.Min(firstWord.Length, secondWord.Length);

        for (int i = 0; i < length; i++)
        {
            if (firstWord[i] > secondWord[i]) // if there is a bigger letter in the first word it means that the second is lexicographicallyFirst
            {
                lexicographicallyFirst = string.Join("", secondWord);
                break;
            }
        }

        Console.WriteLine("Lexicographically first is: {0}", lexicographicallyFirst);
    }
}