//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceSubString
{
    static void Main()
    {
        string firstFile = @"D:\New Text Document.txt";
        string secondFile = @"D:\New Text Document (2).txt";

        StreamReader reader = new StreamReader(firstFile);

        string result = string.Empty;

        while (!reader.EndOfStream)
        {
            result = reader.ReadLine();

            result = Regex.Replace(result, "start", "finish", RegexOptions.IgnoreCase);
        }

        File.WriteAllText(secondFile, result);

    }
}