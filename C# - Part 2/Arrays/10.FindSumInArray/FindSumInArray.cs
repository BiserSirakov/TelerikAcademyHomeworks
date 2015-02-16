//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class FindSumInArray
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

        Console.Write("Enter S:");
        int s = int.Parse(Console.ReadLine());

        int startIndex = 0;
        int endIndex = 0;
        int sum = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            sum += arr[i];
            startIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                sum += arr[j];
                endIndex = j;

                if (sum == s)
                {
                    for (int k = startIndex; k <= endIndex; k++)
                    {
                        Console.Write(arr[k] + ", ");
                    }

                    Console.WriteLine();
                    return;
                }
            }
            sum = 0;
        }

        Console.WriteLine("The sumS is not present in the array.");
    }
}