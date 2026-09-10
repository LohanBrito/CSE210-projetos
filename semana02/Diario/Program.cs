using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Registro registro = new Registro();
        registro._data = 2026;
        registro._textoPergunta = "Qual foi sua experiencia espiritual de hoje";
        registro._textoResposta = "Foi sentir o Senhor falando comigo dutante meu estudo.";

        registro.Exibir();

    }
}