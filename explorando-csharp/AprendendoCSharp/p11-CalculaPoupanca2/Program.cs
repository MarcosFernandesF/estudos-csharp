using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;

        // Rendimento de 0.5% (0,005) ao mês.
      
        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine($"No mês {mes} você tem {investimento}");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.Read();
    }
}