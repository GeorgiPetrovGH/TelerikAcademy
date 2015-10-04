using System;
using System.Collections.Generic;
using System.Xml;
class Program
{
    static void Main()
    {
        var catalogue = new XmlDocument();
        catalogue.Load("../../../catalogue.xml");

        string xPathQuery = "/catalogue/album/artist";

        var allArtistsElements = catalogue.SelectNodes(xPathQuery);

        var uniqueArtists = GetUniqueArtists(allArtistsElements);
        foreach (var artist in uniqueArtists)
        {
            Console.WriteLine("{0} - {1} album(s)", artist.Key, artist.Value);
        }
    }

    private static Dictionary<string, int> GetUniqueArtists(XmlNodeList allArtists)
    {
        var result = new Dictionary<string, int>();
        foreach (XmlElement artist in allArtists)
        {
            string artistName = artist.InnerText;            
            if (result.ContainsKey(artistName))
            {
                result[artistName]++;
            }
            else
            {
                result.Add(artistName, 1);
            }
        }

        return result;
    }
}

