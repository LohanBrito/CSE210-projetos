using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Atividade
{
    private string _nome;
    private string _descricao;
    private int _duracao;

    public Atividade(string nome, string descricao, int duracao)
    {
        _nome = nome;
        _descricao = descricao;
        _duracao = duracao;
    }

    public void ExibirMensagemInicial()
    {
        
    }

    public void ExibirMensagemFinal()
    {
        
    }

    public void ExibirProgresso(int segundos)
    {
        
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        
    }



}