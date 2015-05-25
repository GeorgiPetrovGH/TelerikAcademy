/*
Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
 */

using System;
using System.IO;
class SortNames
{
    static void Main()
    {
        string input = @"..\..\input.txt";
        string output = @"..\..\output.txt";

        try
        {
            StreamReader reader = new StreamReader(input);
            StreamWriter writer = new StreamWriter(output);

            using (reader)
            {
                using (writer)
                {
                    string text = reader.ReadToEnd();  
                    string[] array = text.Split(' ','\n');
                    
                    Array.Sort(array);
                    for (int i = 0; i < array.Length; i++)
                    {
                        writer.WriteLine(array[i]);
                    }
                }
            }
            Console.WriteLine("Sorting completed.");
        }
        catch (Exception)
        {
            Console.WriteLine("Error!");
        }
    }    
}

