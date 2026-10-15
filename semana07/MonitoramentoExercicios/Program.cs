using System;

class Program
{
    static void Main(string[] args)
    {
        List<Atividade> atividades = new List<Atividade>();

        Corrida corrida = new Corrida("Corrida", 30, new DateTime(2022, 11, 3), 4.8);
        Ciclismo ciclismo = new Ciclismo("Ciclismo", 30, new DateTime(2022, 11, 3), 9.7);
        Natacao natacao = new Natacao("Natação", 30, new DateTime(2022, 11, 3), 20); 

        atividades.Add(corrida);
        atividades.Add(ciclismo);
        atividades.Add(natacao);

        foreach (Atividade atividade in atividades)
        {
            Console.WriteLine(atividade.ObterResumo());
        }
    }
}