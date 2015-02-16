//Write a program that finds the sequence of maximal sum in given array.

using System;
using System.Collections.Generic;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter the length of the array : ");
        int len = int.Parse(Console.ReadLine());

        int[] arr = new int[len];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter the elements of the array : ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = arr[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempStartIndex = 0;
        int maxSum = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = arr[i];
                tempStartIndex = i;
            }
            else
            {
                currentSum += arr[i];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = tempStartIndex;
                endIndex = i;
            }
        }

        Console.WriteLine("The sum is: {0} ", maxSum);

        Console.Write("The sequence is : ");

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(arr[i] + ", ");
        }
    }
}
