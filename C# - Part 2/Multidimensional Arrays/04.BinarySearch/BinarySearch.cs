//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.
//BinSearch() finds the largest number in the array which is ≤ K.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K = ");
        int k = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
                Console.Write("Enter the elements : ");
                numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        while (Array.BinarySearch(numbers, k) < 0)
        {
            k--;
        }

        Console.WriteLine("Result : " + k);

        
    }
}