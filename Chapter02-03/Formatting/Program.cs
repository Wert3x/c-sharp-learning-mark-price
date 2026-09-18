/*string[] names = { "Alice", "Bob", "Charlie" };
int[] counts = { 12, 5, 100 };

Console.WriteLine($"{"Name",-10} | {"Quantity",10}");
Console.WriteLine(new string('-', 25));

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"{names[i],-10} | {counts[i],10}");
}*/

/*using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

string[] products = { "Apples", "Bananas", "Cherries" };
int[] quantities = { 1234, 56789, 42 };
decimal[] prices = { 0.35m, 0.15m, 2.99m };

Console.WriteLine($"{"Product",-10} | {"Quantity",10} | {"Price",10} | {"Total",12}");
Console.WriteLine(new string('-', 52));

for (int i = 0; i < products.Length; i++)
{
    decimal total = quantities[i] * prices[i];
    Console.WriteLine($"{products[i],-10} | {quantities[i],10:N0} | {prices[i],10:C} | {total,12:C}");
}

Console.WriteLine(new string('-', 52));

decimal grandTotal = 0;
for (int i = 0; i < products.Length; i++)
{
    grandTotal += quantities[i] * prices[i];
}
Console.WriteLine($"{"ИТОГО",-10} | {"",10} | {"",10} | {grandTotal,12:C}");*/


if (args.Length < 3)
{
    System.Console.WriteLine("Error: Invalid value. The correct example: dotnet run 1 + 2");
}


int number1 = int.Parse(args[0]);
string op = args[1];
int number2 = int.Parse(args[2]);


double result = op switch
{
    "+" => number1 + number2,
    "-" => number1 - number2,
    "*" => number1 * number2,
    "%" when number2 != 0 => number1 % number2,
    "%" => double.NaN,
    "/" when number2 != 0 => number1 / number2,
    "/" => double.NaN,
    _ => double.NaN
};

if (double.IsNaN(result))
{
    System.Console.WriteLine("Error: invalid value or division by zero.");
}

else
{
    System.Console.WriteLine(new string ('=', 30));
    System.Console.WriteLine($"| {number1} {op} {number2} = {result} |");
    System.Console.WriteLine(new string ('=', 30));
}