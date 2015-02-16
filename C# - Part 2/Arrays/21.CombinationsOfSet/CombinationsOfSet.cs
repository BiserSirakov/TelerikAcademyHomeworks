//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].

using System;

class CombinationsOfSet
{
    static void Main(string[] args)
    {
        Console.Write("Enter N : ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K : ");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[k];

        Combinations(arr, n, k, 0);
    }

    static void Combinations(int[] array, int n, int k, int index)
    {
        if (index == k)
        {
            bool distinct = true;

            int[] sortedArr = (int[])array.Clone();

            Array.Sort(sortedArr);

            for (int i = 1; i < sortedArr.Length; i++)
            {
                if (sortedArr[i] == sortedArr[i - 1] || array[i] < array[i - 1])
                {
                    distinct = false;
                }
            }

            if (distinct)
            {
                for (int i = 0; i < k; i++)
                {
                    Console.Write("{0} ", array[i]);
                }

                Console.WriteLine();
            }

            return;
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                Combinations(array, n, k, index + 1);
            }
        }
    }
}