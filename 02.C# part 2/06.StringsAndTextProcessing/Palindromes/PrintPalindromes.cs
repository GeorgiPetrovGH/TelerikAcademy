/*
Problem 20. Palindromes

Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
*/

using System;
class PrintPalindromes
{
    static void Main()
    {
        string text = "some text first palindrom exe another stuff? lamal, abba more text!";
        string[] words = text.Split(' ', ',', '.', '!', '?');
        foreach (var item in words)
        {
            if (Palindrome(item)) 
            {
                Console.WriteLine(item);
            }
        }
    }

    static bool Palindrome(string str)
    {
        if (str == "") return false;
        for (int i = 0; i < str.Length / 2; i++)
            if (str[i] != str[str.Length - 1 - i])
                return false;
        return true;
    }
}

