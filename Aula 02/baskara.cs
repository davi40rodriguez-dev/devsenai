    using static System.Console;
    try{
    //Problema Baskara
    //------------Declaração de variaveis------
    double a, b, c, delta, x1, x2;
    //------------Entrada de dados----------------
    Write("Digite o valor de A: ");
    a = double.Parse(ReadLine());
    Write("Digite o valor de B:");
    b= double.Parse(ReadLine());
    Write("Digite o valor de C");
    c= double.Parse(ReadLine());
    //----------Estrutura de controle de decisão- if
    if(delta < 0)
    {
        WrieLine("Raizes impossiveis");
    }
    else if (delta == 0)
    {
        x1 = -b/ (2*a);
        x2 = x1;
        WriteLine($"x1 = {x1}\nX2 ={x2}");
    }
    else
    {
        x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        WriteLine($"X1 = {x1} = {1}\nX2 = {x2}");
    }
}
catch (Exception)
{
    WriteLine("Erro,Digite algo válido");
}