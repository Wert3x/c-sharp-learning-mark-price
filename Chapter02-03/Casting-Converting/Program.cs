/*// 1. implicit (safe)
int a = 10;
double b = a;
Console.WriteLine($"int {a} → double {b}");

// 2. distinct (may lose data)
double c = 9.8;
int d = (int)c;
Console.WriteLine($"double {c} → int {d}");

// 3. overflow
long e = 5_000_000_000;
int f = (int)e;
Console.WriteLine($"long {e} → int {f}");

// 4. Convert (rounds)
double g = 9.8;
int h = Convert.ToInt32(g);
Console.WriteLine($"double {g} → int {h}");

// 5. banker's rounding
Console.WriteLine("\nBanker's rounding:");
double[] values = { 9.5, 10.5, 11.5, 12.5 };
foreach (double v in values)
{
    Console.WriteLine($"{v} → {Convert.ToInt32(v)}");
}

// 6. ToString and Parse
int number = 42;
string s = number.ToString();
int parsed = int.Parse(s);
Console.WriteLine($"\nToString: {s}, Parse: {parsed}");

// 7. TryParse (safe)
string input = "abc";
if (int.TryParse(input, out int result))
{
    Console.WriteLine($"Sucess: {result}");
}
else
{
    Console.WriteLine($"Error: '{input}' is not int");
}*/

if (args.Length < 3)
{
    System.Console.WriteLine("Error: Invalid value. The correct example: dotnet run 100 USD EUR");    
    return;
}

decimal.TryParse(args[0], out decimal value);
string currencyOne = args[1].ToUpper();
string currencyTwo = args[2].ToUpper();

decimal rate = (currencyOne, currencyTwo) switch 
{
    ("USD", "EUR") => 0.87m,
    ("EUR", "USD") => 1.15m,
    ("BYN", "RUB") => 27.81m,
    ("RUB", "BYN") => 0.036m,
    ("USD", "BYN") => 3.04m,
    ("BYN", "USD") => 0.33m,
    ("EUR", "BYN") => 3.49m,
    ("BYN", "EUR") => 0.29m,
    ("USD", "RUB") => 84.50m,
    ("RUB", "USD") => 0.012m,
    ("EUR", "RUB") => 96.99m,
    ("RUB", "EUR") => 0.01m,
    _ => 0m
};

if (rate == 0)
{
    System.Console.WriteLine("Error: Ivalid currency.");
}
else
{
    decimal result = value * rate;
    decimal rounded = Math.Round(result, 2, MidpointRounding.AwayFromZero);

    System.Console.WriteLine(new string('-', 35));
    System.Console.WriteLine($"| {value} {currencyOne} = {result} {currencyTwo} |");
    System.Console.WriteLine(new string('-', 35));
}