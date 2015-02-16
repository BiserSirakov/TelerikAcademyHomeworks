//write a program that applies bonus score to given score in the range [1…9] by the following rules:
//if the score is between 1 and 3, the program multiplies it by 10.
//if the score is between 4 and 6, the program multiplies it by 100.
//if the score is between 7 and 9, the program multiplies it by 1000.
//if the score is 0 or more than 9, the program prints “invalid score”.

using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter a score [1;9] : ");
        int score = int.Parse(Console.ReadLine());

        switch (score)
        {
            case 1:
            case 2:
            case 3:
                score *= 10;
                Console.WriteLine("Score with bonus = " + score);
                break;
            case 4:
            case 5:
            case 6:
                score *= 100;
                Console.WriteLine("Score with bonus = " + score);
                break;
            case 7:
            case 8:
            case 9:
                score *= 1000;
                Console.WriteLine("Score with bonus = " + score);
                break;
            default: Console.WriteLine("Invalid score!");
                break;
        }

        Console.ReadLine();
    }
}
