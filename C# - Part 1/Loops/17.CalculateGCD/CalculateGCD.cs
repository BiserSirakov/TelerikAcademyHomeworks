//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;

    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            int gcdNumber = 0;
            int remainder;

            if (a > b)
            {
                while (b > 0)
                {
                    remainder = a % b;
                    a = b;
                    b = remainder;
                }

                gcdNumber = a;
            }

            else
            {
                while (a > 0)
                {
                    remainder = b % a;
                    b = a;
                    a = remainder;
                }

                gcdNumber = b;
            }

            Console.WriteLine("GCD (a, b) = " + gcdNumber);

            Console.ReadLine();
        }
    }
