using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class AtividadeDeListagem : Atividade
{
    private int _contador;
    private List<string> _perguntas;


    public AtividadeDeListagem()
    {
        _nome = "Listagem";
        _descricao = "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, fazendo com que você liste o máximo de coisas que puder em uma determinada área.";
        _contador = 0;
        _perguntas = new List<string>
        {
            "Quem são as pessoas que você aprecia?",
            "Quais são seus pontos fortes pessoais?",
            "Quem são as pessoas que você ajudou esta semana?",
            "Quando você sentiu o Espírito Santo neste mês?",
            "Quem são alguns dos seus heróis pessoais?"
        };

    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Console.Clear();
        Console.WriteLine("Considere a seguinte pergunta:\n");

        ObterPerguntaAleatoria();

        Console.Write("\nVocê pode começar em: ");
        ExibirContagemRegressiva(5);
        Console.WriteLine("\n");

        List<string> ListaDoUsuario = ObterListaDoUsuario();

        _contador = ListaDoUsuario.Count;
        Console.WriteLine($"\nVocê listou {_contador} itens!");

        ExibirMensagemFinal();
    }

    public void ObterPerguntaAleatoria()
    {
        Random random = new Random();
        int indice = random.Next(_perguntas.Count);
        Console.WriteLine($"--- {_perguntas[indice]} ---");
    }

    public List<string> ObterListaDoUsuario()
    {
        List<string> itens = new List<string>();
        DateTime tempoFinal = DateTime.Now.AddSeconds(_duracao);

        while (DateTime.Now < tempoFinal)
        {
            Console.Write("> ");
            string entrada = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(entrada))
            {
                itens.Add(entrada);
            }
        }

        return itens;             
    }
}