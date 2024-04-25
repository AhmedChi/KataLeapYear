using Newtonsoft.Json;

namespace LeapYearConsoleApp.FileHandling
{
    public class JsonFileHandling : IJsonFileHandling
    {
        public void GenerateJsonFile(List<LeapYearEntity> data, string fileName)
        {           
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);

            var fullPath = Path.Combine(@"D:\Documents\Archives\Work\src main\.Net\Kata\KataLeapYear\KataLeapYear", fileName);

            File.WriteAllText(fullPath, json);
        }
    }
}
