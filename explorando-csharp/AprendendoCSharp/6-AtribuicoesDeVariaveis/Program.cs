using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Atribuições e Variáveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        // idadeAna continua sendo 30 mesmo alterando o valor posteriormente.
        // Variável armazena o valor e não referências.
        idade = 25;

        Console.WriteLine("Tecle enter para fechar...");
        Console.Read();
    }
}