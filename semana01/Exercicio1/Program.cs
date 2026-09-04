using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Exercicio1.");

        Console.Write("Qual é o seu nome? ");
        string nome = Console.ReadLine();
        
        Console.Write("Qual é seu sobrenome? ");
        string sobrenome = Console.ReadLine();
        Console.WriteLine($"Seu nome é {sobrenome}, {nome} {sobrenome}.");
    }
}