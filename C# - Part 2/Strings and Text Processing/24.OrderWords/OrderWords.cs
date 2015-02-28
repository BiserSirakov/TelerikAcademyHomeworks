//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter some words, seperated by space : ");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}