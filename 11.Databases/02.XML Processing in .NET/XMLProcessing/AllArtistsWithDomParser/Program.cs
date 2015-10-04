using System;
using System.Collections.Generic;
using System.Xml;
class Program
{
    static void Main()
    {
        var catalogue = new XmlDocument();
        catalogue.Load("../../../catalogue.xml");
        var root = catalogue.DocumentElement;

        var uniqueArtists = GetUniqueArtists(root);

        foreach (var artist in uniqueArtists)
        {
            Console.WriteLine("{0} - {1} album(s)", artist.Key, artist.Value);
        }
    }

    private static IDictionary<string, int> GetUniqueArtists(XmlElement root)
    {
        var artistsAndAlbums = new Dictionary<string, int>();
        var artists = root.GetElementsByTagName("artist");

        foreach (XmlElement artist in artists)
        {
            var artistName = artist.InnerText;

            if (artistsAndAlbums.ContainsKey(artistName))
            {
                artistsAndAlbums[artistName] += 1;
            }
            else
            {
                artistsAndAlbums.Add(artistName, 1);
            }
        }

        return artistsAndAlbums;
    }
}

