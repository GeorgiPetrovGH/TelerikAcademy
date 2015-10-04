using System;
using System.Xml;

class Program
{
    static void Main()
    {
        Console.WriteLine("Song list:");
        Console.WriteLine(new string('*', 30));
        using (var reader = XmlReader.Create("../../../catalogue.xml"))
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element 
                    && reader.Name == "title")
                {
                    Console.WriteLine(reader.ReadElementString());
                }
            }
        }
    }
}

