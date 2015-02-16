//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("hexadecimal number = ");
        string hexNum = Console.ReadLine();

        int element = 0;
        long decNum = 0;


        for (int i = 0; i < hexNum.Length; i++)
        {
            switch (hexNum[i])
            {
                case 'A': element = 10;
                    break;
                case 'B': element = 11;
                    break;
                case 'C': element = 12;
                    break;
                case 'D': element = 13;
                    break;
                case 'E': element = 14;
                    break;
                case 'F': element = 15;
                    break;
                default: element = int.Parse(hexNum[i].ToString());
                    break;
            }

            decNum += element * (long)Math.Pow(16, (hexNum.Length - 1 - i));

        }

        Console.WriteLine("decimal = " + decNum);

        Console.ReadLine();
    }
}
