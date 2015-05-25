/*
Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
*/

using System;

class SubStringCount
{
    static void Main()
    {
        string targetStr = "in";
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine(CountSubString(text.ToLower(), targetStr.ToLower()));
    }

    static int CountSubString(string text, string target) 
    {
        int cnt = 0;        
        for (int i = 0; i < text.Length; i++)
        {
            int found = text.IndexOf(target, i);
            if (found > 0) 
            {
                cnt++;
                i = found + 1;
            }
        }
        return cnt;
    }
}

