/*Console.WriteLine("=== Default type values ===");
Console.WriteLine($"int:      {default(int)}");
Console.WriteLine($"long:     {default(long)}");
Console.WriteLine($"double:   {default(double)}");
Console.WriteLine($"decimal:  {default(decimal)}");
Console.WriteLine($"bool:     {default(bool)}");
Console.WriteLine($"char:     '{default(char)}' (код: {(int)default(char)})");
Console.WriteLine($"DateTime: {default(DateTime)}");
Console.WriteLine($"string:   {default(string) ?? "<null>"}");

Console.WriteLine("\n=== Value reset ro default ===");
int number = 42;
Console.WriteLine($"Before: {number}");
number = default;
Console.WriteLine($"After: {number}");

string name = "Alice";
Console.WriteLine($"Before: {name}");
name = default;
Console.WriteLine($"After: {name ?? "<null>"}");*/

System.Console.WriteLine($"int: {default(int)}");
System.Console.WriteLine($"long: {default(long)}");
System.Console.WriteLine($"double: {default(double)}");
System.Console.WriteLine($"decimal: {default(decimal)}");
System.Console.WriteLine($"bool: {default(bool)}");
System.Console.WriteLine($"char: '{(int)default(char)}'");
System.Console.WriteLine($"DateTime: {default(DateTime)}");
System.Console.WriteLine($"string: {default(string) ?? "<NULL>"}");


int number = 2026;
string word = "csharps";
bool detector = true;

System.Console.WriteLine($"Before reset: int - {number}, string - {word}, bool - {detector}.");

number = default;
word = default;
detector = default;

System.Console.WriteLine($"After reset: int - {number}, string - {word ?? "<NULL>"}, bool - {detector}");