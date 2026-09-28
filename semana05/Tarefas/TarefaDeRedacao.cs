using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class TarefaDeRedacao : Tarefa
{
    private string _titulo;

    public TarefaDeRedacao(string aluno, string topico, string titulo)
    : base(aluno, topico)
    {
        _titulo = titulo;
    }

    public string ObterInformacoesDaREdacao()
    {
        return $"{_titulo}, por {ObterNomeEstudante()}";
    }

}