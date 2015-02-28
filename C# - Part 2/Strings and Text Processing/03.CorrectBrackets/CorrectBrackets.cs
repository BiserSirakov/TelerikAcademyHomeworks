//Write a program to check if in a given expression the brackets are put correctly.

using System;
using System.Text.RegularExpressions;

class CorrectBrackets
{
    static void Main(string[] args)
    {
        Console.Write("Enter an expression: ");
        string input = Console.ReadLine();

        bool result = BracketsAreCorrect(input);

        if (result)
        {
            Console.WriteLine("Correct.");
        }
        else
        {
            Console.WriteLine("Incorrect.");
        }
    }

    private static bool BracketsAreCorrect(string expression)
    {
        int bracketCount = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                ++bracketCount;
            }
            else if (expression[i] == ')')
            {
                --bracketCount;
            }
            if (bracketCount < 0)
            {
                return false;
            }
        }

        return bracketCount == 0;
    }
}