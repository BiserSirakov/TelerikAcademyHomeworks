//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

class LargerThanNeighbours
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

        Console.Write("Enter the position of the element you want to check \n(it can`t be the first or the last one) = ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Is the element larger than its neighbours --> {0}", Neighbours(numbers, position));
    }

    private static bool Neighbours(int[] numbers, int position)
    {
        bool result = false;

        if (position <= 0 && position >= numbers.Length - 1)
        {
            throw new IndexOutOfRangeException("It can`t be the first or the last one!");
        }

        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int positionInArray = Array.IndexOf(numbers, numbers[i]);

                if (position == positionInArray && 
                    numbers[positionInArray].CompareTo(numbers[positionInArray - 1]) > 0 && 
                    numbers[positionInArray].CompareTo(numbers[positionInArray + 1]) > 0)
                {
                    result = true;
                }
            }
        }

        return result;
    }
}