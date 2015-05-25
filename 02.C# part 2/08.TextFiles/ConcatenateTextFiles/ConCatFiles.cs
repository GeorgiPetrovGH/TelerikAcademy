/*
Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.
 */

using System;
using System.IO;
class ConCatFiles
{
    static void Main()
    {
        string file01path = @"..\..\file01.txt";
        string file02path = @"..\..\file02.txt";
        string file03path = @"..\..\ConcatFile.txt";

        try
        {
            StreamReader file01Reader = new StreamReader(file01path);
            StreamReader file02Reader = new StreamReader(file02path);
            StreamWriter writer = new StreamWriter(file03path);

            string f1;
            string f2;
            using (file01Reader)
            {
                f1 = file01Reader.ReadToEnd();
            }
            using (file02Reader)
            {
                f2 = file02Reader.ReadToEnd();
            }
            using (writer)
            {
                writer.WriteLine(f1);
                writer.WriteLine(f2);
            }
            Console.WriteLine("Successesful concatenation!");
        }
        catch (Exception)
        {
            Console.WriteLine("Error!");
        }
    }
}

