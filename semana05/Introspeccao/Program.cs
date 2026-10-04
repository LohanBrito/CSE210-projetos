using System;

// controle de não-repetição das perguntas.

class Program
{
    static void Main(string[] args)
    {            

        bool continuar = true;


        while(continuar)
        {            
            Console.WriteLine("\nBem-Vindo ao Programa Introspecção!");
            Console.WriteLine("Por Favor selecione uma das seguintes opções");
            Console.WriteLine("1. Atividade de Respiração");
            Console.WriteLine("2. Atividade de Reflexão");
            Console.WriteLine("3. Atividade de Listagem");
            Console.WriteLine("4. Sair");
            Console.Write("O que você gostaria de fazer? ");
                      
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AtividadeDeRespiracao respiracao = new AtividadeDeRespiracao();
                    respiracao.Executar();
                    break;
                
                case "2":
                    AtividadeDeReflexao reflexao = new AtividadeDeReflexao();
                    reflexao.Executar();
                    break;
                
                case "3":
                    AtividadeDeListagem listagem = new AtividadeDeListagem();
                    listagem.Executar();
                    break;

                case "4":
                Console.WriteLine("\nObrigado por participar do Programa de Introspecção");
                continuar = false;
                break;

                default:
                    Console.WriteLine("\nOpção inválida. Pressione ENTER para tentar novamente.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}