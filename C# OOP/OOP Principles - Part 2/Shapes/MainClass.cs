//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
//    (heightwidth for rectangle and heightwidth/2 for triangle).
//Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.

namespace Shapes
{
    using System;

    class MainClass
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(3.5, 3),
                new Square(5),
                new Triangle(4.5, 6)
            };

            Console.WriteLine("Surface of the rectangle : " + shapes[0].CalculateSurface());
            Console.WriteLine("Surface of the square : " + shapes[1].CalculateSurface());
            Console.WriteLine("Surface of the triangle : " + shapes[2].CalculateSurface());
        }
    }
}