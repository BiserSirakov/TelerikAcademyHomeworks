//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] arr = new char[26];

        for (int i = 0; i < 26; i++)
        {
            int first = (int)'A';
            arr[i] = (char)(first + i);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] + " = " + i);
        }

        Console.WriteLine();

        Console.Write("Enter a word : ");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (word[i] == arr[j])
                {
                    Console.Write(Array.IndexOf(arr, arr[j]) + " ");
                }
            }
        }

        Console.WriteLine();
    }
}