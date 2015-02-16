//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Enter the length of the array : ");
        int n = int.Parse(Console.ReadLine());

        string[] arr = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the elements of the array : ");
            arr[i] = Console.ReadLine();
        }

        Console.WriteLine();

        SortByLength(arr);
    }

    private static void SortByLength(string[] arr)
    {
        Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Array[{0}] = {1} ", i, arr[i]);
        }
    }
}