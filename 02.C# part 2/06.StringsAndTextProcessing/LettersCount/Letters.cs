/*
Problem 21. Letters count

Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
*/

using System;
using System.Linq;
class Letters
{
    static char[] alphabet = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
    static int[] cntLetters = new int[26];
    static void Main()
    {
        string text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
        CountLetters(text.ToLower());
        PrintCountLetters();
    }
    static void CountLetters(string text) 
    {
        foreach (char ch in text)
        {
            if(alphabet.Contains(ch))
            {
                cntLetters[ch-'a']++;
            }
        }
    }
    static void PrintCountLetters() 
    {
        for (int i = 0; i<cntLetters.Length; i++)
        {
            Console.WriteLine("{0}: {1} times",alphabet[i], cntLetters[i]);
        }
    }
}

