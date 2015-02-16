//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Linq;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter the elements of the array seperated by comma and space : ");

        string input = Console.ReadLine();//"2, 1, 1, 2, 3, 3, 2, 2, 2, 1";

        string[] numsStr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[numsStr.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numsStr[i]);
        }

        int currentNum, maxNum = numbers[0];
        int currentCount, maxCount = 0;

        for (int i = 0; i < numbers.Length; )
        {
            currentNum = numbers[i];
            currentCount = 0;

            for (; i < numbers.Length; i++)
            {
                if (currentNum != numbers[i])
                {
                    break;
                }

                currentCount++;
            }

            if (maxCount <= currentCount)
            {
                maxCount = currentCount;
                maxNum = currentNum;
            }
        }

        for (int i = 0; i < maxCount; i++)
        {
            Console.Write(maxNum);
            if (i != maxCount - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}