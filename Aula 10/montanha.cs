using static System.Console;
try{
    //Declaração de variaveis
    int visitantes = 0, contagem = 0;
    double altura_max = 0, altura_min = 0, alturas = 0;

    //Entrada de dados

    WriteLine("Digite a quantidade de visitantes:");
    visitantes = int.Parse(ReadLine());
    WriteLine("Digite a altura máxima:");
    altura_max = double.Parse(ReadLine());
    WriteLine("Digite a altura mínima:");
    altura_min = double.Parse(ReadLine());

    //Processamento de dados

    foreach(int i in Range(0, visitantes))
    {
        WriteLine($"Digite a altura da pessoa nº {i+1}:");
        alturas = int.Parse(ReadLine());
        if((alturas >= altura_min ) & (alturas <= altura_max))
        {
            contagem++;
        }
    }
    WriteLine($"O número de pessoas que podem entrar no parque é de {contagem}");
}
catch (Exception ex)
{
    WriteLine($"Ocorreu um erro: {ex.Message}");
}

