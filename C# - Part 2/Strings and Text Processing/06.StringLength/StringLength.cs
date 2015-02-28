//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;

class StringLength
{
    static void Main()
    {
        Console.Write("Enter a string : ");
        string input = Console.ReadLine();

        if (input.Length > 20)
        {
            throw new Exception();
        }

        char[] arr = new char[20 - input.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = '*';
        }

        string result = input + new string(arr);
        Console.WriteLine(result);
    }
}