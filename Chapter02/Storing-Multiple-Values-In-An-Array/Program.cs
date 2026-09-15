using System.Globalization;
using System.Net;

int[] numbers = new int[5];

for (int i = 0; i < 5; i++)
{
    System.Console.Write($"{i + 1} number: ");
    numbers[i] = int.Parse(System.Console.ReadLine());
}

System.Console.WriteLine($"Your numbers: {string.Join(", ", numbers)}");
System.Console.WriteLine($"Max number: {numbers.Max()}");
System.Console.WriteLine($"Min number: {numbers.Min()}");
System.Console.WriteLine($"Summary: {numbers.Sum()}");
System.Console.WriteLine($"Average: {numbers.Average():F2}");