//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace _06.DivisibleBy7and3
{
    using System;
    using System.Linq;

    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter the length of the array : ");
            int len = int.Parse(Console.ReadLine());

            int[] arrayOfIntegers = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write("Enter number #{0} : ", i);
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());
            }

            var result = arrayOfIntegers.Where(x => x % 7 == 0 || x % 3 == 0);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
