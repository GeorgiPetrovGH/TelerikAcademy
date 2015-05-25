/*
Problem 22. Words count

Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class CountWords
    {
        static void Main(string[] args)
        {
            string str = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            var dict = new Dictionary<string, int>();

            foreach (Match word in Regex.Matches(str, @"\w+"))
                dict[word.Value] = dict.ContainsKey(word.Value) ? dict[word.Value] + 1 : 1;

            foreach (var pair in dict)
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }

