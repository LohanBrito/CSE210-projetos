using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class TarefaDeMatematica : Tarefa
{
    private string _capitulo;
    private string _problemas;

    public TarefaDeMatematica(string aluno, string topico, string capitulo, string problemas)
    : base(aluno, topico)
    {
        _capitulo = capitulo;
        _problemas = problemas;
    }
    
    public string ObterListaDeTarefas()
    {
        return $"Capítulo {_capitulo} - Problemas {_problemas}";
    }

}