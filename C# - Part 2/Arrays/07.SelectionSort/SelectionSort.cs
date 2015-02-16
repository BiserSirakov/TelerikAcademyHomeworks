//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, 
//move it at the second position, etc.

using System;
using System.Linq;

class SelectionSort
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

        int minElement;
        int minIndex = -1; // prosto nqkakuv ( razlichen ot sluchaite dolu )

        for (int i = 0; i < arr.Length; i++)
        {
            minElement = int.MaxValue; // resetvame promenlivata kato q vkarvame v cikula
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (minElement > arr[j])
                {
                    minElement = arr[j];
                    minIndex = j;
                }
            }

            int temp = arr[i];
            arr[i] = minElement;
            arr[minIndex] = temp;
        }

        Console.WriteLine(string.Join(", ", arr));
    }
}