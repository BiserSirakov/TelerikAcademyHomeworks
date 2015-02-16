//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("a = ");
        double a = Double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = Double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = Double.Parse(Console.ReadLine());

        sbyte count = 0;
        string sign = "";

        if (a < 0)
        {
            count++;
        }

        if (b < 0)
        {
            count++;
        }

        if (c < 0)
        {
            count++;
        }

        if (count % 2 == 0)
        {
            sign = "+";
        }
        else
        {
            sign = "-";
        }

        if (a == 0 || b == 0 || c == 0)
        {
            sign = "0";
        }

        Console.WriteLine("\n" + sign);

        Console.ReadLine();
    }
}
