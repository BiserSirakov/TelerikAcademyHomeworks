//Write a program that finds the most frequent number in an array.

using System;

class FrequentNumber
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

        Array.Sort(arr);

        int counter = 0;
        int howManyTimes = 0;
        int number = 0;

        for (int i = 0; i < arr.Length - 1; i++) // when we check arr[i] and arr[i + 1] : < arr.length - 1 ( else - exception )
        {
            if (arr[i] == arr[i + 1])
            {
                counter++;

                if (howManyTimes <= counter)
                {
                    howManyTimes = counter;
                    number = arr[i];
                }
            }
            else
            {
                counter = 0;
            }
        }

        Console.WriteLine("{0} ({1} times)", number, howManyTimes + 1);
    }
}