/*
Problem 9. Delete odd lines

Write a program that deletes from given text file all odd lines.
The result should be in the same file.
 */

using System;
using System.IO;
class DelOddLines
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
                using (writer)
                {
                    int lineCnt = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineCnt++;
                        if (lineCnt % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Odd lines deleted");
        }
        catch (Exception)
        {
            Console.WriteLine("Error!");
        }
    }
}

