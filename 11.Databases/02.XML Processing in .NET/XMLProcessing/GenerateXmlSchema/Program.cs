using System;
using System.Xml.Linq;
using System.Xml.Schema;
class Program
{
    static void Main()
    {
        XmlSchemaSet schemas = new XmlSchemaSet();
        schemas.Add(string.Empty, "../../../catalogueSchema.xsd");

        XDocument validCatalog = XDocument.Load("../../../catalogue.xml");
        XDocument invalidCatalog = XDocument.Load("../../../catalogueInvalid.xml");

        bool errors = false;
        string errorMessage = string.Empty;
        validCatalog.Validate(schemas, (cat, ev) =>
        {
            errorMessage = ev.Message;
            errors = true;
        });

        Console.WriteLine("validCatalog -> {0}. {1}", errors ? "invalid" : "validated", errorMessage);

        invalidCatalog.Validate(schemas, (cat, ev) =>
        {
            errorMessage = ev.Message;
            errors = true;
        });

        Console.WriteLine("invalidCatalog -> {0}. {1}", errors ? "invalid" : "validated", errorMessage);
    }
}

