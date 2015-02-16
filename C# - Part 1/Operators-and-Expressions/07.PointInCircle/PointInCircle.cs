//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter x = ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter y = ");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine("Let`s check if the point ({0},{1}) is inside the circle K({{0, 0}}, 2)", x, y);

        bool isInside;
        int radius = 2;

        if ((x * x + y * y) <= radius * radius)
        {
            isInside = true;
        }
        else
        {
            isInside = false;
        }

        Console.WriteLine(isInside);

        Console.ReadLine();
    }
}
