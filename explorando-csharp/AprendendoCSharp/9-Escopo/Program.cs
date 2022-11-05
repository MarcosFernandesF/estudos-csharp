using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Escopo");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        // Se declarar a variável dentro do if, ela so existe dentro do if
        if (acompanhado)
        {
            /*string*/ textoAdicional = "João está acompanhado.";
        }
        else
        {
            /*string*/ textoAdicional = "João não está acompanhado.";
        }

        // Operadores condicionais: ||, &&, != .
        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
            // Com uma única linha não precisa colocar chaves {}
            Console.WriteLine("Não pode entrar!");

        Console.WriteLine("Tecle enter para fechar...");
        Console.Read();
    }
}