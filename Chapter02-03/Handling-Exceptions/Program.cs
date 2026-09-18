/*onsole.WriteLine("=== Программа с обработкой исключений ===\n");

// 1. Try-catch с конкретным типом
Console.Write("Введите число: ");
string? input = Console.ReadLine();

try
{
    int number = int.Parse(input!);
    Console.WriteLine($"Вы ввели: {number}");
    Console.WriteLine($"Квадрат: {number * number}");
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: введите число, а не текст!");
}
catch (OverflowException)
{
    Console.WriteLine("Ошибка: число слишком большое!");
}
catch (Exception ex)
{
    Console.WriteLine($"Неизвестная ошибка: {ex.GetType().Name}: {ex.Message}");
}

Console.WriteLine("\n=== Try-catch-finally ===\n");

// 2. Try-catch-finally
try
{
    Console.WriteLine("Открываем файл...");
    throw new IOException("Симуляция ошибки!");
}
catch (IOException ex)
{
    Console.WriteLine($"Ошибка I/O: {ex.Message}");
}
finally
{
    Console.WriteLine("Закрываем файл (finally).");
}

Console.WriteLine("\n=== Свой throw ===\n");

// 3. Собственный throw
try
{
    SetAge(-5);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Ошибка аргумента: {ex.Message}");
}

// Метод, который бросает исключение
void SetAge(int age)
{
    if (age < 0)
    {
        throw new ArgumentOutOfRangeException(
            nameof(age), "Возраст не может быть отрицательным!");
    }
    Console.WriteLine($"Возраст установлен: {age}");
}*/


//======================PRACTICE TASK 1=======================


/*System.Console.WriteLine("=======CALCULATOR=======");

try
{
    System.Console.WriteLine("Enter 1st number: ");
    int.TryParse(Console.ReadLine(), out int numberOne);

    System.Console.WriteLine("Enter 2nd number: ");
    int.TryParse(Console.ReadLine(), out int numberTwo);

    System.Console.WriteLine("Enter the operation: ");
    string operation = Console.ReadLine();

    double result = operation switch
    {
        "+" => numberOne + numberTwo,
        "-" => numberOne - numberTwo,
        "*" => numberOne * numberTwo,
        "/" when numberTwo != 0 => numberOne / numberTwo,
        "/" => numberTwo == 0
                ? throw new DivideByZeroException("Error: Divizion by zero!")
                : numberOne / numberTwo,
        _ => throw new ArgumentException("Error: Invalid operation!")
    };

    System.Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result}");
}

catch (FormatException ex)
{
    System.Console.WriteLine($"Error: {ex.GetType().Name}");
}

catch (DivideByZeroException ex)
{
    System.Console.WriteLine($"Error: {ex.GetType().Name}");
}

catch (OverflowException ex)
{
    System.Console.WriteLine($"Error: {ex.GetType().Name}");
}

catch (ArgumentException ex)
{
    System.Console.WriteLine($"Error: {ex.GetType().Name}");
}

catch(Exception ex)
{
    System.Console.WriteLine($"Error: {ex.GetType().Name}");
}

finally
{
    System.Console.WriteLine("Calculation is over.");
}*/


//==========================PRACTICE TASK 2===========================
using System.Linq;
try
{
    System.Console.Write("Enter your username: ");
    string username = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
    {
        throw new ArgumentException("Null or less then 3 symbols.");
    }

    System.Console.Write("Enter your email: ");
    string email = Console.ReadLine();
    if (!email.Contains('@') || !email.Contains('.'))
    {
        throw new FormatException("Invalid mail. It doesn't contain '@' or '.'");
    }

    System.Console.Write("Enter your age (18-120): ");
    if(!int.TryParse(Console.ReadLine(), out int age))
    {
        throw new FormatException("Age must be a number.");
    }
    if ((age < 18) || (age > 120))
    {
        throw new ArgumentOutOfRangeException("Age out of range from 18 to 120.");
    }

    System.Console.Write("Enter your password: ");
    string password = Console.ReadLine();
    if(!(password.Any(char.IsDigit)) || (password.Length < 8))
    {
        throw new ArgumentException("Invalid password. It must contains digit and has more then 8 symblos.");
    }

    System.Console.WriteLine("===REGISTRATION SUCCESSFULL===");
    System.Console.WriteLine($"Welcome, {username}!");
}

catch (ArgumentException ex)
{
    System.Console.WriteLine($"Error: {ex.Message}");
}

catch (FormatException ex)
{
    System.Console.WriteLine($"Error: {ex.Message}");
}

catch (Exception ex)
{
    System.Console.WriteLine($"Error: {ex.Message}");
}

finally
{
    System.Console.WriteLine("Registration process ended.");
}