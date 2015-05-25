/*
Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
*/

using System;
using System.Collections.Generic;
class Brackets
{
    static void Main()
    {
        string strCorrect = "((a+b)/5-d)";
        string strNotCorrect = "(a-b)*(a+b))";
        Console.WriteLine("Is string {0} correct?", strCorrect);
        Console.WriteLine(CheckBrackets(strCorrect));
        Console.WriteLine("Is string {0} correct?", strNotCorrect);
        Console.WriteLine(CheckBrackets(strNotCorrect));
    }

    static bool CheckBrackets(string str)
    {
        Stack<char> stackBrackets = new Stack<char>();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '(')
            {
                stackBrackets.Push(str[i]);
            }
            if (str[i] == ')')
            {
                if (stackBrackets.Count > 0)
                { 
                    stackBrackets.Pop(); 
                }
                else { return false; }
            }
        }
        if (stackBrackets.Count == 0) { return true; }
        return false;
    }
}

