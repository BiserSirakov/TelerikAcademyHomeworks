//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
class CompareArrays
{
    static void Main()
    {
        bool areEqual = false;

        Console.Write("Enter the length of the first array : ");
        int len1 = int.Parse(Console.ReadLine());

        int[] arr1 = new int[len1];

        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write("Enter the elements of the first array : ");
            arr1[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the length of the second array : ");
        int len2 = int.Parse(Console.ReadLine());

        int[] arr2 = new int[len2];

        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write("Enter the elements of the second array : ");
            arr2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    areEqual = true;
                }
                else
                {
                    areEqual = false;
                }
            }
        }

        if (areEqual == true)
        {
            Console.WriteLine("They are equal.");
        }
        else
        {
            Console.WriteLine("They are not equal.");
        }
    }
}