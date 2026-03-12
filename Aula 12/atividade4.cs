using System.Xml.Serialization;
using static System.Console;
//---Declaração de variaveis
int codigo,quantidade;

//--------Declaração de um dicionario
Dictionary<int, double> lanchonete = new Dictionary<int,double>()
{
    {1, 7.50},
    {2, 10.00},
    {3, 8.50}
};
try{
    //------entrada de dados
    Write("Digite o código do produto: ");
    codigo = int.Parse(ReadLine());
    Write("Digite a quantidade de produto: ");
    quantidade = int.Parse(ReadLine());


    WriteLine($"O valor total é de: {quantidade * lanchonete[codigo]}");
}
catch(Exception ex)
{
    WriteLine($"Digite um valor invalido");
}
