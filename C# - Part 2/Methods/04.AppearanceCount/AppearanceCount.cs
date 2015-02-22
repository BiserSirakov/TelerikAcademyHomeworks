//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
{
    static void Main()
    {
        Console.Write("Enter the length of the array : ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the numbers = ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        AppearanceCounter(numbers);
    }

    private static void AppearanceCounter(int[] numbers)
    {
        Array.Sort(numbers);

        int counter = 0;
        int howManyTimes = 0;
        int number = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                counter++;

                if (howManyTimes <= counter)
                {
                    howManyTimes = counter;
                    number = numbers[i];
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