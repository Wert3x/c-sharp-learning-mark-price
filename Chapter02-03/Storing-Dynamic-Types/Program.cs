dynamic something;

something = new[] {1, 2, 3, 4};
try { System.Console.WriteLine(something.Length); }
catch (Exception ex) {System.Console.WriteLine($"Error: {ex.Message}");}

something = "Avada kedavra";
try { System.Console.WriteLine(something.Length); }
catch (Exception ex) {System.Console.WriteLine($"Error: {ex.Message}");}

something = 12334;
try {System.Console.WriteLine(something.Length);}
catch (Exception ex) {System.Console.WriteLine($"Error: {ex.Message}");}

something = true;
try {System.Console.WriteLine(something.Length);}
catch (Exception ex) {System.Console.WriteLine($"Error: {ex.Message}");}
