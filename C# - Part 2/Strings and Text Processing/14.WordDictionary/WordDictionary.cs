//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

using System;

class WordDictionary
{
    static void Main()
    {
        Console.Write("Enter a word : ");
        string input = Console.ReadLine();

        Console.WriteLine(Dictionary(input));
    }

    private static string Dictionary(string input)
    {
        string result = "";

        switch (input)
        {
            case ".NET": result = "platform for applications from Microsoft"; break;
            case "CLR": result = "managed execution environment for .NET"; break;
            case "namespace": result = "hierarchical organization of classes"; break;
        }

        return result;
    }
}