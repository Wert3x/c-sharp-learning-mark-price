/*Практическое задание: «Система оценок студентов»
Реальная задача:
Ты — разработчик системы для университета. Нужно написать программу, которая обрабатывает оценки студентов и выводит информацию о них.

Входные данные:
У тебя есть массив студентов. Каждый студент — это массив объектов (или кортеж), содержащий:

Имя (string)

Оценки (int[]) — от 0 до 100

Статус (string) — "active", "graduated", "expelled"*/


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



    //===================My version==============
    /*string grades = "";
    foreach(int grade in student.Grades)
    {
        grades = student.Grades.Length > 0
            ? string.Join(", ", student.Grades)
            : "";
    }
    System.Console.WriteLine($"Оценки: [{grades}]");*/
    //===========================================

    string grades = string.Join(", ", student.Grades);



    //==================My version===============
   /* var averageGrade = 0.0;
    var averageInfo = student.Grades switch //============= Was "grades1" before "averageInfo" 
    {
        [] => "Нет оценок",
        [_] => $"Одна оценка: {averageGrade = student.Grades[0]}",
        [var first, var second] => $"Средний балл: {averageGrade = ((first + second) / 2.0)}",
        [var first, var second, var third] => $"Средний балл: {averageGrade = ((first + second + third) / 3.0):F2}",
        _ => "Ошибка...",
    };
    System.Console.WriteLine(averageInfo);*/
    double averageGrade = student.Grades.Length > 0
    ? student.Grades.Average()
    : 0.0;

    string averageInfo = student.Grades switch
    {
        [] => "Нет оценок",
        [_] => $"Одна оценка: {student.Grades[0]}",
        [var first, var second] => $"Средний балл: {(first + second) / 2.0:F2}",
        [var first, .., var last] => $"Средний балл: {averageGrade:F2}",
        _ => "Ошибка..."
    };











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
