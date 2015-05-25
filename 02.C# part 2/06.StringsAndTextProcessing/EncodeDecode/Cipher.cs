/*
Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
the second – with the second, etc. When the last key character is reached, the next is the first.
*/

using System;
using System.Text;
class Cipher
{
    static void Main(string[] args)
    {
        string text = "TELERIKACADEMY";
        string cipher = "SOFTWARE";

        //string text = Console.ReadLine();
        //string cipher = Console.ReadLine();

        Console.WriteLine(EncodeDecode(text, cipher).ToString());
    }

    static StringBuilder EncodeDecode(string text, string key) 
    {
        StringBuilder result = new StringBuilder();
        int maxLen = Math.Max(text.Length, key.Length);
        for (int i = 0; i < maxLen; i++)
        {
            char textSymbol = text[i % text.Length];
            char keySymbol = key[i % key.Length];
            result.Append((char)(textSymbol ^ keySymbol));
        }
        return result;
    }
}

