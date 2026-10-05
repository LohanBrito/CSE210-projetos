using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Figura
{
    protected string _cor;

    public Figura(string cor)
    {
        _cor = cor;
    }


    public string ObterCor()
    {
        return _cor;
    }

    public void DefinirCor(string cor)
    {
        _cor = cor;
    }

    public virtual double ObterArea()
    {
        return 0;
    }

    
}