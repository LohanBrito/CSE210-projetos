using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        List<Video> ListaDeVideos = new List<Video>();
        
        Video v1 = new Video("Aprenda C#", "Joao Castro", 600);
        v1.AdicionarComentario(new Comentario("Maria", "Excelente Aula"));
        v1.AdicionarComentario(new Comentario("Joana", "Gostei bastante"));
        v1.AdicionarComentario(new Comentario("Igor","Muito bom"));
        ListaDeVideos.Add(v1);

        Video v2 = new Video("Como aprender", "Izabella Fagundes", 100);
        v2.AdicionarComentario(new Comentario("Josias","Aprender é fácil"));
        v2.AdicionarComentario(new Comentario("Carlos","Simples a explicação"));
        v2.AdicionarComentario(new Comentario("José","Direto ao ponto"));
        ListaDeVideos.Add(v2);

        Video v3 = new Video("Ser Pacificador", "Irmão João", 700);
        v3.AdicionarComentario(new Comentario("Laura","Realmente preciso melhorar"));
        v3.AdicionarComentario(new Comentario("Isazbel","Profundo"));
        v3.AdicionarComentario(new Comentario("Tiago","Precisamos pacificar o planeta"));
        ListaDeVideos.Add(v3);

        foreach (Video v in ListaDeVideos)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Título: {v.ObterTitulo()}");
            Console.WriteLine($"Autor: {v.ObterAutor()}");
            Console.WriteLine($"Duração: {v.ObterDuracao()} segundos");
            Console.WriteLine($"Nº de Comentários: {v.NumeroDeComentarios()}");
            Console.WriteLine("Comentários:");

            foreach (Comentario c in v.ObterComentario())
            {
                Console.WriteLine($"{c.ObterNomeComentario()}: {c.ObterTextoComentario()}");
            }
            Console.WriteLine("------------------------------");
        }
    }
}