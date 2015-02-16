//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients of the equation ax^2 + bx + c = 0");

        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (a == 0)
        {
            Console.WriteLine("If a = 0 there is no quadratic equation!");
        }
        else
        {
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (discriminant == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("x1 = x2 = " + x);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("There are no real roots.");
            }
        }
        
        Console.ReadLine();
    }
}
