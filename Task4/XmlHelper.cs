using System;
using System.Collections.Generic;

public class XmlExporter
{
    public void ExportToXml(List<Person> data, string fileName)
    {
        Console.WriteLine("Exporting to XML...");
    }
}

public class XmlImporter
{
    public List<Person> ImportFromXml(string fileName)
    {
        Console.WriteLine("Importing from XML...");
        return new List<Person>();
    }
}

public class XmlDataExporter : IDataExporter
{
    private readonly XmlExporter _xmlExporter;

    public XmlDataExporter(XmlExporter xmlExporter)
    {
        _xmlExporter = xmlExporter;
    }

    public void ExportData(List<Person> data, string fileName)
    {
        _xmlExporter.ExportToXml(data, fileName);
    }
}

public class XmlDataImporter : IDataImporter
{
    private readonly XmlImporter _xmlImporter;

    public XmlDataImporter(XmlImporter xmlImporter)
    {
        _xmlImporter = xmlImporter;
    }

    public List<Person> ImportData(string fileName)
    {
        return _xmlImporter.ImportFromXml(fileName);
    }
}
