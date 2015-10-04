using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
class Program
{
    static void Main()
    {
        string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        var directoryTraversal = Traverse(directoryPath);
        directoryTraversal.Save("../../../traverseDirectoryWithLinq.xml");

        Console.WriteLine("Result saved in traverseDirectoryWithLinq.xml in main directory.");
    }

    private static XElement Traverse(string directoryPath)
    {
        var element = new XElement("dir", new XAttribute("name", new DirectoryInfo(directoryPath).Name));

        foreach (var directory in Directory.GetDirectories(directoryPath))
        {
            element.Add(Traverse(directory));
        }

        foreach (var file in Directory.GetFiles(directoryPath))
        {
            var currentFile = new XElement("file",
            new XAttribute("name", Path.GetFileName(file)),
            new XAttribute("type", Path.GetExtension(file)));

            element.Add(currentFile);
        }

        return element;
    }
}

