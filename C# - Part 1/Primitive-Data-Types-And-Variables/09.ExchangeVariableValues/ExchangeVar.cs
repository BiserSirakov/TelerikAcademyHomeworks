using System;

class ExchangeVar
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        c = a; // a = 5, b = 10, c = 5
        a = b; // a = 10, b = 10, c = 5
        b = c; // a = 10, b = 5, c = 5

        Console.WriteLine("\nThen a = {0}", a);
        Console.WriteLine("Then b = {0}", b);

        Console.ReadLine();
    }
}
