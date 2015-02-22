//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstLargerThanNeighbours
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

        Console.WriteLine(FirstPositionNeighbours(numbers));
    }

    private static int FirstPositionNeighbours(int[] numbers)
    {
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (Neighbours(numbers, i))
            {
                return i;
            }
        }
        return -1;
    }

    private static bool Neighbours(int[] numbers, int position)
    {
        bool result = false;

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

        return result;
    }
}