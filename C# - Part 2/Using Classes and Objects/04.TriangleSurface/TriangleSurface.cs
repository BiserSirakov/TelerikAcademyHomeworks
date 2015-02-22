//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Calculate the surface of a triangle by given side and un altitude to it : ");
        Console.Write("Enter the side : ");
        double side = double.Parse(Console.ReadLine());

        Console.Write("Enter the altitude : ");
        double altitude = double.Parse(Console.ReadLine());

        Console.WriteLine("The surface is : " + SideAndAltitude(side, altitude));

        Console.WriteLine(new string('-', 50));

        Console.WriteLine("Calculate the surface of a triangle by given three sides : ");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("The surface is : " + ThreeSides(a, b, c));

        Console.WriteLine(new string('-', 50));

        Console.WriteLine("Calculate the surface of a triangle by given two sides and an angle between them : ");
        Console.Write("a = ");
        double anotherA = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double anotherB = double.Parse(Console.ReadLine());

        Console.WriteLine("Angle (in degrees) = ");
        double angle = double.Parse(Console.ReadLine());

        Console.WriteLine("The surface is : " + TwoSidesAndAngle(anotherA, anotherB, angle));
    }

    static double SideAndAltitude(double side, double altitude)
    {
        double result = (side * altitude) / 2;

        return result;
    }

    static double ThreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;

        double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        return result;
    }

    static double TwoSidesAndAngle(double a, double b, double angle)
    {
        double result = (a * b * Math.Sin(angle)) / 2;

        return result;
    }
}