/*
Problem 13. Count words

Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
class CountTheWords
{
    static void Main()
    {
        string words = @"..\..\words.txt";
        string test = @"..\..\test.txt";
        string result = @"..\..\result.txt";

        Dictionary<string, int> wordDictionary = new Dictionary<string, int>();
        Regex regex; 
        string line = null;
        string[] wordsToCount;        

        try
        {
            StreamReader reader01 = new StreamReader(words);
            StreamReader reader02 = new StreamReader(test);
            StreamWriter writer = new StreamWriter(result);            

            using (reader02)
            {
                line = reader02.ReadToEnd();
                wordsToCount = line.Split('\n', ' ');
                for (int i = 0; i < wordsToCount.Length; i++)
                {
                    wordsToCount[i] = wordsToCount[i].Trim('\r', '\n');
                }
            }

            using (reader01)
            {
                line = reader01.ReadToEnd();
                for (int i = 0; i < wordsToCount.Length; i++)
                {
                    regex = new Regex(wordsToCount[i]);
                    MatchCollection matches = Regex.Matches(line, wordsToCount[i], RegexOptions.Multiline);
                    wordDictionary.Add(wordsToCount[i], matches.Count);
                }
            }

            var sortedDict = (from entry in wordDictionary orderby entry.Value descending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);
            using (writer)
            {
                foreach (var item in sortedDict)
                {
                    writer.WriteLine("{0} - {1}", item.Key, item.Value);
                }
            }
            Console.WriteLine("Successesful counting.");
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}

