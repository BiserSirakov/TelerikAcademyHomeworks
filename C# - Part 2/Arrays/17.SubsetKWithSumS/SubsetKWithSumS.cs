//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

class SubsetKWithSumS
{
    static void Main()
    {
        Console.WriteLine("Enter N : ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];

        Console.WriteLine("Enter K : ");
        int K = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter S : ");
        int S = int.Parse(Console.ReadLine());

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter the elements of the array : ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int count = 0;
        bool equal = false;

        for (int i = 0; i < Math.Pow(2, arr.Length) - 1; i++)
        {
            int sum = 0;
            int counter = 0;

            for (int j = 0; j < arr.Length && !equal; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = (nAndMask >> j);
                if (bit == 1)
                {
                    sum += arr[j];
                    counter++;
                }
            }

            if (counter == K && sum == S)
            {
                equal = true;
                count += counter;
            }
        }

        if (equal)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}