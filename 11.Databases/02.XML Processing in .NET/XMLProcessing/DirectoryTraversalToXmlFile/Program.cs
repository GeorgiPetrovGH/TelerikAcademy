using System;
using System.IO;
using System.Text;
using System.Xml;
class Program
{
    static void Main()
    {
        string xmlFilePath = "../../../traverseDirectory.xml";

        using (var writer = new XmlTextWriter(xmlFilePath, Encoding.UTF8))
        {
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 1;
            writer.IndentChar = '\t';


            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            writer.WriteStartDocument();
            writer.WriteStartElement("dir");
            writer.WriteAttributeString("name", new DirectoryInfo(directoryPath).Name);

            Traverse(directoryPath, writer);

            writer.WriteEndElement();
            writer.WriteEndDocument();

        }

        Console.WriteLine("Result saved in traverseDirectory.xml in main directory.");
    }

    private static void Traverse(string directoryPath, XmlTextWriter writer)
    {
        foreach (var directory in Directory.GetDirectories(directoryPath))
        {
            writer.WriteStartElement("dir");
            writer.WriteAttributeString("name", new DirectoryInfo(directory).Name);
            Traverse(directory, writer);
            writer.WriteEndElement();
        }

        foreach (var file in Directory.GetFiles(directoryPath))
        {
            writer.WriteStartElement("file");
            writer.WriteAttributeString("name", Path.GetFileName(file));
            writer.WriteAttributeString("type", Path.GetExtension(file));
            writer.WriteEndElement();
        }
    }
}

