//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

class SaveSortedNames
{
    static void Main()
    {
        string firstFile = @"D:\New Text Document.txt";
        string secondFile = @"D:\New Text Document (2).txt";

        List<string> strings = new List<string>();

        StreamReader reader = new StreamReader(firstFile);

        strings = reader.ReadToEnd()
            .Split('\n')
            .Select(x => x.Trim())
            .OrderBy(x => x)
            .ToList();

        File.WriteAllLines(secondFile, strings);
    }
}
