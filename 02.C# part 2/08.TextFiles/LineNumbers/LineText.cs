/*
Problem 3. Line numbers

Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
 */

using System;
using System.IO;
class LineText
{
    static void Main()
    {
        string file01path = @"..\..\file.txt";
        string file02path = @"..\..\fileLines.txt";

        try
        {
            StreamReader reader = new StreamReader(file01path);
            StreamWriter writer = new StreamWriter(file02path);
            
            int cnt = 1;
            string line;
            using (reader)
            {
                line = reader.ReadLine();
                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine("Line {0:00} {1}", cnt, line);                        
                        cnt++;
                        line = reader.ReadLine();
                    }                    
                }
            }
            Console.WriteLine("Successesful lining!");
        }
        catch (Exception)
        {
            Console.WriteLine("Error!");
        }
    }
}

