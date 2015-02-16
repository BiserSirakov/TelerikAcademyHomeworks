//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the radius of the cirlce : ");
        double radius = double.Parse(Console.ReadLine());

        double pi = Math.PI;

        double perimeter = 2 * pi * radius;
        perimeter = Math.Round(perimeter, 2);

        double area = pi * radius * radius;
        area = Math.Round(area, 2);

        Console.WriteLine("The perimeter is : " + perimeter);
        Console.WriteLine("The area is : " + area);

        Console.ReadLine();
    }
}
