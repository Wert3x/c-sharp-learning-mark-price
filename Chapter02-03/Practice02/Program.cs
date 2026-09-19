//===============Excercise 2=================

/*for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        System.Console.WriteLine("Fizz");
    }

    else if (i  % 5 == 0)
    {
        System.Console.WriteLine("Buzz");
    }

    else if ((i % 3 == 0) && (i % 5 == 0))
    {
        System.Console.WriteLine("FizzBuzz");
    }

    else
    {
        System.Console.WriteLine(i);
    }
}*/

//================Excercise 3================

//format, argument, divisionbyzero, overflow, 

try
{
    Console.Write("Enter 1st number from 0 to 255: ");
    string? input1 = Console.ReadLine();
    if (string.IsNullOrEmpty(input1))
    {
        throw new FormatException("Пустой ввод!");
    }
    byte numberOne = byte.Parse(input1);

    Console.Write("Enter 2nd number from 0 to 255: ");
    string? input2 = Console.ReadLine();
    if (string.IsNullOrEmpty(input2))
    {
        throw new FormatException("Пустой ввод!");
    }
    byte numberTwo = byte.Parse(input2);

    double result = (double)numberOne / numberTwo;

    Console.WriteLine($"{numberOne} divided by {numberTwo} is {result}");
}
catch (FormatException)
{
    Console.WriteLine("FormatException: Input string was not in a correct format.");
}
catch (OverflowException)
{
    Console.WriteLine("OverflowException: Number must be between 0 and 255.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("DivideByZeroException: Cannot divide by zero.");
}
catch (Exception ex)
{
    Console.WriteLine($"Unknown error: {ex.GetType().Name}: {ex.Message}");
}
finally
{
    Console.WriteLine("Program finished.");
}