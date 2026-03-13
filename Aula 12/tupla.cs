//tupla

var clodoaldo = (34, 5000.54, "Davi", "FATEC", 'B');

System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}");
System.Console.WriteLine($"salario do clodoaldo: {clodoaldo.Item2}");
System.Console.WriteLine($"filho do clodoaldo: {clodoaldo.Item3}");
System.Console.WriteLine($"escola do clodoaldo: {clodoaldo.Item4}");
System.Console.WriteLine($"caracter favorito do clodoaldo: {clodoaldo.Item5}");
clodoaldo.Item1 = 54;
System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}");

(int, int, int) numeros = (1 , 2 , 5);

System.Console.WriteLine($"Números: {numeros.Item1}, {numeros.Item2}, {numeros.item3}");