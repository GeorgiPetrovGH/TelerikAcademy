using System;
using System.Linq;
using System.Xml.Linq;
class Program
{
    static void Main()
    {
        Console.WriteLine("Song list:");
        Console.WriteLine(new string('*', 30));

        var catalogue = XDocument.Load("../../../catalogue.xml");

        var titles = from title in catalogue.Descendants("title") select title.Value;

        foreach (var title in titles)
        {
            Console.WriteLine(title);
        }
    }
}

