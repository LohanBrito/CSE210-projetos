//
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;


public class Diario
{
    private List<Registro> _registros;

    public Diario()
    {
        _registros = new List<Registro>();
    }

    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }

    public void ExibirTodos()
    {
        foreach (var registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarNovoArquivo(String arquivo)
    {
        using (StreamWriter writer = new StreamWriter(arquivo, true))
        {
            foreach (var registro in _registros)
            {
                writer.WriteLine($"{registro._data};{registro._textoPergunta};{registro._textoResposta}");
            }
        }
    }

    public void CarregarDoArquivo(string arquivo)
    {
        if (File.Exists(arquivo))
        {
            _registros.Clear();
            string[] linhas = File.ReadAllLines(arquivo);
            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(";");
                if (partes.Length == 3)
                {
                    Registro registro = new Registro(new GeradorDePerguntas());
                    registro._data = DateTime.Parse(partes[0]);
                    registro._textoPergunta = partes[1];
                    registro._textoResposta = partes[2];
                    _registros.Add(registro);
                }
            }
        }
    }
}