//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
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

        Console.Write("Enter the element : ");
        int element = int.Parse(Console.ReadLine());

        Array.Sort(arr);

        int min = 0;
        int max = arr.Length - 1;
        int mid = min + ((max - min) / 2);

        bool isFound = false;

        while (min <= max)
        {
            mid = min + ((max - min) / 2);

            if (arr[mid] < element)
            {
                min = mid + 1;
                continue;
            }
            else if (arr[mid] > element)
            {
                max = mid - 1;
                continue;
            }
            else if (arr[mid] == element)
            {
                isFound = true;
                break;
            }
        }

        if (isFound)
        {
            Console.WriteLine(mid);
        }

        else
        {
            Console.WriteLine("Value not found!");
        }
    }
}