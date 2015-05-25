/*
Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
*/
using System;

class Letters
{
    static int findIndex(ref char[] array, char symbol) 
    {        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == symbol) 
            {
                return i;
            }           
        }
        return -1;        
    }

    static void Main()
    {
        char[] array = new char[26];
        for (int i = 0; i < 26; i++)
        {
            int letter = 'A' + i;
            array[i] = Convert.ToChar(letter);            
        }

        for (int i = 0; i < 26; i++)
        {
            Console.Write("{0} ", Convert.ToString(i).PadLeft(2));
        }
        Console.WriteLine();
        foreach (char symbol in array)
        {
            Console.Write("{0} ", Convert.ToString(symbol).PadLeft(2));
        }
        Console.WriteLine();
        
        string word = "HELLO";
        foreach (char symbol in word)
        {            
            int index = findIndex(ref array, symbol);
            Console.Write("{0} ", index);
        }
        Console.WriteLine();
    }
}

