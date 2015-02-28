//Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;

class ExtractTextFromXML
{
    static void Main()
    {
        string file = @"D:\new  2.xml";
        
        using (StreamReader reader = new StreamReader(file))
        {
            string line = reader.ReadLine();
            string extract = string.Empty;

            while (line != null)
            {
                for (int i = 1; i < line.Length; i++)
                {
                    if (line[i - 1] == '>')
                    {
                        while (line[i] != '<')
                        {
                            extract += line[i];
                            i++;
                        }

                        if (extract != "")
                        {
                            Console.WriteLine(extract.TrimStart(' '));
                            extract = "";
                        }
                    }
                }

                line = reader.ReadLine();
            }
        }
    }
}