//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        Console.Write("Enter the first date : ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the second date : ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        var result = date1 - date2;

        if (date2 > date1)
        {
            result = date2 - date1;
        }
        
        Console.WriteLine("Distance : {0} days", result.Days);
    }
}