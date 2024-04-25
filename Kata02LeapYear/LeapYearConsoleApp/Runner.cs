using LeapYearConsoleApp.Businesslogic;
using LeapYearConsoleApp.FileHandling;

namespace LeapYearConsoleApp
{

    public class Runner
    {
        private readonly IJsonFileHandling _jsonFileHandling;
        private readonly ICSVFileHandling _csvFileHandling;

        private readonly ILeapYear _leapYear;

        public Runner(ILeapYear leapYear, ICSVFileHandling csvFileHandling, IJsonFileHandling jsonFileHandling)
        {
            _csvFileHandling = csvFileHandling;
            _jsonFileHandling = jsonFileHandling;

            _leapYear = leapYear;
        }

        public void Run()
        {
            var currentYear = DateTime.Now.Year;

            var isLeapYearlist = new List<LeapYearEntity>();

            for (int year = 1; year <= currentYear; year++)
            {
                var isLeapYear = _leapYear.IsLeapYear(year);

                if(isLeapYear == true)
                {
                    isLeapYearlist.Add(new LeapYearEntity { Year = year, IsLeapYear = "Yes" });
                } else
                {
                    isLeapYearlist.Add(new LeapYearEntity { Year = year, IsLeapYear = "No" });
                }

            }

            _jsonFileHandling.GenerateJsonFile(isLeapYearlist, "isLeapYearJsonFile");
            _csvFileHandling.GenerateCsvFile(isLeapYearlist, "isLeapYearCsvFile");
        }
    }
}
