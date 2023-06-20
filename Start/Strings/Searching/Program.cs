// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for searching string content

using System.Security.AccessControl;

string teststr = "The quick brown Fox jumps over the lazy Dog";

// TODO: Contains determines whether a string contains certain content
Console.WriteLine($"{teststr.Contains("fox")}");
Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}");

// TODO: StartsWith and EndsWith determine if a string starts 
// or ends with a given test string
Console.WriteLine($"{teststr.StartsWith("the")}");
Console.WriteLine($"{teststr.StartsWith("the", StringComparison.CurrentCultureIgnoreCase)}");

Console.WriteLine($"{teststr.EndsWith("dog")}");
Console.WriteLine($"{teststr.EndsWith("dog", StringComparison.CurrentCultureIgnoreCase)}");

// TODO: IndexOf, LastIndexOf finds the index of a substring
Console.WriteLine($"{teststr.IndexOf("the", StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"{teststr.LastIndexOf("the", StringComparison.CurrentCultureIgnoreCase)}");

// TODO: Determining empty, null, or whitespace
string str1 = null;
string str2 = "   ";
string str3 = String.Empty;
string str4 = "";
Console.WriteLine($"{string.IsNullOrEmpty(str1)}");  // true
Console.WriteLine($"{string.IsNullOrEmpty(str2)}");  // false
Console.WriteLine($"{string.IsNullOrEmpty(str3)}");  // true
Console.WriteLine($"{string.IsNullOrEmpty(str4)}");  // true
Console.WriteLine($"------------------------------");
Console.WriteLine($"{string.IsNullOrWhiteSpace(str1)}");  // true
Console.WriteLine($"{string.IsNullOrWhiteSpace(str2)}");  // true
Console.WriteLine($"{string.IsNullOrWhiteSpace(str3)}");  // true
Console.WriteLine($"{string.IsNullOrWhiteSpace(str4)}");  // true