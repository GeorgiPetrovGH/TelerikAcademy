/*
Problem 14.* Print the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange)
and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
*/

using System;
 class AsciiTable
    {
        static void Main()
        {
            for (int i = 0; i <= 255; i++)
            {
                char code = (char) i;
                Console.WriteLine(i + " " + code);
            }
        }
    }

