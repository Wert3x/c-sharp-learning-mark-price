/*string first = "Hello";
string second = "World!";

string[] words = {"Hello", "World!"};

System.Console.WriteLine($"{first} {second}");
System.Console.WriteLine(string.Join(" ", words));
*/


//Practics

System.Console.WriteLine("Your name: ");
string name =  System.Console.ReadLine();

System.Console.WriteLine("Your age: ");
int age = int.Parse(System.Console.ReadLine());

System.Console.WriteLine(@$"Hello, {name.ToUpper(0)}!
You have to work for {65-age} years!(");
