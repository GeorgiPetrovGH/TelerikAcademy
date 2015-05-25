/*
Problem 14. Word dictionary

A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
*/

using System;
using System.Collections.Generic;
class Dictionary
{
    static void Main()
    {
        IDictionary<string, string> dic = new Dictionary<string, string>();
        string word = ".NET";
        string definition = "platform for applications from Microsoft";
        dic.Add(word, definition);
        word = "CLR";
        definition = "managed execution environment for .NET";
        dic.Add(word, definition);
        word = "namespace";
        definition = "hierarchical organization of classes";
        dic.Add(word, definition);

        string word1 = "CLR"; 
        string result = string.Empty;
        dic.TryGetValue(word1, out  result);
        Console.WriteLine("{0} - {1}", word1, result);        
    }
}

