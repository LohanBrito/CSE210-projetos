using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Comentario
{
    private string _nomeComentario;
    private string _textoComentario;


    public Comentario(string nomeComentario, string textoComentario)
    {
        _nomeComentario = nomeComentario;
        _textoComentario = textoComentario;
    }

    public string ObterNomeComentario()
    {
        return _nomeComentario;
    }

    public string ObterTextoComentario()
    {
        return _textoComentario;
    }



}