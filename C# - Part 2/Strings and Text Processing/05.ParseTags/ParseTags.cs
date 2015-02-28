//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.

using System;
using System.Text;
using System.Text.RegularExpressions;

class ParseTags
{
    static void Main()
    {
        Console.Write("Enter a text : ");
        string input = Console.ReadLine();
        input = Regex.Replace(input, "<upcase>", "<");
        input = Regex.Replace(input, "</upcase>", ">");

        StringBuilder result = new StringBuilder();
        bool isOut = true;

        foreach (var item in input)
        {
            if (isOut)
            {
                if (item == '<')
                {
                    isOut = false;
                }
                else
                {
                    result.Append(item);
                }
            }
            else
            {
                if (item == '>')
                {
                    isOut = true;
                }
                else
                {
                    result.Append(item.ToString().ToUpper());
                }
            }
        }

        Console.WriteLine(result);
    }
}