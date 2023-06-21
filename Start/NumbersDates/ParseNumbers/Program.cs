// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for parsing numerical data from strings

string[] NumStrs = { "  1 ", " 1.45  ", "-100", "5e+04 " };

int testint;
float testfloat;
bool result;

// TODO: The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful

// TODO: The TryParse method returns 'true' if the parse is successful
foreach (string str in NumStrs)
{
    if (string.IsNullOrEmpty(str))
    {
        throw new ArgumentException("String is null or empty.");
    }

    var parsedInt = int.TryParse(str, out int intNumber);
    var parsedFloat = float.TryParse(str, out float floatNumber);

    if (parsedInt)
    {
        Console.WriteLine($"Parsed integer: {intNumber}");
    }
    else if (parsedFloat)
    {
        Console.WriteLine($"Parsed float: {floatNumber}");
    }
}


