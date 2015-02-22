//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;

class IntegerCalculations
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

    private static decimal Product(decimal[] numbers)
    {
        decimal result = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            result *= numbers[i];
        }

        return result;
    }

    private static decimal Sum(decimal[] numbers)
    {
        decimal result = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }

        return result;
    }

    private static decimal Average(decimal[] numbers)
    {
        decimal result = 0;
        decimal sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        result = sum / numbers.Length;

        return result;
    }

    private static decimal Maximum(decimal[] numbers)
    {
        decimal maxElement = numbers[numbers.Length - 1];
        decimal currentMax = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            currentMax = Math.Max(numbers[i], numbers[i + 1]);
            if (currentMax > maxElement)
            {
                maxElement = currentMax;
            }
        }

        return maxElement;
    }

    private static decimal Minimum(decimal[] numbers)
    {
        decimal minElement = numbers[numbers.Length - 1];
        decimal currentMin = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            currentMin = Math.Min(numbers[i], numbers[i + 1]);
            if (currentMin < minElement)
            {
                minElement = currentMin;
            }
        }

        return minElement;
    }
}