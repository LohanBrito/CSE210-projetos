using System;
using System.Collections.Generic;
using System.Linq;


public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavra;


    public void Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavra = new List<Palavra>;

        // Separar o texto em palavras:
        string[] palavrasTexto = texto.Split(' ');
        foreach (string palavra in palavrasTexto)
        {
            _palavra.Add(new Palavra(palavra));
        }
    }








}