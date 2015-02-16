//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the other number : ");
        double number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("The greater of them is : {0}", Math.Max(number1,number2));

        Console.ReadLine();
    }
}
