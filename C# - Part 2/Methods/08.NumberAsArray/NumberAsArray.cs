//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Linq;
using System.Collections.Generic;

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter a positive integer (max 10 000 digits) : ");
        string num1 = Console.ReadLine();

        Console.Write("Enter another positive integer (max 10 000 digits) : ");
        string num2 = Console.ReadLine();

        if (isCorrect(num1) && isCorrect(num2))
        {
            List<int> result = AccumulateTwoNumbers(num1, num2);

            Console.Write("\nTheir sum is : ");
            for (int i = result.Count - 1; i >= 0; i--) // In the method the result is reversed
            {
                Console.Write(result[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        else
        {
            throw new FormatException();
        }
    }

    static bool isCorrect(string number)
    {
        bool isCorrect = true;

        if (number == "0" || number.Length > 10000)
        {
            isCorrect = false;
        }

        return isCorrect;
    }

    static List<int> AccumulateTwoNumbers(string number1, string number2)
    {
        int[] a = number1.Select(s => s - '0').ToArray();
        int[] b = number2.Select(s => s - '0').ToArray();

        Array.Reverse(a); // So that the last digit is kept in arr[0]
        Array.Reverse(b);

        List<int> result = new List<int>(Math.Max(a.Length, b.Length));

        int left = 0;

        for (int i = 0; i < result.Capacity; i++)
        {
            int num = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0) + left;
            left = num / 10;
            result.Add(num % 10);
        }

        if (left > 0)
        {
            result.Add(left);
        }

        return result;
    }
}