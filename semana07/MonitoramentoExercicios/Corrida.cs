using System;
using System.Collections.Generic;
using System.IO;

public class Corrida : Atividade
{
    protected double _distancia;

    public Corrida(string nomeAtividade, int tempo, DateTime data, double distancia)
    : base (nomeAtividade, tempo, data)
    {
        _distancia = distancia;       
    }

    public override double ObterDistancia() => _distancia;
    
    public override double ObterVelocidade()
    {
        return (_distancia / ObterTempo()) * 60.0;
    }

    public override double ObterRitmo()
    {
        return ObterTempo() / _distancia;
    }

    


    
}