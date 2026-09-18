using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavra;


    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavra = new List<Palavra>();

        // Separar o texto em palavras:
        string[] palavrasTexto = texto.Split(' ');
        foreach (string palavra in palavrasTexto)
        {
            _palavra.Add(new Palavra(palavra));
        }
    }

    //Será feito um filtro das palavras que não foram ocultadas.
    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        Random random = new Random();

        List<Palavra> palavrasVisiveis = _palavra.Where(p => !p.EstaOculta()).ToList();

        for (int i = 0; i < quantidadeAOcultar; i++)
        {
            int indiceAleatorio = random.Next(palavrasVisiveis.Count);
            palavrasVisiveis[indiceAleatorio].Ocultar();

            // Remove da lista a palavra já ocultada no loop.
            palavrasVisiveis.RemoveAt(indiceAleatorio);
        }
    }

        public string ObterTexto()
        {
            List<string> textosPalavras = new List<string>();

            foreach (Palavra palavra in _palavra)
            {
                textosPalavras.Add(palavra.ObterTexto());
            }

            string textoCompleto = string.Join(" ", textosPalavras);

            return $"{_referencia.ObterTexto()} - {textoCompleto}";
        }

        public bool EstaCompletamenteOculta()
        {
            foreach (Palavra palavra in _palavra)
            {
                if(!palavra.EstaOculta())
                {
                    return false;
                }
            }
            return true;
        }

    }
}