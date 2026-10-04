using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class AtividadeDeReflexao : Atividade
{
    private List<string> _reflexoes;
    private List<string> _perguntas;

    // Listas auxiliares para controlar os itens restantes
    private List<string> _perguntasNaoUsadas;
    private List<string> _reflexoesNaoUsadas;

    public AtividadeDeReflexao()
    {
        _nome = "Reflexão";
        _descricao = "Esta atividade ajudará você a refletir sobre momentos da sua vida em que você demonstrou força e resiliência. Isso ajudará você a reconhecer o poder que você tem e como pode usá-lo em outros aspectos da sua vida.";
        _perguntas = new List<string>
        {
            "Pense em uma ocasião em que você defendeu outra pessoa.",
            "Pense em uma ocasião em que você fez algo realmente difícil.",
            "Pense em uma ocasião em que você ajudou alguém necessitado.",
            "Pense em uma ocasião em que você fez algo verdadeiramente altruísta.",
        };

        _reflexoes = new List<string>
        {
            "Por que essa experiência foi significativa para você?",
            "Você já fez algo assim antes?",
            "Como você começou?",
            "Como você se sentiu quando terminou?",
            "O que tornou esse momento diferente de outras vezes em que você não teve tanto sucesso?",
            "Qual é a sua coisa favorita sobre essa experiência?",
            "O que você pode aprender com essa experiência que se aplica a outras situações?",
            "O que você aprendeu sobre si mesmo por meio dessa experiência?",
            "Como você pode manter essa experiência em mente no futuro?",
        };

        //Inicializa as listas de controle com uma cópia das originais
        _perguntasNaoUsadas = new List<string>(_perguntas);
        _reflexoesNaoUsadas = new List<string>(_reflexoes);

    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Console.Clear();
        Console.WriteLine("Considere a seguinte pergunta:\n");

        ExibirPerguntas();

        Console.WriteLine("\nQuando você tiver algo em mente, pressione ENTER para continuar.");
        Console.ReadLine();

        Console.WriteLine("Agora reflita sobre cada uma das seguintes questões relacionadas a essa experiência.");
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(5);
        Console.Clear();

        DateTime tempoFinal = DateTime.Now.AddSeconds(_duracao);

        while (DateTime.Now < tempoFinal)
        {
            ExibirReflexoes();
            ExibirProgresso(5);
            Console.WriteLine();
        }

        ExibirMensagemFinal();
    }

    public string ObterReflexoesAleatorias()
    {
        // Se todas já foram usadas, recarrega a lista
        if (_reflexoesNaoUsadas.Count == 0)
        {
            _reflexoesNaoUsadas = new List<string>(_reflexoes);
        }

        Random random = new Random();
        int indice = random.Next(_reflexoesNaoUsadas.Count);

        string reflexaoSelecionada = _reflexoesNaoUsadas[indice];
        _reflexoesNaoUsadas.RemoveAt(indice); // Remove para não repetir

        return reflexaoSelecionada;
    }


    public string ObterPerguntasAleatorias()
    {
        // Se todas já foram usadas, recarrega a lista
        if (_perguntasNaoUsadas.Count == 0)
        {
            _perguntasNaoUsadas = new List<string>(_perguntas);
        }

        Random random = new Random();
        int indice = random.Next(_perguntasNaoUsadas.Count);
        
        string perguntaSelecionada = _perguntasNaoUsadas[indice];
        _perguntasNaoUsadas.RemoveAt(indice); // Remove para não repetir

        return perguntaSelecionada;
    }

    public void ExibirReflexoes()
    {
        string reflexao = ObterReflexoesAleatorias();
        Console.Write($"> {reflexao} ");
    }

    public void ExibirPerguntas()
    {
        string pergunta = ObterPerguntasAleatorias();
        Console.WriteLine($"--- {pergunta} ---");
    }
}