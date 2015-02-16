//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("decimal = ");
        long decimalNum = long.Parse(Console.ReadLine());

        string binaryNumber = "";

        if (decimalNum != 0)
        {
            while (decimalNum > 0)
            {
                binaryNumber += Convert.ToString(decimalNum % 2);
                decimalNum /= 2;
            }

            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                Console.Write("binary = " + binaryNumber[i]);
            }

            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("binary = 0");
        }

        Console.ReadLine();
    }
}
