System.Console.Write("Your height(m): ");
double height = double.Parse(System.Console.ReadLine());

System.Console.Write("Your weight(kg): ");
double weight = double.Parse(System.Console.ReadLine());

double bodyMassIndex = weight / (height * height);

string category = bodyMassIndex switch
{
    < 18.5 => "Underweight",
    < 25 => "Normal",
    < 30 => "Overweight",
    _ => "Obesity"
};

System.Console.WriteLine($"Your category: {category}");
