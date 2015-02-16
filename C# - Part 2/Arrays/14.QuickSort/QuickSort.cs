//Write a program that sorts an array of strings using the Quick sort algorithm.

using System;
using System.Linq;

class QuickSort
{
    static void Main()
    {
        string[] myArr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

        myQuickSort(myArr, 0, myArr.Length - 1);

        Console.WriteLine(string.Join(", ", myArr));
    }

    public static void myQuickSort(IComparable[] elements, int left, int right)
    {
        int i = left, j = right;

        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                IComparable temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            myQuickSort(elements, left, j);
        }

        if (i < right)
        {
            myQuickSort(elements, i, right);
        }
    }
}