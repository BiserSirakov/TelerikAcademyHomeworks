//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("binary = ");
        string binaryNum = Console.ReadLine();

        long decimalNum = 0;

        for (int i = 0; i < binaryNum.Length; i++)
        {
            decimalNum += long.Parse(binaryNum[i].ToString()) * (long)Math.Pow(2, binaryNum.Length - 1 - i);
        }

        Console.WriteLine("decimal = " + decimalNum);

        Console.ReadLine();
    }
}
