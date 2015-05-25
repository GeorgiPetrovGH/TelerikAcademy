/*
Problem 11. Prefix "test"

Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;
class RemovePrefix
{
    static void Main()
    {
        string file = @"..\..\file.txt";
        string output = @"..\..\output.txt";

        Regex regex = new Regex(@"\btest[\w\d]*");
        string line = null;      

        try
        {
            StreamReader reader = new StreamReader(file);
            using (reader)
            {
                line = reader.ReadToEnd();
                line = regex.Replace(line, "");
            }
            StreamWriter writer = new StreamWriter(output);
            using (writer)
            {
                writer.WriteLine(line);
            }
            Console.WriteLine("Successesful replacing!");
        }
        catch (Exception)
        {
            Console.WriteLine("Error!");
        }
    }
}

