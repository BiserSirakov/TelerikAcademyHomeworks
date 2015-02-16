using System;

    class PrintSequence
    {
        static void Main()
        {
            int number = 0;
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    number = i;
                }

                else
                {
                    number = -i;
                }

                Console.Write(number);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
