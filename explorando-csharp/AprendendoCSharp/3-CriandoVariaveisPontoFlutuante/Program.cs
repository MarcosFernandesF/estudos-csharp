using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Criando Variáveis Ponto Flutuante");

        // Variável Double 
        double salario;
        salario = 3000.13;
        Console.WriteLine("Meu salário é: " + salario);

        // Operação com double é importante colocar virgula no número para ter um resultado não inteiro.
        double idade;
        idade = 7.0 / 5;
        Console.WriteLine(idade);

        Console.WriteLine("Tecle enter para fechar...");
        Console.Read();
    }
}