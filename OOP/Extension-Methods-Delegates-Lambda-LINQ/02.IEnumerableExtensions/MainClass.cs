//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class MainClass
    {
        static void Main()
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("List : " + string.Join(", ", list));
            Console.WriteLine("Sum : " + list.Sum());
            Console.WriteLine("Product : " + list.Product());
            Console.WriteLine("Min : " + list.MinElement());
            Console.WriteLine("Max : " + list.MaxElement());
            Console.WriteLine("Average : " + list.AverageValue());
        }
    }
}
