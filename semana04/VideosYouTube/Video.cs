using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


public class Video
{
    private string _titulo;
    private string _autor;
    private double _duracao;
    private List<Comentario> _comentarios;

    public Video(string titulo, string autor, double duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
        _comentarios = new List<Comentario>();
    }

    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    public int NumeroDeComentarios()
    {
        return _comentarios.Count;
    }

    public string ObterTitulo()
    {
        return _titulo;
    }

    public string ObterAutor()
    {
        return _autor;
    }

    public double ObterDuracao()
    {
        return _duracao;
    }

    public List<Comentario> ObterComentario()
    {
        return _comentarios;
    }

}

