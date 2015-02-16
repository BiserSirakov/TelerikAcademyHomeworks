using System;

class ASCII
{
    static void Main()
    {
        for (int character = 0; character <= 255; character++)
        {
            char symbol = (char)character;
            Console.WriteLine("{0} -> {1}", character, symbol);
        }

        Console.ReadLine();
    }
}
