using static System.Console;
//declaração de variaveis
 double dia, anos, meses, dias;
 Write("Digite o número de dias: ");
dia = double.Parse(ReadLine());
//processamento de dados 
anos = dia / 365;
meses = (dia % 365) / 30;
dias = (dia % 365) % 30;
//saída de dados
WriteLine($"O número de anos é: {anos}, o número de meses é: {meses} e o número de dias é: {dias}");    