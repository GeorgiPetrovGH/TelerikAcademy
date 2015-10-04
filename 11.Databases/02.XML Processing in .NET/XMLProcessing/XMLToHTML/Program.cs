using System;
using System.Xml.Xsl;
class Program
{
    static void Main()
    {
        string styleSheetPath = "../../../catalogueStyleSheet.xsl";
        string catalogXmlPath = "../../../catalogue.xml";
        string catalogHtmlPath = "../../../catalogue.html";

        XslCompiledTransform xslt = new XslCompiledTransform();
        xslt.Load(styleSheetPath);
        xslt.Transform(catalogXmlPath, catalogHtmlPath);
    }
}

