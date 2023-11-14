using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var csvExporter = new CsvExporter();
        var xmlExporter = new XmlExporter();
        var jsonExporter = new JsonExporter();

        var csvImporter = new CsvImporter();
        var xmlImporter = new XmlImporter();
        var jsonImporter = new JsonImporter();

        var csvDataExporter = new CsvDataExporter(csvExporter);
        var xmlDataExporter = new XmlDataExporter(xmlExporter);
        var jsonDataExporter = new JsonDataExporter(jsonExporter);

        var csvDataImporter = new CsvDataImporter(csvImporter);
        var xmlDataImporter = new XmlDataImporter(xmlImporter);
        var jsonDataImporter = new JsonDataImporter(jsonImporter);

        var converters = new Dictionary<string, IDataConverter>
        {
            { "CSV to XML", new DataConverterAdapter(xmlDataExporter, csvDataImporter) },
            { "CSV to JSON", new DataConverterAdapter(jsonDataExporter, csvDataImporter) },
            { "XML to CSV", new DataConverterAdapter(csvDataExporter, xmlDataImporter) },
            { "XML to JSON", new DataConverterAdapter(jsonDataExporter, xmlDataImporter) },
            { "JSON to CSV", new DataConverterAdapter(csvDataExporter, jsonDataImporter) },
            { "JSON to XML", new DataConverterAdapter(xmlDataExporter, jsonDataImporter) }
        };

        Console.WriteLine("Available conversions:");
        int i = 1;
        foreach (var conversion in converters.Keys)
        {
            Console.WriteLine($"{i}. {conversion}");
            i++;
        }

        int choice;
        do
        {
            string userInput = ConsoleHelper.GetUserInput("Enter the number of the conversion you want to perform: ");
            if (int.TryParse(userInput, out choice) && choice >= 1 && choice <= converters.Count)
            {
                break;
            }

            ConsoleHelper.DisplayMessage("Invalid choice. Please enter a valid number.");
        } while (true);

        var selectedConverter = converters.Values.ElementAt(choice - 1);

        string sourceFileName = ConsoleHelper.GetUserInput("Enter the source file name: ");
        string destinationFileName = ConsoleHelper.GetUserInput("Enter the destination file name: ");

        selectedConverter.ConvertData(sourceFileName, destinationFileName);
    }
}
