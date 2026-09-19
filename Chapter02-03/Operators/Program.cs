System.Console.WriteLine("========== Арифметические ==========\n");

int a = 10; int b = 3;

System.Console.WriteLine($"a = {a}, b = {b}");
System.Console.WriteLine($"a + b = {a + b}");
System.Console.WriteLine($"a - b = {a - b}");
System.Console.WriteLine($"a * b = {a * b}");
System.Console.WriteLine($"a / b = {a / b} (Целочисленное деление!)");
System.Console.WriteLine($"a % b = {a % b} (остаток)");

System.Console.WriteLine("\n========== Унарные ==========\n");

int x = 5;

System.Console.WriteLine($"x = {x}");
System.Console.WriteLine($"x++ = {x++}");
System.Console.WriteLine($"++x = {++x}");
System.Console.WriteLine($"x-- = {x--}");
System.Console.WriteLine($"--x = {--x}");
System.Console.WriteLine($"-x = {-x}");
System.Console.WriteLine($"!true = {!true}");

System.Console.WriteLine("\n========== Тернарный ==========\n");

int age = 20;

System.Console.WriteLine($"age = {age}");
string status = age >= 18 ? "Взрослый" : "Ребенок";
System.Console.WriteLine($"age >= 18 ? \"Взрослый\" : \"Ребенок\" = {status}");

System.Console.WriteLine("\n========== Логические ==========\n");

bool p = true; bool q = false;

System.Console.WriteLine($"p = {p}, q = {q}");
System.Console.WriteLine($"p && q = {p && q}");
System.Console.WriteLine($"p || q = {p || q}");
System.Console.WriteLine($"p ^ q = {p ^ q}");
System.Console.WriteLine($"p & q = {p & q}");
System.Console.WriteLine($"p | q = {p | q}");

System.Console.WriteLine("\n========== Битовые ==========\n");

int m = 10; int n = 6;

System.Console.WriteLine($"m = {m} ({Convert.ToString(m, 2)})");
System.Console.WriteLine($"n = {n} ({Convert.ToString(n, 2)})");
System.Console.WriteLine($"m & n = {m & n} ({Convert.ToString((m & n), 2)})");
System.Console.WriteLine($"m | n = {m | n} ({Convert.ToString((m | n), 2)})");
System.Console.WriteLine($"m ^ n = {m ^ n} ({Convert.ToString((m ^ n), 2)})");
System.Console.WriteLine($"~m = {~m}");
System.Console.WriteLine($"m << 1 = {m << 1} ({Convert.ToString((m << 1), 2)})");
System.Console.WriteLine($"n >> 1 = {n >> 1} ({Convert.ToString((n >> 1), 2)})");

System.Console.WriteLine("\n========== Присваивание ==========\n");

int z = 10;
System.Console.WriteLine($"z = {z}");
System.Console.WriteLine($"z += 5 => {z += 5}");
System.Console.WriteLine($"z -= 3 => {z -= 3}");
System.Console.WriteLine($"z *= 2 => {z *= 2}");
System.Console.WriteLine($"z /= 4 => {z /= 4}");
System.Console.WriteLine($"z %= 5 => {z %= 5}");

System.Console.WriteLine("\n========== Null - coalescing ==========\n");

string? name = null;

System.Console.WriteLine($"name = {name ?? "<NULL>"}");
System.Console.WriteLine($"name ?? \"Гость\" = {name ?? "Гость"}");
System.Console.WriteLine($"name ??=  \"Alice\" => {name ??= "Alice"}");
System.Console.WriteLine($"name?.Length = {name?.Length}");