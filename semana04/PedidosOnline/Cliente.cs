using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Cliente
{
    private string _nome;
    private Endereco _endereco;

    public Cliente(string nome, Endereco endereco)
    {
        _nome = nome;
        _endereco = endereco;
    }

    public bool MoraNosEUA()
    {
        return _endereco.MoraNosEUA();
    }

    public string ObterNome()
    {
        return _nome;
    }

    public Endereco ObterEndereco()
    {
        return _endereco;
    }


}