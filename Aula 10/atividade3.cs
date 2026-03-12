using static System.Console;

{
   
    {
        int totalTuristas = 0;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aplicativo de controle de fluxo carros");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Parque Nacional os Lençóis Maranhenses\n");

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Bem-vindo ao aplicativo de controle de fluxo de carros!");

        while (true)
        {
            Console.ResetColor();
            Console.Write("\nDigite o fluxo de carro (entrada/saida)\nou sair para encerrar a aplicação: ");
            string fluxo = Console.ReadLine().ToLower();

            if (fluxo == "sair")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSaindo do aplicativo...");
                break;
            }

            if (fluxo != "entrada" && fluxo != "saida")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Por favor, digite 'entrada' ou 'saida'.");
                continue;
            }

            Console.ResetColor();
            Console.Write("Digite o número de turistas: ");
            if (!int.TryParse(Console.ReadLine(), out int turistas) || turistas < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Número de turistas inválido.");
                continue;
            }

            DateTime agora = DateTime.Now;

            if (fluxo == "entrada")
            {
                totalTuristas += turistas;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Entrada registrada em: {agora}");
                Console.ResetColor();
                Console.WriteLine($"Entrada de {turistas} turistas registrada.");
            }
            else
            {
                totalTuristas -= turistas;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Saída registrada em: {agora}");
                Console.ResetColor();
                Console.WriteLine($"Saída de {turistas} turistas registrada.");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total de turistas no parque: {totalTuristas}");
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aplicativo encerrado.");
        Console.ResetColor();
       
    }
}
