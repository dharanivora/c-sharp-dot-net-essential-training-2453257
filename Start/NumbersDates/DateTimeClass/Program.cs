// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time
using System.Xml;

Console.WriteLine($"Current date and time is {DateTime.Now}");

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
Console.WriteLine($"Today is {DateTime.Today}");

// TODO: DateOnly and TimeOnly represent just dates and times
Console.WriteLine($"{DateTime.MinValue}");
Console.WriteLine($"{DateTime.MaxValue}");

DateOnly d = DateOnly.FromDateTime(DateTime.Now);
TimeOnly t = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"{d}");
Console.WriteLine($"{t}");

// TODO: Dates have properties that can be inspected
Console.WriteLine(DateTime.Today);

// TODO: Dates also have methods to change their values
var date = DateTime.Today;
Console.WriteLine(date.AddDays(15));

// TODO: The TimeSpan class represents a duration of time
DateTime AprilFools = new DateTime(DateTime.Now.Year, 4, 1);
DateTime NewYears = new DateTime(DateTime.Now.Year, 1, 1);
TimeSpan interval = AprilFools - NewYears;
Console.WriteLine(interval);

// TODO: Dates can be compared using regular operators
Console.WriteLine(AprilFools == NewYears);