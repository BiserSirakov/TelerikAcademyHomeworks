//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Calculate the perimeter and area of a rectangle\nEnter width : ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter height : ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("Perimeter : " + perimeter);
        Console.WriteLine("Area : " + area);

        Console.ReadLine();
    }
}
