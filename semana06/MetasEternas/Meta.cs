using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public abstract class Meta
{
    protected string _nome;
    protected string _descricao;
    protected string _ponto;

    public Meta(string nome, string descricao, string pontos)
    {
        _nome = nome;
        _descricao = descricao;
        _ponto = pontos;
    }

    public string ObterNome() => _nome;
    public string ObterDescricao() => _descricao;
    public string ObterPontos() => _ponto;

    
    public abstract void RegistrarEvento(ref int pontosTotais);

    public abstract bool EstaConcluida();

    public abstract string ObterDetalhesEmTexto();

    public abstract string ObterRepresentacaoEmTexto();

}