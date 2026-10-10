using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class MetaDeListaDeTarefas : Meta
{
    
    protected int _concluidas = 0;
    protected int _total = 0;
    protected int _bonus = 0;

    public MetaDeListaDeTarefas(string nome, string descricao, string pontos, int total, int bonus)
    : base(nome, descricao, pontos)
    {
        _total = total;
        _bonus = bonus;
        _concluidas = 0;
    }

    public MetaDeListaDeTarefas(string nome, string descricao, string pontos, int total, int bonus, int concluidas)
        : base(nome, descricao, pontos)
    {
        _total = total;
        _bonus = bonus;
        _concluidas = concluidas;
    }

    public override void RegistrarEvento(ref int pontosTotais)
    {
     if (_concluidas < _total)
        {
            _concluidas++;
            int pontosAtuais = int.Parse(_ponto);
            pontosTotais += pontosAtuais;

            Console.WriteLine($"Progresso registrado para '{_nome}'. Você ganhou {pontosAtuais} pontos!");

            if (_concluidas == _total)
            {
                pontosTotais += _bonus;
                Console.WriteLine($"Parabéns!!! Meta concluída de {_total}/{_total}. Bonus de {_bonus} pontos aplicados!");
            }

        else
        {
            Console.WriteLine($"A meta '{_nome}' já foi concluída anteriormente.");
        }
        }
    }

    public override bool EstaConcluida()
    {
        return _concluidas >= _total;
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaDeListaDeTarefas|{_nome}|{_descricao}|{_ponto}|{_total}|{_bonus}|{_concluidas}";
    }

    public override string ObterDetalhesEmTexto()
    {
        string status = EstaConcluida() ? "[X]" : "[ ]";
        return $"{status} {_nome} ({_descricao}) -- Concluídas atualmente: {_concluidas}/{_total} vezes";
    }
}