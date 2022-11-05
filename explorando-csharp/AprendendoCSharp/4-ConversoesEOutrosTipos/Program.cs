using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e Outros Tipos");

        double salario;
        salario = 3000.15;

        // Int armazena 32 bits.
        int salarioInteiro = (int)salario; // Convertendo para inteiro.
        Console.WriteLine("Salario Inteiro: " + salarioInteiro);

        // Long armazena 64 bits.
        long x = 200000000000000;
    
        // Short armazena 16 bits.
        short y = 15000;

        // Float possui uma precisão menor que Double (32 bits).
        // o "f" sinaliza que eu tenho realmente intuito de usar Float invés de Double.
        float altura = 1.62f;

        Console.WriteLine("Tecle enter para fechar...");
        Console.Read();
    }
}