//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void Main()
    {
        string file = @"D:\New Text Document.txt";

        StreamReader reader = new StreamReader(file);

        string[] text = reader.ReadToEnd().Split('\n');

        List<string> result = new List<string>();

        for (int i = 1; i < text.Length; i += 2)
        {
            result.Add(text[i]);
        }

        StringBuilder sbResult = new StringBuilder();

        foreach (var item in result)
        {
            sbResult.Append(item + '\n');
        }

        Console.WriteLine(sbResult.ToString());
    }
}