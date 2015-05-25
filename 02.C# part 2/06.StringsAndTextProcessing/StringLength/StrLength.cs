/*
Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. 
If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.
*/


using System;
using System.Text;
class StrLength
{
    static void Main()
    {
        string str = "lessThan20Symbols";
        if (str.Length < 20) 
        {
            StringBuilder sb = new StringBuilder(str);
            for (int i = str.Length; i < 20; i++)
            {
                sb.Append("*");
            }
            Console.WriteLine(sb.ToString());
        }
        else 
        {
            Console.WriteLine(str);
        }
    }
}

