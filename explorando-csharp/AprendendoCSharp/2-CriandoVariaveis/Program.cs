using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        // Variável Inteiro.
        int idade;
        idade = 21;

        // Concatenando variável.
        Console.WriteLine("Minha idade é: " + idade);

        idade = 21 - 3;
        Console.WriteLine(idade);

        // Multiplicação e divisão antes de soma e subtração.
        idade = 5 * 2 - 6; 
        Console.WriteLine(idade);


        // O Console.Write não possui quebra de linha.
        Console.Write("Tecle enter para fechar..."); 
        Console.ReadLine();
    }
}