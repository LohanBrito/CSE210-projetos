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

    // Alteração para poder salvar o arquivo em .CSV;
    public void SalvarNovoArquivo(String arquivo)
    {
        using (StreamWriter writer = new StreamWriter(arquivo, true))
        {
            foreach (var registro in _registros)
            {
                string data = registro._data.ToString("yyy-MM-dd");
                string pergunta = EscapeCsv(registro._textoPergunta);
                string resposta = EscapeCsv(registro._textoResposta);
                
                writer.WriteLine($"{data},{pergunta},{resposta}");
            }
        }
    }

    // Função auxiliar para tratar vírgula e aspas;
    private string EscapeCsv(string campo)
    {
        if (campo.Contains(",") || campo.Contains("\""))
        {
            campo = campo.Replace("\"", "\"\""); 
            campo = $"\"{campo}\""; 
        }
        return campo;
    }

    public void CarregarDoArquivo(string arquivo)
    {
        if (File.Exists(arquivo))
        {
            _registros.Clear();
            string[] linhas = File.ReadAllLines(arquivo);
            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(",");
                if (partes.Length == 3)
                {
                    Registro registro = new Registro(new GeradorDePerguntas());
                    registro._data = DateTime.Parse(partes[0]);
                    registro._textoPergunta = partes[1].Trim('"');
                    registro._textoResposta = partes[2].Trim('"');
                    _registros.Add(registro);
                }
            }
        }
    }
}