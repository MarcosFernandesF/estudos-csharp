using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;

        // Rendimento de 0.5% (0,005) ao mês.

        int mes = 1;

        while (mes <= 12)
        {
            investimento += investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);
            mes++;
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.Read();
    }
}