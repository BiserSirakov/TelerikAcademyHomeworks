//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

namespace _17.LongestString
{
    using System;
    using System.Linq;

    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter the length of the array : ");
            int len = int.Parse(Console.ReadLine());

            string[] arrayOfStrings = new string[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write("Enter element [{0}] : ", i);
                arrayOfStrings[i] = Console.ReadLine();
            }

            var maxString = arrayOfStrings.OrderBy(x => x.Length).ToArray();

            Console.WriteLine("The longest string is : " + maxString.Last());
        }
    }
}
