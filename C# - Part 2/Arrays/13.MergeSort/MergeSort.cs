//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

class MergeSort
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

        arr = MergeSortAlgorithm(arr);
        Console.WriteLine(string.Join(", ", arr));
    }

    private static int[] MergeSortAlgorithm(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }

        int middle = arr.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[arr.Length - middle];
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < middle)
            {
                left[i] = arr[i];
            }
            else
            {
                right[i - middle] = arr[i];
            }
        }

        left = MergeSortAlgorithm(left);
        right = MergeSortAlgorithm(right);

        return Merge(left, right);
    }

    private static int[] Merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int i, j;
        for (i = 0, j = 0; i < left.Length && j < right.Length; )
        {
            if (left[i] < right[j])
            {
                result[i + j] = left[i];
                i++;
            }
            else
            {
                result[i + j] = right[j];
                j++;
            }
        }

        for (; i < left.Length; i++)
        {
            result[i + j] = left[i];
        }

        for (; j < right.Length; j++)
        {
            result[i + j] = right[j];
        }

        return result;
    }
}