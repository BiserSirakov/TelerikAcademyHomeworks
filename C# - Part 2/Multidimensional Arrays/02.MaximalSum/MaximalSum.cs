﻿//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter M = ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Matrix[{0},{1}] = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int currSum = 0;
        int maxSum = 0;
        int maxX = 0;
        int maxY = 0;

        int p = 3;
        int q = 3;

        for (int i = 0; i < n - p + 1; i++)
        {
            for (int j = 0; j < m - q + 1; j++)
            {
                currSum = 0;

                for (int k = 0; k < p; k++)
                {
                    for (int l = 0; l < q; l++)
                    {
                        currSum += matrix[i + k, j + l];
                    }
                }

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    maxX = i;
                    maxY = j;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Maximal sum is in window[{0},{1}-{2},{3}] in the array is: {4}", maxX, maxY, maxX + p - 1, maxY + q - 1, maxSum);
    }
}