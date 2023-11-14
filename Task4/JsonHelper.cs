using System;
using System.Collections.Generic;

public class JsonExporter
{
    public void ExportToJson(List<Person> data, string fileName)
    {
        Console.WriteLine("Exporting to JSON...");
    }
}

public class JsonImporter
{
    public List<Person> ImportFromJson(string fileName)
    {
        Console.WriteLine("Importing from JSON...");
        return new List<Person>();
    }
}

public class JsonDataExporter : IDataExporter
{
    private readonly JsonExporter _jsonExporter;

    public JsonDataExporter(JsonExporter jsonExporter)
    {
        _jsonExporter = jsonExporter;
    }

    public void ExportData(List<Person> data, string fileName)
    {
        _jsonExporter.ExportToJson(data, fileName);
    }
}

public class JsonDataImporter : IDataImporter
{
    private readonly JsonImporter _jsonImporter;

    public JsonDataImporter(JsonImporter jsonImporter)
    {
        _jsonImporter = jsonImporter;
    }

    public List<Person> ImportData(string fileName)
    {
        return _jsonImporter.ImportFromJson(fileName);
    }
}
