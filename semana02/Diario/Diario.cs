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
        
    }
    
}