//Write a program that reads a date and time given in the format: 
//day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        Console.Write("Enter date and time in the format: day.month.year hour:minute:second : ");
        DateTime input = DateTime.Parse(Console.ReadLine());

        DateTime result = input.AddHours(6).AddMinutes(30);
        string dayInBG = string.Empty;

        switch (result.DayOfWeek)
        {
            case DayOfWeek.Monday: dayInBG = "Понеделник"; break;
            case DayOfWeek.Tuesday: dayInBG = "Вторник"; break;
            case DayOfWeek.Wednesday: dayInBG = "Сряда"; break;
            case DayOfWeek.Thursday: dayInBG = "Четвъртък"; break;
            case DayOfWeek.Friday: dayInBG = "Петък"; break;
            case DayOfWeek.Saturday: dayInBG = "Събота"; break;
            case DayOfWeek.Sunday: dayInBG = "Неделя"; break;
        }

        Console.WriteLine("{0}, {1}", result, dayInBG);
    }
}