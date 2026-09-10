//
using System;
using System.Collections.Generic;
using System.Data;

public class Registro
{
    public DateTime _data;
    public string _textoPergunta;
    public string _textoResposta;

    //Contrutor que recebe o GeradorDePerguntas:
    public Registro(GeradorDePerguntas gerador)
    {
        _data = DateTime.Now;
        _textoPergunta = gerador.ObterPerguntaAleatoria();
    }

    public void Exibir()
    {
        Console.WriteLine($"{_data.ToShortDateString()} - {_textoPergunta}? {_textoResposta}");
    }
}