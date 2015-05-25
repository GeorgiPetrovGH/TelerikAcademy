/*
Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
*/

using System;
using System.Text;
class HTMLTags
{
    static void Main()
    {
        string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        Console.WriteLine(ReplaceTags(text));
    }
    static string ReplaceTags(string text) 
    {
        StringBuilder result = new StringBuilder(text);
        result.Replace("<a href=\"", "[URL=");
        result.Replace("</a>", "[/URL]");
        result.Replace("\">", "]");
        return result.ToString();
    }
}


