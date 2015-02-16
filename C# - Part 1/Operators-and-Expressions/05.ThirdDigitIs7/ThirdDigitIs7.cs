//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Check if the third (from right to left) digit of an integer is 7");
        Console.Write("Enter the integer : ");
        int number = int.Parse(Console.ReadLine());
        bool isThirdDigit7;

        if (number < 100)
        {
            isThirdDigit7 = false;
        }
        else
        {
            if ((number / 100) % 10 == 7)
            {
                isThirdDigit7 = true;
            }
            else
            {
                isThirdDigit7 = false;
            }
        }
        Console.WriteLine(isThirdDigit7);

        Console.ReadLine();
    }
}
