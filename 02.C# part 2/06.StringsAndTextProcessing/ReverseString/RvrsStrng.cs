/*
Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
*/
using System;
class RvrsStrng
{
    static void Main()
    {
        string str = "sample";
        Console.WriteLine(ReverseString(str));
    }

    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

