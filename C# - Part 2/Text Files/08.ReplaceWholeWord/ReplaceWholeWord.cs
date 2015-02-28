//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

class ReplaceWholeWord
{
    static void Main()
    {
        string firstFile = @"D:\New Text Document.txt";
        string secondFile = @"D:\New Text Document (2).txt";

        StreamReader reader = new StreamReader(firstFile);

        string text = reader.ReadToEnd();

        var words = new List<object>();

        foreach (var word in Regex.Matches(text, @"\w+"))
        {
            words.Add(word);
        }

        var strWords = words
            .Select(x => x.ToString())
            .ToList();

        for (int i = 0; i < strWords.Count; i++)
        {
            if (strWords[i] == "start")
            {
                strWords[i] = "finish";
            }
        }

        StringBuilder result = new StringBuilder();

        foreach (var item in strWords)
        {
            result.Append(item + " ");
        }

        Console.WriteLine(result);
    }
}