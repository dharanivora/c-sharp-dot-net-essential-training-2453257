// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for manipulating string content

string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = { "one", "two", "three", "four" };

// TODO: Length of a string 
// Console.WriteLine($"Length if {nameof(str1)} is {str1.Length}");
// Console.WriteLine($"Length if {nameof(str2)} is {str2.Length}");
// Console.WriteLine($"Length if {nameof(str3)} is {str3.Length}");
// Console.WriteLine($"Length if {nameof(strs)} is {strs.Length}");

// TODO: Access individual characters
// Console.WriteLine(str1[14]);

// TODO: Iterate over a string like any other sequence of values
foreach (var @char in str2)
{
    // Console.Write($"{@char} ");
}

// TODO: String Concatenation         
string? outstr = default;
// Console.WriteLine("\n--->" + outstr);
outstr += str1;
// Console.WriteLine(outstr);

// Console.WriteLine($"{string.Concat(strs)}");

// TODO: Joining strings together with Join
// Console.WriteLine(string.Join("***", str1, str2, str3));

// TODO: String Comparison
var s1 = "Hello!";
var s2 = "Hello!";
var s3 = "hello!";
// Console.WriteLine($"{s1.Equals(s1)}");
// Console.WriteLine($"{s1 == s2}");

// Console.WriteLine($"{s1.Equals(s2)}");
// Console.WriteLine($"{s1 == s2}");

// Console.WriteLine($"{s1.Equals(s3)}");
// Console.WriteLine($"{s1 == s3}");

// Equals just returns a regular Boolean
// bool isEqual = str2.Equals(str3);  // false
// Console.WriteLine($"{isEqual}");

// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order
Console.WriteLine($"{string.Compare("Hello!", "hello!", StringComparison.InvariantCulture)}");
Console.WriteLine($"{string.Compare("Hello!", "hello!", StringComparison.InvariantCultureIgnoreCase)}");
Console.WriteLine($"{string.Compare("Hello!", "hello!", StringComparison.CurrentCulture)}");
Console.WriteLine($"{string.Compare("Hello!", "hello!", StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"{string.Compare("Hello!", "hello!", StringComparison.Ordinal)}");
Console.WriteLine($"{string.Compare("Hello!", "hello!", StringComparison.OrdinalIgnoreCase)}");

// TODO: Replacing content
