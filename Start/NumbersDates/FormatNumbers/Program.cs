﻿// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting numerical data in .NET

int[] quarters = { 1, 2, 3, 4 };
int[] sales = { 100000, 150000, 200000, 225000 };
double[] intlMixPct = { .386, .413, .421, .457 };
int val1 = 1234;
decimal val2 = 1234.5678m;

// Formatting numerical data: $"{<variable>,[alignment]:[format][precision]}"

// TODO: Specifying Numerical formatting
// General format is {index[,alignment]:[format]}
// Common types are N (Number), G (General), F (Fixed-point), 
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)
// Console.WriteLine($"{val1:N}, {val1:G}, {val1:F}, {val1:E}, {val1:D}, {val1:P}, {val1:X}, {val1:C}");
// Console.WriteLine($"{val2:N}, {val1:G}, {val2:F}, {val2:E}, {val2:P}, {val2:C}");

// TODO: Add a number after the format to specify precision
// Console.WriteLine($"{val1:N4}, {val1:G5}, {val1:F6}, {val1:E7}, {val1:D8}, {val1:P9}, {val1:X4}, {val1:C}");

// TODO: Formatting with alignment and spacing
Console.WriteLine("Sales by Quarter:");
Console.WriteLine($"{quarters[0], 12} {quarters[1], 12} {quarters[2], 12} {quarters[3], 12}");
Console.WriteLine($"{sales[0],12:C0} {sales[1],12:C0} {sales[2],12:C0} {sales[3],12:C0}");
Console.WriteLine("International Sales:");
Console.WriteLine($"{intlMixPct[0],12:P2} {intlMixPct[1],12:P2} {intlMixPct[2],12:P2} {intlMixPct[3],12:P2}");
