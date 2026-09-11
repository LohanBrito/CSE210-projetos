using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Collections.Generic;


//Alterei o arquivo para poder salvar em .CSV
// Utilizei o Switch para poder fazer a seleção das opções mais fluida e limpa no codigo;

class Program
{
    static void Main(string[] args)
    {
        GeradorDePerguntas gerador = new GeradorDePerguntas();
        Diario diario = new Diario();

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nBem-Vindo ao Programa Diário!");
            Console.WriteLine("Por Favor selecione uma das seguintes opções");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer?");
            
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Registro registro = new Registro(gerador);
                    Console.WriteLine($"Pergunta: {registro._textoPergunta}");
                    Console.Write("Digite sua resposta: ");
                    registro._textoResposta = Console.ReadLine();
                    diario.AdicionarRegistro(registro);
                    Console.WriteLine("Registro Feito!");
                    break;

                case "2":
                    Console.WriteLine("\n--- REGISTROS DO DIÁRIO ---\n");
                    diario.ExibirTodos();
                    break;

                case "3":
                    Console.Write("Digite o nome do arquivo: ");
                    string arquivoCarregar = Console.ReadLine();
                    diario.CarregarDoArquivo(arquivoCarregar);
                    Console.WriteLine("Arquivo Carregado com sucesso!");
                    break;

                case "4":
                    Console.Write("Digite o nome do arquivo para salvar: ");
                    string arquivoSalvar = Console.ReadLine();
                    diario.SalvarNovoArquivo(arquivoSalvar);
                    Console.WriteLine("Registro Salvo com sucesso");
                    break;

                case "5":
                    continuar = false;
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção Inválida. Tente Novamente.");
                    break;
            }
        }

    }
}