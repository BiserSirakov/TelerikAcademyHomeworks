//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        StreamReader reader1 = new StreamReader(@"D:\New Text Document.txt");
        StreamReader reader2 = new StreamReader(@"D:\New Text Document (2).txt");

        string txt1 = reader1.ReadToEnd();
        string txt2 = reader2.ReadToEnd();
        string txt3 = txt1 + txt2;

        File.WriteAllText(@"D:\New Text Document (3).txt", txt3);
    }
}