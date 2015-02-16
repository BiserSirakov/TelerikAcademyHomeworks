//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a four-digit number : ");
        int number = int.Parse(Console.ReadLine());

        int fourthDigit = number % 10;
        int thirdDigit = (number % 100) / 10;
        int secondDigit = (number % 1000) / 100;
        int firstDigit = (number % 10000) / 1000;

        if (number >= 1000 && number <= 9999)
        {
            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            Console.WriteLine("The sum of digits = " + sum);

            Console.WriteLine("Reversed number : " + fourthDigit + thirdDigit + secondDigit + firstDigit);

            Console.WriteLine("Last digit in front : " + fourthDigit + firstDigit + secondDigit + thirdDigit);

            Console.WriteLine("Second and third digits exchanged : " + firstDigit + thirdDigit + secondDigit + fourthDigit);
        }
        else
        {
            Console.WriteLine("You have to enter a four-digit number !");
        }

        Console.ReadLine();
    }
}
