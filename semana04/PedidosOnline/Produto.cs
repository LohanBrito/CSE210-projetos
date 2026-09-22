using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Produto
{
    private string _nomeProduto;
    private int _ID;
    private double _preco;
    private int _quantidade;

    public Produto(int ID, string nomeProduto, double preco, int quantidade)
    {
        _ID = ID;
        _nomeProduto = nomeProduto;
        _preco = preco;
        _quantidade = quantidade;
    }

    public double CustoTotal()
    {
        return _preco * _quantidade;
    }

    public string ObterNome()
    {
        return _nomeProduto;
    }

    public int ObterID()
    {
        return _ID;
    }

}