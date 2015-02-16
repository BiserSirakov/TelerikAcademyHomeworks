using System;

class LongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        {
            int number = 2;

            if (i % 2 == 0)
            {
                number = i;
            }
            else
            {
                number = -i;
            }

            Console.Write(number + ", ");
        }

        Console.ReadLine();
    }
}
