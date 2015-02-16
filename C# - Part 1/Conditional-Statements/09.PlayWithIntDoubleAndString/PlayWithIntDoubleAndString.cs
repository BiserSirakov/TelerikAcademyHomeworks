//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.Write("Please choose a type (1 --> int, 2 --> double, 3 --> string) : ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.Write("Please enter an integer : ");
                int iNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Entered integer : " + iNumber);
                break;

            case 2: Console.Write("Please enter a double : ");
                double dNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter double : " + dNumber);
                break;

            case 3: Console.Write("Please enter a string : ");
                string str = Console.ReadLine();
                Console.WriteLine("Entered string : " + str + "*");
                break;

            default: Console.WriteLine("You must enter a value from 1 to 3 !");
                break;
        }

        Console.ReadLine();
    }
}
