
using static System.Console;

static void Total(int qtd, double valor)
{
    WriteLine($"O valor total é de: {qtd * valor}");
}

//----Declração de variaveis------
try{
    int codigo, quantidade;
    //----Entrada de dados--------
    Write("Digite o código do produto: ");
    codigo = int.Parse(ReadLine());
    Write("Digite a quantidade de produto: ");
    quantidade = int.Parse(ReadLine());
    switch (codigo)
    {
        case 1:
            Total(quantidade, 5.00);
                    break;
        case 2: 
            Total(quantidade, 4.50);
            break;
        case 3:
        Total(quantidade, 3.75);
        //WriteLine($"O valor total é de: {quantidade * 3.75}");
            break;
        case 4:
        Total(quantidade, 8.99);
        //WriteLine($"O valor total é de: {quantidade * 8.99}");
            break;
        case 5:
        Total(quantidade,11.33);
        //WriteLine($"O valor total é de: {quantidade * 11.33}");
            break;
    }
}
catch (Exception ex)
{
    WriteLine($"Digite valores válidos, erro: {ex.Message}");
}