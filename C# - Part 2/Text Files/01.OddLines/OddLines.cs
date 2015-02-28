//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"D:\New Text Document.txt");

        string[] allLines = reader.ReadToEnd().Split('\n');

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < allLines.Length; i += 2)
        {
            result.AppendLine(allLines[i]);
        }

        Console.WriteLine(result);
    }
}