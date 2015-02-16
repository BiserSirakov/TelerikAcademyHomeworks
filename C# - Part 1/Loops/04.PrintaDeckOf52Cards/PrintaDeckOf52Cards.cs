﻿/*Problem 4. Print a Deck of 52 Cards
Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.*/

using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            char card = 'J';

            switch (i)
            {
                case 12:
                    card = 'Q';
                    break;
                case 13:
                    card = 'K';
                    break;
                case 14:
                    card = 'A';
                    break;
            }

            if (i <= 10)
            {
                int counter = 1;

                while (counter <= 4)
                {
                    char suit = '\u2663';

                    switch (counter)
                    {
                        case 1:
                            suit = '\u2663';
                            break;
                        case 2:
                            suit = '\u2666';
                            break;
                        case 3:
                            suit = '\u2665';
                            break;
                        case 4:
                            suit = '\u2660';
                            break;
                    }

                    Console.Write("{0, 3}{1}", i, suit);
                    counter++;
                }

                Console.WriteLine();
            }
            else
            {
                int counter = 1;
                while (counter <= 4)
                {
                    char suit = '\u2663';
                    switch (counter)
                    {
                        case 1:
                            suit = '\u2663';
                            break;
                        case 2:
                            suit = '\u2666';
                            break;
                        case 3:
                            suit = '\u2665';
                            break;
                        case 4:
                            suit = '\u2660';
                            break;
                        default:
                            break;
                    }

                    Console.Write("{0, 3}{1}", card, suit);
                    counter++;
                }

                Console.WriteLine();
            }
        }

        Console.ReadLine();
    }
}