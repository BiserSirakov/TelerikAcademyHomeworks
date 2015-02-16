using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;

        Console.Write("Enter number 1 : ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Enter number 2 : ");
        double number2 = double.Parse(Console.ReadLine());

        double result = Math.Abs(number1 - number2);

        if (result < eps)
        {
            Console.WriteLine("The numbers are equal.");
        }
        else
        {
            Console.WriteLine("The numbers are not equal.");
        }

        Console.ReadLine();
    }
}
