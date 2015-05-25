/*
Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
*/

using System;
using System.Text;
class ChangeToUnicodeChar
{
    static void Main()
    {
        string text = "Hi!";
        Console.WriteLine(ChangeToUnicode(text));
    }

    static string ChangeToUnicode(string text)
    {
        StringBuilder result = new StringBuilder();
        foreach (char ch in text)
        {
            int temp = ch + '\0';
            string tempStr = string.Format("\\u{0:X4}", temp);
            result.Append(tempStr);
        }
        return result.ToString();
    }
}

