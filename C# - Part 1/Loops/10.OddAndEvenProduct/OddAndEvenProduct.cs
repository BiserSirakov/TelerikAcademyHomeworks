﻿/*Problem 10. Odd and Even Product
You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter sequence of numbers: ");
        string[] sequenceNumber = Console.ReadLine().Split();

        int productOddNumbers = 1;

        for (int i = 0; i < sequenceNumber.Length; i += 2)
        {
            productOddNumbers *= int.Parse(sequenceNumber[i]);
        }

        int productEvenNumbers = 1;

        for (int i = 1; i < sequenceNumber.Length; i += 2)
        {
            productEvenNumbers *= int.Parse(sequenceNumber[i]);
        }

        if (productOddNumbers == productEvenNumbers)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("product = {0}", productEvenNumbers);
        }

        else
        {
            Console.WriteLine("No");
            Console.WriteLine("odd_product = {0}", productOddNumbers);

            if (sequenceNumber.Length == 1)
            {
                Console.WriteLine("even_product = no even numbers");
            }
            else
            {
                Console.WriteLine("even_product = {0}", productEvenNumbers);
            }
        }

        Console.ReadLine();
    }
}