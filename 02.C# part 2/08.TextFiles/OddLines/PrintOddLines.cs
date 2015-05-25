/*
Problem 1. Odd lines

Write a program that reads a text file and prints on the console its odd lines.
 */

using System;
using System.IO;
class PrintOddLines
{
    static void Main()
    {
        string filepath = @"..\..\file.txt";
        try
        {
            StreamReader fileReader = new StreamReader(filepath);
            using (fileReader)
            {
                int lineCnt = 0;
                string line = fileReader.ReadLine();
                while (line != null)
                {
                    lineCnt++;
                    if (lineCnt % 2 == 1)
                    {
                        Console.WriteLine("Line {0}: {1}", lineCnt, line);
                    }
                    line = fileReader.ReadLine();
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error!");
        }
    }
}

