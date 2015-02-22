//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Collections.Generic;
using System.Linq;

class NFactorial
{
    static void Main()
    {
        Console.Write("Enter a number [1;100] : ");
        int number = int.Parse(Console.ReadLine());

        if (number < 1 || number > 100)
        {
            throw new FormatException("It must be in the range [1;100] !");
        }
        else
        {
            List<int> factorial = Fact(number);
            Console.WriteLine("{0}! = {1}", number, string.Join("", factorial));
        }
    }

    static List<int> Fact(int num)
    {
        int[] a = { 1 };
        int left = 0;

        for (int i = 1; i <= num; i++)
        {
            int[] b = i.ToString().Select(s => s - '0').ToArray();
            int[] c = new int[a.Length + b.Length];

            for (int k = a.Length - 1; k >= 0; k--)
            {
                for (int j = b.Length - 1; j >= 0; j--)
                {
                    c[a.Length - k + b.Length - j - 2] += a[k] * b[j];
                }
            }

            for (int j = 0; j < c.Length; j++)
            {
                int digits = c[j] + left;
                c[j] = digits % 10;
                left = digits / 10;
            }
            a = c;
            Array.Reverse(c);
        }

        int start = 0;
        while (a[start] == 0) start++;

        List<int> result = new List<int>();
        for (int i = start; i < a.Length; i++)
        {
            result.Add(a[i]);
        }
        return result;
    }
}