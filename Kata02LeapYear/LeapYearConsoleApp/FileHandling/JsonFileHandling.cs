using Newtonsoft.Json;

namespace LeapYearConsoleApp.FileHandling
{
    public class JsonFileHandling : IJsonFileHandling
    {
        public void GenerateJsonFile(List<LeapYearEntity> data, string fileName)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);

            var fullPath = Path.Combine(fileName);

            File.WriteAllText(fullPath, json);
        }
    }
}
