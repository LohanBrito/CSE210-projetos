using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Atividade
{
    protected string _nomeAtividade;
    protected int _tempo;
    protected DateTime _data;

    public Ativide(string nomeAtividade, int tempo, DateTime data)
    {
        _nomeAtividade = nomeAtividade;
        _tempo = tempo;
        _data = data;
    }

    public string ObterNome() => _nomeAtividade;
    public int ObterTempo() => _tempo;
    public DateTime ObterData() => _data;


    public virtual double ObterDistancia() => 0.0;   

    public virtual double ObterVelocidade() => 0.0;
    public virtual double ObterRitmo() => 0.0;
    
    public abstract string ObterResumo()
    {
        return $"{data} {nomeAtividade} ({tempo}): Distância {distancia} Km, Velocidade: {velocidade} Km/h, Ritmo: {ritmo} min por Km";
    }

}