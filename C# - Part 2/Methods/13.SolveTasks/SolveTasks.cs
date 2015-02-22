//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;

class SolveTasks
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu\n1. Reverse the digits of a number");
            Console.WriteLine("2. Calculate the average of a sequence of integers");
            Console.WriteLine("3. Solve a linear equation a * x + b = 0");
            Console.WriteLine("4. Quit");
            Console.Write("Enter an option : ");
            int option = int.Parse(Console.ReadLine());

            if (option < 1 || option > 4)
            {
                throw new FormatException();
            }

            bool quit = false;

            switch (option)
            {
                case 1:
                    Console.Write("Enter a non-negative decimal number : ");
                    decimal number = decimal.Parse(Console.ReadLine());

                    number = Reverse(number);
                    Console.WriteLine("The number reversed : " + number);
                    break;

                case 2:
                    Console.Write("Enter the length of the sequence : ");
                    int len = int.Parse(Console.ReadLine());

                    double[] integers = new double[len];

                    for (int i = 0; i < len; i++)
                    {
                        Console.Write("Enter integer[{0}] : ", i);
                        integers[i] = int.Parse(Console.ReadLine());
                    }

                    double average = Average(integers);
                    Console.WriteLine("The average of the integers : " + average);
                    break;
                case 3:
                    Console.WriteLine("Enter the coefficients of the linear equation a * x + b = 0");

                    Console.Write("a = ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("b = ");
                    double b = double.Parse(Console.ReadLine());

                    double x = SolveEquation(a, b);
                    Console.WriteLine("x = " + x);
                    break;
                case 4:
                    quit = true;
                    break;
            }

            if (quit == true)
            {
                break;
            }
        }
    }

    static decimal Reverse(decimal input)
    {
        if (input < 0)
        {
            throw new FormatException();
        }

        char[] number = input.ToString().ToCharArray();
        Array.Reverse(number);
        string result = new string(number);

        return Convert.ToDecimal(result);
    }

    static double Average(double[] input)
    {
        if (input.Length == 0)
        {
            throw new FormatException();
        }

        double result = 0;
        double sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            sum += input[i];
        }

        result = sum / input.Length;

        return result;
    }

    static double SolveEquation(double a, double b)
    {
        if (a == 0)
        {
            throw new FormatException();
        }

        double result = -b / a;
        return result;

    }
}