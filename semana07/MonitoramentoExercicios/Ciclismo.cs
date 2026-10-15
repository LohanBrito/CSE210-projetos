using System;
using System.Collections.Generic;
using System.IO;

public class Ciclismo : Atividade
{
    protected double _velocidade;

    public Ciclismo(string nomeAtividade, int tempo, DateTime data, double velocidade)
    : base (nomeAtividade, tempo, data)
    {
        _velocidade = velocidade;       
    }

    public override double ObterVelocidade() => _velocidade;
    
    public override double ObterDistancia()
    {
        return (_velocidade * ObterTempo()) / 60.0;
    }

    public override double ObterRitmo()
    {
        return ObterTempo() / ObterDistancia();
    }
    
}