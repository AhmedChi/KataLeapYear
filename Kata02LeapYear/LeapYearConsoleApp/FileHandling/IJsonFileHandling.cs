
namespace LeapYearConsoleApp.FileHandling
{
    public interface IJsonFileHandling
    {
        void GenerateJsonFile(List<LeapYearEntity> data, string fileName);
    }
}