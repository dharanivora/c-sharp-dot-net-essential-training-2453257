// Exercise file for LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for .NET Data Types

// Declare some types with values
using System.Net.Mail;

int a = 1;
char c = 'A';
float f = 123.45f;
decimal d = 400.85m;
int b = default;
bool tf = default;

Console.WriteLine($"{a}, {b}, {tf}, {c}, {f}, {d}");

// TODO: implicit type conversion
// Console.WriteLine($"{a + c}");
// Console.WriteLine('a' + 'c');

// // Explicit type conversion
// Console.WriteLine((char)(a + c));
// Console.WriteLine((char)('a' + 'c'));

// TODO: Create an instance of a struct (which is a value type)
var myStruct1 = new s();
myStruct1.a = 333;
myStruct1.b = true;
Console.WriteLine(myStruct1);
Console.WriteLine(myStruct1.ToString());
Console.WriteLine(myStruct1.GetType());
Console.WriteLine(myStruct1.a);
Console.WriteLine(myStruct1.b);

var myStruct2 = new s();
myStruct1.a = 999;
myStruct1.b = false;
Console.WriteLine(myStruct2);
Console.WriteLine(myStruct2.ToString());
Console.WriteLine(myStruct2.GetType());
Console.WriteLine(myStruct2.a);
Console.WriteLine(myStruct2.b);

Console.WriteLine("---------------------");

// Console.WriteLine($"{myStruct1.a}, {myStruct1.b}");
// StructOp(myStruct1);
// Console.WriteLine($"{myStruct1.a}, {myStruct1.b}");

// Perform an operation on a struct
void StructOp(s theStruct)
{
    // Modify the struct properties inside the function
    theStruct.a = 10;
    theStruct.b = true;
    Console.WriteLine($"{theStruct.a}, {theStruct.b}");
}

Console.WriteLine("Structs are passed by copy, since they are value types:");
Console.WriteLine($"{myStruct1.a}, {myStruct1.b}");
StructOp(myStruct1);
Console.WriteLine($"{myStruct1.a}, {myStruct1.b}");

// TODO: Create an object instance of a class (which is a reference type)

var cl = new MyClass { a = 1000, b = false };

// Perform an operation on the class
void ClassOp(MyClass theClass)
{
    // Modify some of the properties of the class inside the function
    theClass.a = 10;
    theClass.b = true;
    Console.WriteLine($"{theClass.a}, {theClass.b}");
}

Console.WriteLine("Objects are passed by reference, since they are reference types:");
Console.WriteLine($"{cl.a}, {cl.b}");
ClassOp(cl);
Console.WriteLine($"{cl.a}, {cl.b}");

// These are declared at the bottom of the file because C# requires
// top-level statements to come before type declarations
class MyClass
{
    public int a;
    public bool b;
}

struct s
{
    public int a;
    public bool b;
}
