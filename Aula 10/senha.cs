using System.Security.Cryptography;
using static System.Console;

//Declaração de variaveis
const int SENHAFIXA = 2002;
int senha, contagem = 0;

//Entrada de dados
Write("Digite a senha: ");
senha = int.Parse(ReadLine());

//Processamento de dados
while (senha != SENHAFIXA)
{
    Write("Senha incorreta, tente novamente!");
    senha = int.Parse(ReadLine());
    Console.Beep(300, 50);
} 
if (contagem < 3)
{
WriteLine("Acesso permitido!");
}
else
{
    WriteLine("a");
}
   

