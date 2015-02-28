//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        try
        {
            WebClient webCilend = new WebClient();

            Console.Write("Enter a link to download from : ");
            string link = Console.ReadLine();

            Console.Write("Enter the name of the file : ");
            string name = Console.ReadLine();

            webCilend.DownloadFile(link, name);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WebException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}