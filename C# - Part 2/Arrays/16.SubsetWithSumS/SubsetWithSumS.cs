//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.

using System;
using System.Linq;
using System.IO;

class SubsetWithSumS
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

        int mySum = int.Parse(Console.ReadLine());

        int sum = 0;
        bool equal = false;

        for (int i = 0; i < Math.Pow(2, arr.Length) - 1; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    sum += arr[j];
                }

                if (sum == mySum)
                {
                    equal = true;
                }
            }
            sum = 0;
        }

        if (equal)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}