object[] objects = {"Vlad", 67, false, 9.81};

foreach(object item in objects)
{
    System.Console.Write($"Type: {item.GetType().Name}, value: {item}. ");    

    if (item is string s)
        System.Console.WriteLine($"Length: {s.Length}");
    else if (item is int i)
        System.Console.WriteLine($"Doubled: {i * 2}");
    else if (item is bool b)
        System.Console.WriteLine($"Negatived: {!b}");
    else if (item is double d)
        System.Console.WriteLine($"With 3 decimal places: {d:F3}");
}