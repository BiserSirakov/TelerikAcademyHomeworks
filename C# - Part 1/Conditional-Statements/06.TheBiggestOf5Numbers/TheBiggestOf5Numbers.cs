//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());

        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());

        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine("\nThe biggest is " + a);
        }
        else if (b >= a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine("\nThe biggest is " + b);
        }
        else if (c >= a && c >= b && c >= d && c >= e)
        {
            Console.WriteLine("\nThe biggest is " + c);
        }
        else if (d >= a && d >= b && d >= c && d >= e)
        {
            Console.WriteLine("\nThe biggest is " + d);
        }
        else if (e >= a && e >= b && e >= c && e >= d)
        {
            Console.WriteLine("\nThe biggest is " + e);
        }

        Console.ReadLine();
    }
}
