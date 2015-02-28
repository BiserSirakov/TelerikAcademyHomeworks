//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        //<a href=" == [URL=
        //"> == ]
        //</a> == /URL]

        Console.Write("Enter HTML document : ");
        string input = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(ReplaceHTML(input));
    }

    static string ReplaceHTML(string input)
    {
        input = input.Replace("<a href=\"", "[URL=");
        input = input.Replace("\">", "]");
        input = input.Replace("</a>", "[/URL]");

        return input;
    }
}