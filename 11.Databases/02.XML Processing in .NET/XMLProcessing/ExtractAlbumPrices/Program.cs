using System;
using System.Xml;
class Program
{
    static void Main()
    {
        var catalogue = new XmlDocument();
        catalogue.Load("../../../catalogue.xml");

        int targetYear = DateTime.Now.Year - 5;

        string xPathQuery = "/catalogue/album[year <= " + targetYear + "]";

        XmlNodeList albumsOlderThanFourYears = catalogue.SelectNodes(xPathQuery);

        foreach (XmlNode album in albumsOlderThanFourYears)
        {
            Console.WriteLine("Album name: {0}, Artist: {1} Year: {2}, Price: {3}",
                album["name"].InnerText, album["artist"].InnerText, album["year"].InnerText, album["price"].InnerText);
        }
    }
}

