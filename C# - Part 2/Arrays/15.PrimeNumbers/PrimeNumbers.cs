//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

﻿using System;
using System.Linq;

class PrintNumbers
{
    static void Main()
    {
        bool[] arr = new bool[10000000];

        for (int i = 2; i < Math.Sqrt(arr.Length); i++)
        {
            if (arr[i] == false)
            {
                for (int j = i * i; j < arr.Length; j = j + i)
                {
                    arr[j] = true;
                }
            }
        }

        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] == false)
            {
                Console.WriteLine("{0} ", i);
            }
        }
    }
}