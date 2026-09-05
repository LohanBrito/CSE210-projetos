using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string nome = PerguntarNomeUsuario();
        int numero = PerguntarNumeroFavorito();
        int resultado = ElevarAoQuadrado(numero);
        
        Console.WriteLine($"Olá, {nome}! Seu número favorito é: {numero}");
        Console.WriteLine($"Irmão {nome}, o quadrado do seu número é: {resultado}.");
    }

    static void ExibirBoasVindas()
    {
        Console.WriteLine("Bem-Vindo ao Programa");
    }

    static string PerguntarNomeUsuario()
    {
        Console.Write("Qual é seu nome: ");
        string nome = Console.ReadLine();
        return nome;
    }

    static int PerguntarNumeroFavorito()
    {
        Console.Write($"Qual é seu número favorito? ");
        int numero = int.Parse(Console.ReadLine());
        return numero;
    }

    static int ElevarAoQuadrado( int num)
    {
        return num * num;
    }

}