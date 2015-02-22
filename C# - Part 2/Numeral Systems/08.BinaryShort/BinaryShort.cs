//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static string inBinary(ushort s)
    {
        string bin = "";

        for (int i = 0; i < 16; i++)
        {
            bin += s >> i & 1;
        }

        return bin;
    }

    static void Main()
    {
        Console.Write("Enter a number : ");
        ushort number = ushort.Parse(Console.ReadLine());

        Console.Write("Binary representation : ");
        Console.WriteLine(inBinary(number));
    }
}