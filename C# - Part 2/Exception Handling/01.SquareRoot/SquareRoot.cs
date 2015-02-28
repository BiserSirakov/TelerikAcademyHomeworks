//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number : ");
            double number = double.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            double sqrt = Math.Sqrt(number);
            Console.WriteLine("The square root of the number is : " + sqrt);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number cannot be negative !");
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a number !");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}