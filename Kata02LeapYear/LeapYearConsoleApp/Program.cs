using LeapYearConsoleApp;
using LeapYearConsoleApp.Businesslogic;
using LeapYearConsoleApp.FileHandling;

var jsonFileHandling = new JsonFileHandling();
var csvFileHandling = new CSVFileHandling();
var leapYear = new LeapYear();

var runnerobject = new Runner(leapYear, csvFileHandling, jsonFileHandling);

try
{
    runnerobject.Run();
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}


