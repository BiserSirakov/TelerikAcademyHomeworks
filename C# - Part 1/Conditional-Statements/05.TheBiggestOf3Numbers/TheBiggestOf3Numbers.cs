//Write a program that finds the biggest of three numbers.

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("The biggest is " + a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("The biggest is " + b);
        }
        else if (c >= a && c >= b)
        {
            Console.WriteLine("The biggest is " + c);
        }

        Console.ReadLine();
    }
}
