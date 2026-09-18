/*Console.WriteLine("=== 1. Переполнение по умолчанию ===\n");

int x = int.MaxValue - 1;
Console.WriteLine($"Начальное значение: {x}");

x++;
Console.WriteLine($"После инкремента: {x}");

x++;
Console.WriteLine($"После инкремента: {x}");  // Переполнение!

x++;
Console.WriteLine($"После инкремента: {x}\n");

Console.WriteLine("=== 2. checked — ловим переполнение ===\n");

try
{
    checked
    {
        int y = int.MaxValue - 1;
        Console.WriteLine($"Начальное значение: {y}");

        y++;
        Console.WriteLine($"После инкремента: {y}");

        y++;  // Здесь будет исключение
        Console.WriteLine($"После инкремента: {y}");

        y++;
        Console.WriteLine($"После инкремента: {y}");
    }
}
catch (OverflowException)
{
    Console.WriteLine("Переполнение! Программа поймала ошибку.\n");
}

Console.WriteLine("=== 3. unchecked — отключаем проверку ===\n");

unchecked
{
    int z = int.MaxValue;
    z = z + 1;
    Console.WriteLine($"unchecked: int.MaxValue + 1 = {z}");
}

Console.WriteLine("\n=== 4. Проверка на уровне проекта ===\n");

Console.WriteLine("Чтобы включить проверку для всего проекта,");
Console.WriteLine("добавь в .csproj:");
Console.WriteLine("<CheckForOverflowUnderflow>true</CheckForOverflowUnderflow>");*/

System.Console.WriteLine("====OVERFLOW WITHOUT CHECKED====");

int maxInt = int.MaxValue;
int overflowedNumber = maxInt + 1;
System.Console.WriteLine($"Before overflow: {maxInt}");
System.Console.WriteLine($"After overflow: {overflowedNumber}");

System.Console.WriteLine("\n====OVERFLOW WITH CHECKED====");

try
{
    checked
    {
        System.Console.WriteLine($"Before oveflow: {maxInt}");
        int overflowedNumberTwo = maxInt + 1;
        System.Console.WriteLine($"After overflow: {overflowedNumberTwo}");
    }
}

catch (OverflowException ex)
{
    System.Console.WriteLine($"Error: {ex.Message}");
}

catch (Exception ex)
{
    System.Console.WriteLine($"Error: {ex.Message}");
}

System.Console.WriteLine("\n====OVERFLOW WITH UNCHECKED====");

unchecked
{
    System.Console.WriteLine($"Before overflow: {maxInt}");
    int overflowedNumberThree = maxInt + 1;
    System.Console.WriteLine($"After overflow: {overflowedNumberThree}");
}