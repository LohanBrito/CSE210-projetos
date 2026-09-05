using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        
        List<int> lista = new List<int>();
        int numero;

        do
        {
            Console.Write("Insira uma lista de números e digite 0 quando terminar: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                lista.Add(numero);
                Console.WriteLine("Você digitou o número: " + numero);
            }   

        }
        
        while (numero != 0);
        {
            if (lista.Count > 0)
            {
                int soma = lista.Sum();
                double media = lista.Average();
                int maior = lista.Max();
                int total = lista.Count;

                var ordenada = lista.OrderBy(x => x).ToList();

                Console.WriteLine("Soma: " + soma);
                Console.WriteLine("Média: " + media);
                Console.WriteLine("O maior número é: " + maior);
                Console.WriteLine("Total de itens: " + total);
                Console.WriteLine("Lista ordenada: " + string.Join(", ", ordenada));   
            }

            else
            {
              Console.WriteLine("Nenhum número digitado");  
            }
        }  
    }
}