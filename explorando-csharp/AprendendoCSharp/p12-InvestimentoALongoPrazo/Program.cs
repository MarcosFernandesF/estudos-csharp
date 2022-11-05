using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;

        // Rendimento de 0.5% (0,005) ao mês.
        double fatorRendimento = 1.005;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= 1.005;
            }
            fatorRendimento += 0.001;
        }

        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);

        Console.WriteLine("Tecle enter para fechar...");
        Console.Read();
    }
}