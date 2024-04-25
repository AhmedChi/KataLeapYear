using LeapYearConsoleApp.Businesslogic;
using System;

var leapYearobject = new LeapYear();

try
{
    var currentYear = DateTime.Now.Year;

    for (int year = 1; year <= currentYear; year++)
    {
        var isLeapYear = leapYearobject.IsLeapYear(year);
        Console.WriteLine($"Year: {year},\nLeapYear: {isLeapYear}");
    }
    
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}


