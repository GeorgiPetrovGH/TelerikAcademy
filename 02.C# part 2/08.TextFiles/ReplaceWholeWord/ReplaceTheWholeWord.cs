/*
Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).
 */

using System;
using System.IO;
class ReplaceTheWholeWord
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
        line = line.Replace(" start ", " finish ");
        line = line.Replace("start ", "finish ");
        line = line.Replace(" start", " finish");
        return line;
    }
}

