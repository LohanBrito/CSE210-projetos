using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        GerenciadorDeMetas gerenciador = new GerenciadorDeMetas();
        gerenciador.Iniciar();
    }
}