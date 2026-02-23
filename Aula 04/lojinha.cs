using System.Data;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Transactions;
using System.Xml.Schema;
using static System.Console;
//declaração de variaveis
double precouni,quantidade,total;
//Processamento de dados 
Write("Digite o preço unitario do produto:");
precouni = double.E.Parse(ReadLine());
Write("Digite a quantidade do produto:");
quantidade = double.E.Parse(ReadLine());
total = precouni * quantidade;
WriteLine($"O valor total da compra é: {total}"); 