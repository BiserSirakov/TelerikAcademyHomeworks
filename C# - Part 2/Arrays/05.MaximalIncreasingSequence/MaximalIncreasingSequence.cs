//Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Linq;
using System.IO;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

        int start = 0;
        int sequence = 1;
        int maxSequence = 1;

        string[] tempIncrArr = new string[arr.Length];
        string[] maxIncrArr = new string[arr.Length];

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                sequence++;
            }
            else
            {
                sequence = 1;
                start = 0;
                tempIncrArr = new string[arr.Length];
            }

            if (sequence > maxSequence)
            {
                maxSequence = sequence;
                tempIncrArr[start] += arr[i] + ", ";
                maxIncrArr[start] = tempIncrArr[start];
                start++;
                maxIncrArr[start] += arr[i + 1];
            }
        }

        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write(maxIncrArr[i]);
        }

        Console.WriteLine();
    }
}
