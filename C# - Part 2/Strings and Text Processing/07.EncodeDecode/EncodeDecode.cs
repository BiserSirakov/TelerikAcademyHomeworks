//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        Console.Write("Enter a text : ");
        string input = Console.ReadLine();

        Console.Write("Enter a cipher : ");
        string cipher = Console.ReadLine();

        string encoded = EncodeAndDecode(input, cipher);
        string decoded = EncodeAndDecode(cipher, input);

        Console.WriteLine("Encoded : " + encoded);
        Console.WriteLine("Decoded : " + decoded);
    }

    static string EncodeAndDecode(string input, string cipher)
    {
        StringBuilder result = new StringBuilder();
        int inputLetter;
        int cipherLetter;
        for (int i = 0; i < input.Length; i++)
        {
            inputLetter = (int)input[i]; // taking the ascii code of every letter
            cipherLetter = (int)cipher[i % cipher.Length]; // this way we take the first letter of the cipher after the last one
            result.Append((char)(inputLetter ^ cipherLetter));
        }
        return result.ToString();
    }
}