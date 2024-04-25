using CsvHelper;
using System.Globalization;

namespace LeapYearConsoleApp.FileHandling
{
    public class CSVFileHandling : ICSVFileHandling
    {
        public void GenerateCsvFile(List<LeapYearEntity> data, string fileName)
        {
            var fullPath = Path.Combine(fileName);

            using (var writer = new StreamWriter(fullPath))

            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(data);
            }
        }
    }
}
