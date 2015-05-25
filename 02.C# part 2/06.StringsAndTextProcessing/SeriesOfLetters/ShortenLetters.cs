/*
Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
*/

using System;
using System.Text.RegularExpressions;
class ShortenLetters
    {
        static void Main()
        {
            string str = "aaaaabbbbbcdddeeeedssaa";

            Console.WriteLine(Regex.Replace(str, @"(\w)\1+", "$1"));
        }
    }

