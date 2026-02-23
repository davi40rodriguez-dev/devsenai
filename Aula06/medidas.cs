
using System.Security.Principal;
using static System.Console;
try{
    //declaração de variaveis
    double a,b,c, areaQuadrada, areaTriangulo, areaTrapezio;
    //Entrada de dados
    Write("Digite a medida A:");
    a = double.Parse(ReadLine());
    Write("DIgite B:");
    b = double.Parse(ReadLine());
    Write("Digite C: ");
    c = double.Parse(ReadLine());
    //Processamento de dados
    areaQuadrada = a * a;
    areaTriangulo =(a * b) / 2;
    areaTrapezio = ((a +b) *c) / 2;
    //Saída de dados
    WriteLine($"A area do quadrado = {areaQuadrada:F4}");
    WriteLine($"A area do triangulo = {areaTriangulo:F4}");
    WriteLine($"A area do trapezio = {areaTrapezio:F4}");
    }
catch (Exception)
{
    WriteLine("Valores invalidos, programa encerrado");
}