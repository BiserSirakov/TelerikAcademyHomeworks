//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class Workdays
{
    static DateTime[] Holidays = 
        {
            new DateTime(2015, 3, 3),
            new DateTime(2015, 12, 24),
            new DateTime(2015, 12, 25),
            new DateTime(2015, 12, 31)
        };

    static void Main()
    {
        DateTime dateNow = DateTime.Now;

        Console.Write("Enter the date in format day.month.year : ");
        string[] dateStr = Console.ReadLine().Split('.');

        int day = int.Parse(dateStr[0]);
        int month = int.Parse(dateStr[1]);
        int year = int.Parse(dateStr[2]);
        
        DateTime endDate = new DateTime(year, month, day);

        Console.WriteLine("Today is : " + dateNow);
        Console.WriteLine();
        Console.WriteLine("Remaining working days : " + WorkDays(dateNow, endDate));
    }

    static int WorkDays(DateTime now, DateTime end)
    {
        if (end.CompareTo(now) < 0)
        {
            DateTime temp = now;
            now = end;
            end = temp;
        }

        int days = Math.Abs((end - now).Days);
        int counter = days;

        for (int i = 0; i < days; i++)
        {
            now = now.AddDays(1);

            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
            {
                counter--;
            }

            for (int j = 0; j < Holidays.Length; j++)
            {
                if (now.CompareTo(Holidays[j]) == 0)
                {
                    counter--;
                }
            }
        }


        return counter;
    }
}