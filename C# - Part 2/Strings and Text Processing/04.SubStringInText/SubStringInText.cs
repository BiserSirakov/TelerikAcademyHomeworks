//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
using System.Text.RegularExpressions;

class SubStringInText
{
    static void Main()
    {
        Console.Write("Enter a text : ");
        string inputText = Console.ReadLine();

        Console.Write("Enter a substring : ");
        string inputSubstr = Console.ReadLine();

        var result = Regex.Matches(inputText, inputSubstr, RegexOptions.IgnoreCase).Count;
        Console.WriteLine("{0} is contained {1} times in the text.", inputSubstr, result);
    }
}