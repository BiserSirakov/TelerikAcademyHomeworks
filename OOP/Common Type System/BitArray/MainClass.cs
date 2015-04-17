//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace BitArray
{
    using System;

    class MainClass
    {
        static void Main()
        {
            BitArray64 first = new BitArray64(255u);
            BitArray64 second = new BitArray64(100u);
            BitArray64 third = new BitArray64(255u);

            Console.WriteLine("first : " + first);
            Console.WriteLine("second : " + second);
            Console.WriteLine("third : " + third);

            Console.Write("\nfirst == second : ");
            Console.WriteLine(first == second);
            Console.Write("first != second : ");
            Console.WriteLine(first != second);

            Console.WriteLine("\nHashcode of the first one : " + first.GetHashCode());
            Console.WriteLine("Hashcode of the second one : " + second.GetHashCode());
            Console.WriteLine("Hashcode of the third one : " + third.GetHashCode());

            Console.Write("\nfirst.Equals(third) : ");
            Console.WriteLine(first.Equals(third));
            Console.Write("second.Equals(third) : ");
            Console.WriteLine(second.Equals(third));

            Console.WriteLine();
            third[0] = 0;
            Console.WriteLine(third);
        }
    }
}
