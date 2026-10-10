using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class MetaSimples : Meta
{
    protected bool _estaConcluida = false;

    public MetaSimples(string nome, string descricao, string pontos, bool estaConcluida)
    : base(nome, descricao, pontos)
    {
        _estaConcluida = estaConcluida;
    }

    public override void RegistrarEvento(ref int pontosTotais)
    {
        if (!_estaConcluida)
        {
            _estaConcluida = true;
            pontosTotais += int.Parse(_ponto);
            Console.Write($"Parabéns!!! Você concluiu a meta '{_nome}' e ganhou {_ponto} pontos!");
        }

        else
        {
            Console.WriteLine($"A meta '{_nome}' já foi concluída anteriormente.");
        }
    }

    public override bool EstaConcluida()
    {
        return _estaConcluida;
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaSimples | {_nome} | {_descricao} | {_ponto} | {_estaConcluida}";
    }

    public override string ObterDetalhesEmTexto()
    {
        string status = _estaConcluida ? "[X]" : "[ ]";
        return $"{status} {_nome} ({_descricao})";
    }
}