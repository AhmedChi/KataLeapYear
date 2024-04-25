
namespace LeapYearConsoleApp.FileHandling
{
    public interface ICSVFileHandling
    {
        void GenerateCsvFile(List<LeapYearEntity> data, string fileName);
    }
}