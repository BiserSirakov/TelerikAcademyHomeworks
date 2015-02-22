//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;

class SortingArray
{
    static void Main()
    {
        Console.Write("Enter the length of the array : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the elements of the array : ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        Console.Write("Enter the index to start from : ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("The maximal element in the array is : {0}", MaxElement(numbers, index));
        Console.WriteLine();

        SortArray(numbers);

        Console.Write("The array sorted in descending order: ");
        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.Write("The array sorted in ascending order: ");
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    private static int MaxElement(int[] arr, int index)
    {
        int maxElement = 0;

        for (int i = index; i < arr.Length - 1; i++)
        {
            int currentMax = Math.Max(arr[i], arr[i + 1]);
            if (currentMax >= maxElement)
            {
                maxElement = currentMax;
            }
        }

        return maxElement;
    }

    private static void SortArray(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int temp = arr[i];
            int index = Array.IndexOf(arr, MaxElement(arr, i));
            arr[i] = arr[index];
            arr[index] = temp;
        }
    }
}