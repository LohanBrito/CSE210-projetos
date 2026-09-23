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
        Produto produto4 = new Produto(4, "Mousepad", 50.00, 1);
        Produto produto5 = new Produto(5, "Lanterna", 20, 2);

        List<Produto> listaProduto1 = new List<Produto>();
        listaProduto1.Add(produto1);
        listaProduto1.Add(produto2);
        listaProduto1.Add(produto3);

        List<Produto> listaProduto2 = new List<Produto>();
        listaProduto2.Add(produto1);
        listaProduto2.Add(produto2);
        listaProduto2.Add(produto4);

        List<Produto> listaProduto3 = new List<Produto>();
        listaProduto3.Add(produto1);
        listaProduto3.Add(produto2);
        listaProduto3.Add(produto5);
        
        Endereco endereco1 = new Endereco("AV. Simeao", "JF", "MG", "Brasil");
        Endereco endereco2 = new Endereco("Rua Dezesseis", "Cuiabá", "MT", "Brasil");
        Endereco endereco3 = new Endereco("Joseph", "Salt Lake City", "UTAH", "EUA");
        
        
        
        Cliente cliente1 = new Cliente("Joao", endereco1);
        Cliente cliente2 = new Cliente("Josimar", endereco2);
        Cliente cliente3 = new Cliente("Lais", endereco3);

        Pedido pedido1 = new Pedido(cliente1, listaProduto1);
        Pedido pedido2 = new Pedido(cliente2, listaProduto2);
        Pedido pedido3 = new Pedido(cliente3, listaProduto3);


        Console.WriteLine(pedido1.EtiquetaEmbalagem());
        Console.WriteLine(pedido1.EtiquetaDeEnvio());
        Console.WriteLine($"Custo Total do Pedido 1: {pedido1.CustoTotalDoPedido()}");
        Console.WriteLine("\n-------------------------------------\n");

        Console.WriteLine(pedido2.EtiquetaEmbalagem());
        Console.WriteLine(pedido2.EtiquetaDeEnvio());
        Console.WriteLine($"Custo Total do Pedido 2: {pedido2.CustoTotalDoPedido()}");
        Console.WriteLine("\n-------------------------------------\n");

        Console.WriteLine(pedido3.EtiquetaEmbalagem());
        Console.WriteLine(pedido3.EtiquetaDeEnvio());
        Console.WriteLine($"Custo Total do Pedido 3: {pedido3.CustoTotalDoPedido()}");
        Console.WriteLine("\n-------------------------------------\n");

    }
}