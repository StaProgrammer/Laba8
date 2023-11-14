using System;
using System.Collections.Generic;
public class CsvExporter
{
    public void ExportToCsv(List<Person> data, string fileName)
    {
        Console.WriteLine("Exporting to CSV...");
    }
}

public class CsvImporter
{
    public List<Person> ImportFromCsv(string fileName)
    {
        Console.WriteLine("Importing from CSV...");
        return new List<Person>();
    }
}

public class CsvDataExporter : IDataExporter
{
    private readonly CsvExporter _csvExporter;

    public CsvDataExporter(CsvExporter csvExporter)
    {
        _csvExporter = csvExporter;
    }

    public void ExportData(List<Person> data, string fileName)
    {
        _csvExporter.ExportToCsv(data, fileName);
    }
}

public class CsvDataImporter : IDataImporter
{
    private readonly CsvImporter _csvImporter;

    public CsvDataImporter(CsvImporter csvImporter)
    {
        _csvImporter = csvImporter;
    }

    public List<Person> ImportData(string fileName)
    {
        return _csvImporter.ImportFromCsv(fileName);
    }
}
