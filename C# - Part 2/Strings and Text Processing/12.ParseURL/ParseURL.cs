//Write a program that parses an URL address given in the format: 
//[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

using System;

class ParseURL
{
    static void Main()
    {
        Console.Write("Enter URL : ");
        string input = Console.ReadLine();

        Uri url = new Uri(input);
        string protocol = url.Scheme;
        string server = url.Host;
        string resource = url.AbsolutePath;

        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + resource);
    }
}