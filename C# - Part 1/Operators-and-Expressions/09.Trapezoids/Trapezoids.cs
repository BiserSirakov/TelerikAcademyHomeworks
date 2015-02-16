//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Let`s calculate the area of an trapezoid.");
        Console.Write("Enter a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter h = ");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) * h) / 2;

        if (a > 0 && b > 0 && h >0)
        {
            Console.WriteLine("The area is : " + area);
        }
        else
        {
            Console.WriteLine("You must enter positive values !");
        }
        
        Console.ReadLine();
    }
}
