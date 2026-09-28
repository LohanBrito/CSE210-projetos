using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Tarefa tarefa = new Tarefa("Samuel Silva", "Multipicação");    
        Console.WriteLine(tarefa.ObterResumo());

        TarefaDeMatematica tarefaMat = new TarefaDeMatematica("Robert Rodriguez", "Frações", "7.3", "8-19");
        Console.WriteLine(tarefaMat.ObterResumo());
        Console.WriteLine(tarefaMat.ObterListaDeTarefas());

        TarefaDeRedacao tarefaRed = new TarefaDeRedacao("Maria Antunes", "História da Europa", "As Causas da Segunda Guerra Mundial");
        Console.WriteLine(tarefaRed.ObterResumo());
        Console.WriteLine(tarefaRed.ObterInformacoesDaREdacao());
    }
}