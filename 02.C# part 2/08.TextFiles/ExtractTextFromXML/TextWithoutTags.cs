/*
Problem 10. Extract text from XML

Write a program that extracts from given XML file all the text without the tags..
 */

using System;
using System.IO;
using System.Text.RegularExpressions;
class TextWithoutTags
{
    static void Main()
    {
        string file = @"..\..\file.txt";
        string output = @"..\..\output.txt";
        
        Regex regex = new Regex(@">(?<data>[\s\w\d#]+)<");
        string line = null;
        string extractedData = null;

        try
        {
            StreamReader reader = new StreamReader(file);
            StreamWriter writer = new StreamWriter(output);
            using (reader)
            {
                using (writer)
                {
                    line = reader.ReadLine();
                    Match data;
                    while (line != null)
                    {
                        data = regex.Match(line);
                        while (data.Success)
                        {
                            extractedData = data.Groups["data"].Value;
                            extractedData = extractedData.Trim();
                            writer.WriteLine(extractedData);
                            data = data.NextMatch();
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Extracting text without tags completed.");
        }
        catch (Exception)
        {
            Console.WriteLine("Error!");
        }
    }
}

