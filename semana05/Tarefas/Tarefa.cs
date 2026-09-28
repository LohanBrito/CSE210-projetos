using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


public class Tarefa
{
    private string _nomeEstudante;
    private string _topico;

    public Tarefa(string aluno, string topico)
    {
        _nomeEstudante = aluno;
        _topico = topico;
    }

    public string ObterResumo()
    {
        return $"\n{_nomeEstudante} - {_topico}";
    }

    public string ObterNomeEstudante()
    {
        return _nomeEstudante;
    }

    public string ObterTopico()
    {
        return _topico;
    }
}


