using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class MetaEterna : Meta
{
    public MetaEterna(string nome, string descricao, string pontos)
    : base(nome, descricao, pontos)
    {   
    }

    public override void RegistrarEvento(ref int pontosTotais)
    {
        pontosTotais += int.Parse(_ponto);
        Console.WriteLine($"Evento registrado para a meta eterna \"{_nome}\"! Você ganhou {_ponto} pontos.");
    }

    public override bool EstaConcluida()
    {
        return false;
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaEterna|{_nome}|{_descricao}|{_ponto}";
    }

    public override string ObterDetalhesEmTexto()
    {
        return $"[ ] {_nome} ({_descricao}) - Meta Eterna";
    }

}