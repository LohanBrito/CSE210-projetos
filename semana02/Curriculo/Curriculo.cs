//Criando a Classe Curriculo:
using System;
using System.Collections.Generic;

public class Curriculo
{
    public string _nome;
    public List<Emprego> _empregos = new List<Emprego>();

    public void Exibir()
    {
        Console.WriteLine($"Curriculo de {_nome}");
        foreach (Emprego emprego in _empregos)
        {
            emprego.Exibir();
        }
    }
}