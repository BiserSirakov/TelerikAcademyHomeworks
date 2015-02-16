//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class Calculate
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        int nFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            double xPow = Math.Pow(x, i);

            nFactorial *= i;

            sum += nFactorial / xPow;
        }

        //int counter = 1;

        //while (counter <= n)
        //{
        //    factorial *= counter;  }--->  is the same as the upper loop
        //    counter++;
        //}

        Console.WriteLine("S = {0:0.00000}", sum);

        Console.ReadLine();
    }
}
