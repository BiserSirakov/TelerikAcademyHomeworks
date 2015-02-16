using System;

class Null
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        bool isNull = nullInt == null && nullDouble == null;

        Console.WriteLine("Integer with value Null : " + nullInt);
        Console.WriteLine("Double with value Null : " + nullDouble);
        Console.WriteLine("Whether the integer and double have nullable values : " + isNull);

        nullInt = 52;
        nullDouble = 100.7;

        Console.WriteLine("Integer with new value: " + nullInt);
        Console.WriteLine("Double with new value: " + nullDouble);

        Console.ReadLine();
    }
}
