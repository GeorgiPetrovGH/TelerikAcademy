/*
Problem 12. Parse URL

Write a program that parses an URL address given in the format: 
[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
*/

using System;
class URL
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";    

        string[] arr = ParseURL(url);
        Console.WriteLine("[protoco] = {0}\n[server] = {1}\n[resource] = {2}", arr[0], arr[1], arr[2]);
    }
    static string[] ParseURL(string text)
    {
        string[] result = new string[3];
        int end = text.IndexOf("://");
        result[0] = text.Substring(0, end);
        int start = text.IndexOf(".com");
        result[1] = text.Substring(end + 3, start - 3);
        result[2] = text.Substring(start + 4);
        return result;
    }
}

