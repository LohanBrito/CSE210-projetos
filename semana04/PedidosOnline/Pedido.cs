using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Pedido
{
    private List<Produto> _produto;
    private Cliente _cliente;

    public Pedido(Cliente clientes, List<Produto> produtos)
    {
        _cliente = clientes;
        _produto = produtos;
    }

    public double CustoTotalDoPedido()
    {
       double totalProdutos = 0;

       foreach (Produto produto in _produto)
       {
            totalProdutos += produto.CustoTotal();     
       } 

       double frete = _cliente.moraNosEUA() ? 5.0 : 35.0;

       return totalProdutos + frete;
    }

    public string EtiquetaEmbalagem()
    {
        string Etiqueta = "----------Etiqueta Embalagem----------\n";

        foreach (Produto produto in _produto)
        {
            Etiqueta += $"(ID: {produto.ObterID()}) - {produto.ObterNome()}\n";
        }

        return Etiqueta;
    }

    public string EtiquetaDeEnvio()
    {
        string etiqueta = "----------Etiqueta De Envio----------\n";
        etiqueta += $"Cliente: {_cliente.ObterNome()}\n";
        etiqueta += $"Endereço: {_cliente.ObterEndereco()}";

        return etiqueta;
    } 

    
}