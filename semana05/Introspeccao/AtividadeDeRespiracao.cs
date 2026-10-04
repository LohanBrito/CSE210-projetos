using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class AtividadeDeRespiracao : Atividade
{
    
    public AtividadeDeRespiracao()
    {
        _nome = "Respiração";
        _descricao = "Esta atividade ajudará você a relaxar, inspirando e expirando lentamente. Limpe sua mente e concentre-se na sua respiração.";    
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        DateTime tempoFinal = DateTime.Now.AddSeconds(_duracao);

        Console.Clear();
        Console.WriteLine("Começando...\n");

        while (DateTime.Now < tempoFinal)
        {
            Console.Write("Inspire...");
            ExibirContagemRegressiva(4);
            Console.WriteLine();

            if (DateTime.Now >= tempoFinal)
                break;

            Console.Write("Expire...");
            ExibirContagemRegressiva(6);
            Console.WriteLine();
        }

        ExibirMensagemFinal();
        
    }
}