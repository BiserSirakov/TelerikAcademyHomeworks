//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
//and has the same functionality as Substring in the class String.

namespace _01.StringBuilderSubstring
{
    using System;
    using System.Text;

    class MainClass
    {
        static void Main()
        {
            StringBuilder someSB = new StringBuilder("This is some StringBuilder"); 

            Console.WriteLine(someSB.Substring(8, 4));
            Console.WriteLine(someSB.Substring(0,7));
        }
    }
}
