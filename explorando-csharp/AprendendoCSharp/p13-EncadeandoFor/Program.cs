using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Encadeando For");

        //*
        //**
        //***
        //****
        //*****

        for (int linhas = 0; linhas < 10; linhas++)
        {
            for (int colunas = 0; colunas < 10; colunas++)
            {
                Console.Write("*");
                if (colunas >= linhas)
                    break;
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.Read();
    }
}