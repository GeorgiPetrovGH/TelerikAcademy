/*
Problem 12. Remove words

Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;
class RemoveForbiddenWords
{
    static void Main()
    {
        string file = @"..\..\file.txt";
        string fileForbiddenWords = @"..\..\ForbiddenWords.txt";
        string output = @"..\..\output.txt";

        try
        {
            StreamReader reader01 = new StreamReader(file);
            StreamReader reader02 = new StreamReader(fileForbiddenWords);
            
            string line = null;
            string[] forbiddenWords = null;
           
            using (reader02)
            {
                line = reader02.ReadToEnd();
                forbiddenWords = line.Split('\n', ' ');
                for (int i = 0; i < forbiddenWords.Length; i++)
                {
                    forbiddenWords[i] = forbiddenWords[i].Trim('\r', '\n');
                }
            }
            
            using (reader01)
            {
                line = reader01.ReadToEnd();
                for (int i = 0; i < forbiddenWords.Length; i++)
                {
                    line = line.Replace(forbiddenWords[i], "");
                }
                line = line.Replace("  ", " ");
            }
            
            StreamWriter writer = new StreamWriter(output);
            using (writer)
            {
                writer.WriteLine(line);
            }
            Console.WriteLine("Words removed succesfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}

