/*
Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.
 */

using System;
using System.IO;
class CompareLines
{
    static void Main()
    {
        string file01 = @"..\..\file01.txt";
        string file02 = @"..\..\file02.txt";

        try
        {
            StreamReader reader01 = new StreamReader(file01);
            StreamReader reader02 = new StreamReader(file02);
            int equal = 0;
            int notEqual = 0;
            using (reader01) 
            {
                using (reader02) 
                {
                    string line01 = reader01.ReadLine();
                    string line02 = reader02.ReadLine();
                    while (line01 != null && line02 != null)
                    {
                        if (line01.Equals(line02))
                        {
                            equal++;
                        }
                        else
                        {
                            notEqual++;
                        }
                        line01 = reader01.ReadLine();
                        line02 = reader02.ReadLine();
                    }
                }
            }
            Console.WriteLine("Equal lines: {0}",equal);
            Console.WriteLine("Not equal lines: {0}", notEqual);
        }
        catch (Exception)
        {
            Console.WriteLine("Error!");
        }
    }
}

