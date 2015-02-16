//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("decimal = ");
        long decNum = long.Parse(Console.ReadLine());

        string hexNum = "";

        if (decNum != 0)
        {
            while (decNum > 0)
            {
                long reminder = decNum % 16;

                switch (reminder)
                {
                    case 10: hexNum += 'A';
                        break;
                    case 11: hexNum += 'B';
                        break;
                    case 12: hexNum += 'C';
                        break;
                    case 13: hexNum += 'D';
                        break;
                    case 14: hexNum += 'E';
                        break;
                    case 15: hexNum += 'F';
                        break;
                    default: hexNum += reminder.ToString();
                        break;
                }

                decNum /= 16;
            }

            Console.Write("hexadecimal = ");

            for (int i = hexNum.Length - 1; i >= 0; i--)
            {
                Console.Write(hexNum[i]);
            }
        }

        else
        {
            Console.WriteLine("hexadecimal = 0");
        }
        

        Console.ReadLine();
    }
}
