using System.Collections.Generic;

public class DataConverterAdapter : IDataConverter
{
    private readonly IDataExporter _dataExporter;
    private readonly IDataImporter _dataImporter;

    public DataConverterAdapter(IDataExporter dataExporter, IDataImporter dataImporter)
    {
        _dataExporter = dataExporter;
        _dataImporter = dataImporter;
    }

    public void ConvertData(string sourceFileName, string destinationFileName)
    {
        var data = _dataImporter.ImportData(sourceFileName);
        _dataExporter.ExportData(data, destinationFileName);
    }
}