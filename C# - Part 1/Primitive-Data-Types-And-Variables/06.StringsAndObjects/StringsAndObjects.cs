using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object sentence = hello + " " + world;
        string helloworld = (string)sentence;
        Console.WriteLine(helloworld);
        Console.ReadLine();
    }
}
