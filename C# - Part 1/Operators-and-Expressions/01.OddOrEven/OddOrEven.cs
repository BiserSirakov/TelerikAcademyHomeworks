//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter an integer : ");
        int number = int.Parse(Console.ReadLine());
        
        if (number % 2 == 0)
        {
            Console.WriteLine("The integer is even.");
        }
        else
        {
            Console.WriteLine("The integer is odd.");
        }

        Console.ReadLine();
    }
}
