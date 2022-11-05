using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        // Char armazena um caracter (16 bits).
        // Para representar o caracter utiliza-se aspas simples para respeitar a variável char.
        char letra = 'a';
        Console.WriteLine("Letra: " + letra);

        // Represenatando letras através da tabela ASCII.
        letra = (char)65;
        Console.WriteLine("Letra: " + letra);

        letra = (char)(65 + 1);
        Console.WriteLine("Letra: " + letra);

        // String armazena frases.
        string primeiraFrase = @"Primeira frase:
Segunda frase,
Terceira frase,
Arroba faz isso";
        Console.WriteLine(primeiraFrase);

        Console.WriteLine("Tecle enter para fechar...");
        Console.Read();
    }
}