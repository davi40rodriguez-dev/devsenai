// o usuario vair digitar um valor de 1 a 7 e eese código é para mostrar od dia da semana

//---------Declaração de variáveis------
using static System.Console;

int valor;
//---------Entrada de dados--------
Write("Digite um número de 1 a 7 para mostrar o dia da semana correspondente:");
valor = int.Parse(Console.ReadLine());
if(valor == 1)
{
    WriteLine("Domingo");
}
else if (valor == 2)
{
    WriteLine("Segunda");
}
else if (valor == 3)
{
    WriteLine("Terça");
}
else if (valor == 4)
{
    WriteLine("Quarta");
}
else if (valor == 5)
{
    WriteLine("Quinta");
}
else if (valor == 6)
{
    WriteLine("Sexta");
}
else if (valor == 7)
{
    WriteLine("Sábado");
}
else
{
    WriteLine("Valor inválido");
}