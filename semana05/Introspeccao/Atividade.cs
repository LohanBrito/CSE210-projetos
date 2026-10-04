using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

public class Atividade
{
    protected string _nome;
    protected string _descricao;
    protected int _duracao;

    public Atividade()
    {
        _nome = "";
        _descricao = "";
        _duracao = 0;
    }

    public void ExibirMensagemInicial()
    {
        Console.Clear();
        Console.WriteLine($"=== Bem Vindo(a) à Atividade de {_nome} ===\n");
        Console.WriteLine(_descricao);
        Console.WriteLine();

        Console.Write("Por quantos segundos você gostaria de realizar esta atividade? ");
        _duracao = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Prepare-se para começar...");
        ExibirProgresso(3);
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine("Muito bem! Te espero na próxima vez");
        ExibirProgresso(3);
        Console.WriteLine($"Você completou os {_duracao} da atividade {_nome}!");
        ExibirProgresso(3);
    }

    public void ExibirProgresso(int segundos)
    {
        string[] animacao = {"|", "/", "-", "\\"};
        DateTime tempofinal = DateTime.Now.AddSeconds(segundos);
        int i = 0;

        while (DateTime.Now < tempofinal)
        {
            Console.Write(animacao[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % animacao.Length;
        }
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i> 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }



}