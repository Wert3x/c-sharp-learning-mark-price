/*
int count = 5;
string name = "Alice";
decimal price = 99.99m;

var count2 = 5;
var name2 = "Bob";
var price2 = 99.99m;

var document = new System.Xml.XmlDocument();  // XmlDocument

Console.WriteLine($"{name} has {count} items for {price:C}");
Console.WriteLine($"{name2} has {count2} items for {price2:C}");

Console.WriteLine($"Type of name2: {name2.GetType().Name}");  // String
*/

using System.Xml;

int newInt = 18;
var varInt = 18;
double newDouble = 9.81;
var varDouble = 9.81;
string newString = "Grodno";
var varString = "Grodno";
XmlDocument newDoc = new XmlDocument();
var varDoc = new XmlDocument();

System.Console.WriteLine(newInt.GetType().Name);
System.Console.WriteLine(varInt.GetType().Name);
System.Console.WriteLine(newDouble.GetType().Name);
System.Console.WriteLine(varDouble.GetType().Name);
System.Console.WriteLine(newString.GetType().Name);
System.Console.WriteLine(varString.GetType().Name);
System.Console.WriteLine(newDoc.GetType().Name);
System.Console.WriteLine(varDoc.GetType().Name);