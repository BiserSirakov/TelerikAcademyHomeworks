//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a positive number to check if it is prime : ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime;

        if (number < 2)
        {
            isPrime = false;
            Console.WriteLine(isPrime);
        }
        else if (number == 2)
        {
            isPrime = true;
            Console.WriteLine(isPrime);
        }  
        else if (number > 2)
        {
            for (int i = 2; i <= (int)Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
                else
                {
                    isPrime = true;
                }
                Console.WriteLine(isPrime);
            }
        }

        Console.ReadLine();
    }
}