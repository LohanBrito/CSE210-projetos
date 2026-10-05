using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


public class Quadrado : Figura
{
    private double _lado;

    public Quadrado(string cor, double lado) 
    : base(cor)
    {
        _lado = lado;
    }


    public override double ObterArea()
    {
       return _lado * _lado; 
    }

}