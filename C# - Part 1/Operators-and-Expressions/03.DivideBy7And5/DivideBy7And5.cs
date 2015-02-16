//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Check whether the integer can be divided by 7 and 5 (without remainder)");
        Console.Write("Enter the integer : ");
        int number = int.Parse(Console.ReadLine());
        bool isDevided;

        if (number % 7 == 0 && number % 5 == 0 && number != 0)
        {
            isDevided = true;
            Console.WriteLine(isDevided);
        }
        else
        {
            isDevided = false;
            Console.WriteLine(isDevided);
        }

        Console.ReadLine();
    }
}
