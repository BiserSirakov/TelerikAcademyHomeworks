

using System;

class MaximalKsum
{
    static void Main()
    {
        Console.Write("Enter N : ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter K : ");
        int K = int.Parse(Console.ReadLine());

        if (K >= N)
        {
            return;
        }

        int[] arr = new int[N];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter the elements of the array : ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        for (int i = arr.Length - K ; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i != arr.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}