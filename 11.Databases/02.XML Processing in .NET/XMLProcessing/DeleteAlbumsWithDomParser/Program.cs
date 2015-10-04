using System;
using System.Xml;

class Program
{
    static void Main()
    {
        var catalogue = new XmlDocument();
        catalogue.Load("../../../catalogue.xml");

        var albums = catalogue.DocumentElement;

        foreach (XmlNode album in albums)
        {
            var albumPrice = decimal.Parse(album["price"].InnerText);
            if (albumPrice > 20)
            {
                albums.RemoveChild(album);
            }
        }

        catalogue.Save("../../../catalogWithDeletedAlbums.xml");  
    }
}

