using System;
using System.Collections.Generic;
using System.IO;

public class Natacao : Atividade
{
     protected double _numeroVoltas;

    public Natacao(string nomeAtividade, int tempo, DateTime data, double numeroVoltas)
    : base (nomeAtividade, tempo, data)
    {
        _numeroVoltas = numeroVoltas;       
    }

    public override double ObterVelocidade()
    {
        if (ObterTempo() == 0) return 0;
        return (ObterDistancia() / ObterTempo()) * 60.0;
    }
    
    public override double ObterDistancia()
    {
        return (_numeroVoltas * 50.0) / 1000;
    }

    public override double ObterRitmo()
    {
        double distancia = ObterDistancia();
        if (distancia == 0) return 0;
        return ObterTempo() / ObterDistancia();
    }
    
}