using System.Collections.Generic;

public interface IDataImporter
{
    List<Person> ImportData(string fileName);
}