//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Linq;

class NumberCalculations
{
    static void Main()
    {
        Console.Write("Enter the length of the sequence : ");
        int len = int.Parse(Console.ReadLine());

        decimal[] numbers = new decimal[len];

        for (int i = 0; i < len; i++)
        {
            Console.Write("Enter the number[{0}] = ", i);
            numbers[i] = decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine("The minimum number : " + Minimum(numbers));
        Console.WriteLine("The maximum number : " + Maximum(numbers));
        Console.WriteLine("The average of the numbers : " + Average(numbers));
        Console.WriteLine("The sum of the numbers : " + Sum(numbers));
        Console.WriteLine("The product of the numbers : " + Product(numbers));
    }

    private static K Product<K>(K[] numbers) where K : IComparable<K>
    {
        return numbers.Aggregate<K, dynamic>(1, (current, t) => current * t);
    }

    private static K Sum<K>(K[] numbers) where K : IComparable<K>
    {
        return numbers.Aggregate<K, dynamic>(0, (current, t) => current + t);
    }

    private static K Average<K>(K[] numbers) where K : IComparable<K>
    {
        var sum = numbers.Aggregate<K, dynamic>(0, (current, t) => current + t);
        return sum / numbers.Length;
    }

    private static K Maximum<K>(K[] numbers) where K : IComparable<K>
    {
        int maxIndex = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i].CompareTo(numbers[maxIndex]) == 1) maxIndex = i;
        }

        return numbers[maxIndex];
    }

    private static K Minimum<K>(K[] numbers) where K : IComparable<K>
    {
        int minIndex = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i].CompareTo(numbers[minIndex]) == -1) minIndex = i;
        }

        return numbers[minIndex];
    }
}