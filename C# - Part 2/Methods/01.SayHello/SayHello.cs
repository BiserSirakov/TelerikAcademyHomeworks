//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;

class SayHello
{
    static void Main()
    {
        Console.Write("Enter your name : ");
        string name = Console.ReadLine();

        Console.Write("Hello, {0} !", PrintName(name));
        Console.WriteLine();
    }

    private static string PrintName(string name)
    {
        return name;
    }
}