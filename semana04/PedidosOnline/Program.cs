using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Produto produto1 = new Produto(1, "Teclado", 100.00, 1);
        Produto produto2 = new Produto(2, "Mouse", 30, 2);
        Produto produto3 = new Produto(3, "Headphone", 100, 1);

        List<Produto> listaProduto = new List<Produto>();
        listaProduto.Add(produto1);
        listaProduto.Add(produto2);
        listaProduto.Add(produto3);
        
        Endereco endereco1 = new Endereco("AV. Simeao", "JF", "MG", "Brasil");
        Endereco endereco2 = new Endereco("Rua Dezesseis", "Cuiabá", "MT", "Brasil");
        Endereco endereco3 = new Endereco("Joseph", "Salt Lake City", "UTAH", "EUA");
        
        
        
        Cliente cliente1 = new Cliente("Joao", endereco1);
        Cliente cliente2 = new Cliente("Josimar", endereco1);
        Cliente cliente3 = new Cliente("Lais", endereco3);

        Pedido pedido1 = new Pedido(cliente1, listaProduto);
        Pedido pedido2 = new Pedido(cliente2, listaProduto);
        Pedido pedido3 = new Pedido(cliente3, listaProduto);

        Console.WriteLine(pedido1.EtiquetaEmbalagem());
        Console.WriteLine(pedido1.EtiquetaDeEnvio());
        Console.WriteLine($"Custo Total do Pedido 1: {pedido1.CustoTotalDoPedido()}");
        Console.WriteLine("\n-------------------------------------\n");

    }
}