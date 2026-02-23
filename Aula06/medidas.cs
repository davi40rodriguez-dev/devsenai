using System.Security.Cryptography;
using static System.Console;
//declaração de variaveis
double a,b,c, areaQuadrada, areaTriangulo, areaTrapezia;
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
areaTrapezio = ((a + b) * c) / 2;
//Saída de dados
WriteLine($"A area do quadrado = {areaQuadrada}");
WriteLine($"A area do triangulo = {areaTriangulo}");
WriteLine($"A area do trapezio = {areaTrapezio}");