//
using System;
using System.Collections.Generic;

public class GeradorDePerguntas
{

    //Atributo privado para poder guardar as perguntas:
    private List<string> _perguntas;

    public GeradorDePerguntas()
    {
        _perguntas = new List<string>
        {
            "Qual foi a parte mais divertida do seu dia?",
            "O que você aprendeu hoje?",
            "Qual desafio você enfrentou hoje?",
            "Por que você está grato hoje?",
            "Qual objetivo você quer alcançar amanhã?"
        };
    }

    public string ObterPerguntaAleatoria()
    {
        Random random = new Random();
        int i = random.Next(_perguntas.Count);
        return _perguntas[i];
    }


}