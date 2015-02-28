//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
class DatesFromTextInCanada
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

        string text = "My birthday is 24.3.1991, Pesho`s - 10.1.1995, Gosho`s - 3.10.1994 and Ivancho`s - 5.8.1993";

        string format = "d.M.yyyy";
        CultureInfo provider = Thread.CurrentThread.CurrentCulture;

        foreach (var match in Regex.Matches(text, @"[\d]{1,2}.[\d]{1,2}.[\d]{4}"))
        {
            try
            {
                DateTime check = DateTime.ParseExact(match.ToString(), format, provider);
                Console.WriteLine(check.ToShortDateString());
            }
            catch (FormatException)
            {
                continue;
            }
        }
    }
}