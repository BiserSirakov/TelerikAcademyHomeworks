//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;
using System.Text;

class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"D:\New Text Document.txt");

        StringBuilder result = new StringBuilder();
        string line = reader.ReadLine();
        int lineNumber = 1;

        while (line != null)
        {
            result.AppendLine(String.Format("{0,-5:D3}{1}", lineNumber, line));
            ++lineNumber;
        }

        File.WriteAllLines(@"D:\New Text Document (2).txt", result.ToString().Split('\n'));
    }
}