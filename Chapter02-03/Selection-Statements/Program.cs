var students = new[]
{
    (Name: "Alice", Grades: new[] { 95, 88, 92 }, Status: "active"),
    (Name: "Bob", Grades: new[] { 75, 68, 72 }, Status: "active"),
    (Name: "Charlie", Grades: new[] { 55, 48, 62 }, Status: "active"),
    (Name: "Diana", Grades: new[] { 100, 98, 97 }, Status: "graduated"),
    (Name: "Eve", Grades: new int[] { }, Status: "active"),
    (Name: "Frank", Grades: new[] { 85, 90, 88 }, Status: "expelled"),
};

foreach(var student in students)
{
    System.Console.WriteLine($"\n=== {student.Name} ===");
    System.Console.WriteLine($"Имя: {student.Name}");

    string status = student.Status switch
    {
        "active" => "Учится",
        "graduated" => "Выпускник",
        "expelled" => "Отчислен",
        _ => "Неизвестный статус",
    };

    System.Console.WriteLine($"Статус: {status}");
    string grades = "";
    foreach(int grade in student.Grades)
    {
        grades = student.Grades.Length > 0
            ? string.Join(", ", student.Grades)
            : "";
    }
    System.Console.WriteLine($"Оценки: [{grades}]");

    var averageGrade = 0.0;
    var grades1 = student.Grades switch
    {
        [] => "Нет оценок",
        [_] => $"Одна оценка: {averageGrade = student.Grades[0]}",
        [var first, var second] => $"Средний балл: {averageGrade = ((first + second) / 2.0)}",
        [var first, var second, var third] => $"Средний балл: {averageGrade = ((first + second + third) / 3.0):F2}",
        _ => "Ошибка...",
    };
    System.Console.WriteLine(grades1);

    if (averageGrade >= 90)
    {
        System.Console.WriteLine("Оценка: A");
    }

    else if (averageGrade >= 80)
    {
        System.Console.WriteLine("Оценка: B");
    }

    else if (averageGrade >= 70)
    {
        System.Console.WriteLine("Оценка: C");
    }

    else if (averageGrade >= 60)
    {
        System.Console.WriteLine("Оценка: D");
    }

    else if ((averageGrade < 60) && (averageGrade > 0))
    {
        System.Console.WriteLine("Оценка: F");
    }

}
