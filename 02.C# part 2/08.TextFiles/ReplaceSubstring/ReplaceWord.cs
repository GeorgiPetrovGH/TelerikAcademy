/*
Problem 7. Replace sub-string

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
 */

using System;
using System.IO;
class ReplaceWord
{
    static void Main()
    {
        string file = @"..\..\file.txt";
        string output = @"..\..\output.txt";

         try
        {
            StreamReader reader = new StreamReader(file);
            StreamWriter writer = new StreamWriter(output);

            using (reader)
            {
                string line = reader.ReadLine();
                using (writer)
                {
                    while (line != null)
                    {
                        string fixedLine = FixLine(line);
                        writer.WriteLine(fixedLine);
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Fixing finished.");
        }
         catch (Exception)
         {
             Console.WriteLine("Error!");
         }
    }

    static string FixLine(string line)
    {
        line = line.Replace("start", "finish");
        return line;
    }
}

