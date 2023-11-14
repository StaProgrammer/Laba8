using System.Collections.Generic;

public interface IDataExporter
{
    void ExportData(List<Person> data, string fileName);
}