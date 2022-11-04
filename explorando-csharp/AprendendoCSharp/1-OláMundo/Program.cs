/* 
 * .NET é um sistema de execução virtual chamado CLR (Common Language Runtime).
 * O CLR é a implementação pela Microsoft da CLI (Common Language Infrastructure).
 * O código-fonte escrito em C# é compilado em uma IL (Intermediate Language) que está em conformidade com a CLI.
 * O código IL é armazenado em assembly.
 * Quando o programa C# é executado, o assembly é carregado no CLR.
 * O CLR então executa a compilação JIT (Just-In-Time) para converter o código IL em instruções nativas da máquina.
 * O IL produzido pelo compilador C# está em conformidade com a CTS (Common Type Specification).
 * O código IL gerado a partir do C# pode interagir com o código que foi gerado a partir das versões do .NET do F#, VB, C++...
*/

using System; //Using faz referência ao namespace "System". System é uma biblioteca com diversas funções.
// using permite usar Console.WriteLine como um atalho para System.Console.WriteLine

class Hello
{
    // Métodos estáticos operam sem referência a um objeto especifico (this ou self do python).
    // Por padrão o método estático chamado Main significa o ínicio do programa.
    static void Main(string[] args) 
    {
        Console.WriteLine("Olá, Mundo"); // Método WriteLine da class Console do namespace System
        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}