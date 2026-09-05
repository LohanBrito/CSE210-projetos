using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual o percentual da sua nota? ");
        string resposta = Console.ReadLine();
        int nota = int.Parse(resposta);

        string letra = "";

        if (nota >= 90)
        {
            letra = "A";
        }
        else if (nota >= 80)
        {
            letra = "B";
        }
        else if (nota >= 70)
        {
            letra = "C";
        }
        else if (nota >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }
        
        Console.WriteLine($"Sua nota é: {letra}");

        if (nota >= 70)
        {
            Console.WriteLine("Parabéns! Você passou!");
        }
        else
        {
            Console.WriteLine("Não foi dessa vez. Tente Novamente!");
        }
    }
}