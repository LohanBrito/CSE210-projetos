using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

//Acrescentado um temporizador no encerramento para poder parecer mais interativo;
//Foi adicionado a opção de excluir uma meta. Caso o usuário digitou errado ou acabou aquela meta e desejou limpar o sistema.

class Program
{
    static void Main(string[] args)
    {
        GerenciadorDeMetas gerenciador = new GerenciadorDeMetas();
        gerenciador.Iniciar();
    }
}