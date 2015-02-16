//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;

class SumOFnNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you will enter : ");
        double Nnumbers = double.Parse(Console.ReadLine());
        
        double sum = 0;
        
        for (int i = 1; i <= Nnumbers; i++)
        {
            Console.Write("Enter #{0} number : ", i);
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("Their sum is : " + sum);

        Console.ReadLine();
    }
}
