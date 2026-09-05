using System;

class Program
{
    static void Main(string[] args)
    {
        //Foi utilizado para digitar na primeira parte do exercicio.
        //Console.Write("Qual é seu número mágico? ");
        //string numMagico = Console.ReadLine();
        //int numero = int.Parse(numMagico);

        //Feita a parte com numero Randon;
        //Acrescentados os desafios adicionais.

        string jogarNovamente = "sim";

        while (jogarNovamente.ToLower() == "sim")
        {
            Random geradorRandom = new Random();
            int numero = geradorRandom.Next(1, 101);

            int palpite = -1;
            int contadorPalpite = 0;

            Console.WriteLine("Tente adivinhar o número de 1 a 100!");

            while (palpite != numero)
            {
                Console.Write("Qual é seu palpite? ");
                string numPalpite = Console.ReadLine();
                palpite = int.Parse(numPalpite);
                contadorPalpite++;
            
                if (palpite < numero)
                {
                    Console.WriteLine("Mais Alto");
                }

                else if (palpite > numero)
                {
                    Console.WriteLine("Mais baixo");
                }

                else
                {
                    Console.WriteLine("Você Adivinhou! Parabéns");
                    Console.WriteLine($"Você fez {contadorPalpite} palpites nessa jogada.");
                }  
            }
            Console.Write("Deseja Jogar novamente? (sim/não): ");
            jogarNovamente = Console.ReadLine();  
        }
        Console.WriteLine("Obrigado por jogar!");              
    }
}