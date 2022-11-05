using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e Outros Tipos");

        double salario;
        salario = 3000.15;

        // Int armazena 32 bits
        int salarioInteiro;
        salarioInteiro = (int)salario; // Convertendo para inteiro
        Console.WriteLine("Salario Inteiro: " + salarioInteiro);

        // Long armazena 64 bits
        long x;
        x = 200000000000000;

        // Short armazena 16 bits
        short y;
        y = 15000;

        Console.WriteLine("Tecle enter para fechar...");
        Console.Read();
    }
}