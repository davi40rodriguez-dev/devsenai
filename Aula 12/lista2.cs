using static System.Console;

int n;
List<double> numeros = new List<double>();

//Entrada de dados

Write("Quantos numeros deseja digitar?");
n = int.Parse(ReadLine());

for (int i = 0; i < n; i++)
{
    Write("Digite um numero: ");
    numeros.Add(double.Parse(ReadLine()));

}

for(int i = 0; i < n; i++)
{
    Write ("Valores =");
    Write ($"{numeros[i]} ");
}
Write($"\nSoma= {numeros.Sum()}");
Write($"\nMédia= {numeros.Average()} ");