using System;
using System.Collections.Generic;
using System.IO;

public class GerenciadorDeMetas
{
    private List<Meta> _metas;
    private int _pontos = 0;

    public GerenciadorDeMetas()
    {
        _pontos = 0;
        _metas = new List<Meta>();
    }

    public GerenciadorDeMetas(int pontos)
    {
        _pontos = pontos;
        _metas = new List<Meta>();
    }
    
    public void Iniciar()
    {
        
        int opcao = 0;
        do
        {
            Console.Clear();
            ExibirInfoJogador();
            Console.WriteLine("Opções do Menu: ");
            Console.WriteLine("1. Criar Nova Meta");
            Console.WriteLine("2. Listar Metas");
            Console.WriteLine("3. Salvar Metas");
            Console.WriteLine("4. Carregar Metas");
            Console.WriteLine("5. Registrar Evento");
            Console.WriteLine("6. Sair");
            Console.WriteLine("\nEscolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        CriarMeta();
                        break;
                    case 2:
                        ListaDetalhesDasMetas();
                        break;
                    case 3:
                        SalvarMetas();
                        break;
                    case 4:
                        CarregarMetas();
                        break;
                    case 5:
                        RegistrarEvento();
                        break;
                    case 6:
                        Console.WriteLine("\nSaindo...");
                        Console.WriteLine("Até Logo");
                        break;
                    default:
                        Console.WriteLine("\nEntrada inválida. Pressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nEntrada inválida. Pressione qualquer tecla para continuar.");
                Console.ReadKey();
            }
        } while (opcao != 6);
    }

    public void ExibirInfoJogador()
    {
        Console.WriteLine($"Você tem {_pontos} pontos.");
    }

    public void ListaNomesDasMetas()
    {
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterNome()}");
        }
    }

    public void ListaDetalhesDasMetas()
    {
        Console.Clear();
        Console.WriteLine("Lista de Objetivos>\n");
        if (_metas.Count == 0)
        {
            Console.WriteLine("Nenhuma meta cadastrada");
        }
        else
        {
            for (int i = 0; i < _metas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_metas[i].ObterDetalhesEmTexto()}");
            }
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    public void CriarMeta()
    {
        Console.Clear();
        Console.WriteLine("Tipos de Meta:");
        Console.WriteLine("1. Meta Simples");
        Console.WriteLine("2. Meta Eterna");
        Console.WriteLine("3. Meta de Lista de Tarefas (Checklist)");
        Console.Write("Escolha o tipo de meta que deseja criar: ");

        if (int.TryParse(Console.ReadLine(), out int tipo))
        {
            Console.WriteLine("Digite o nome da meta: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a descrição da meta: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de pontos para meta: ");
            string pontos = Console.ReadLine();

            switch (tipo)
            {
                case 1:
                    _metas.Add(new MetaSimples(nome, descricao, pontos, false));
                    break;
            
                case 2:
                    _metas.Add(new MetaEterna(nome, descricao, pontos));
                    break;
            
                case 3:
                    Console.Write("Digite quantas vezes essa meta deve ser cumprida: ");
                    int total = int.Parse(Console.ReadLine());

                    Console.Write("Digite os pontos de bônus ao concluir todas as vezes: ");
                    int bonus = int.Parse(Console.ReadLine());

                    _metas.Add(new MetaDeListaDeTarefas(nome, descricao, pontos, total, bonus));
                    break;
            
                default:
                    Console.WriteLine("Tipo inválido.");
                    break;
            }
            Console.WriteLine("\nMeta criada com sucesso! Pressione qualquer tecla para continuar.");
        }
        else
        {
            Console.WriteLine("\nEntrada inválida.");
        }
        Console.ReadKey();
    }

    public void RegistrarEvento()
    {
        Console.Clear();
        if (_metas.Count == 0)
        {
           Console.WriteLine("Não há metas cadastradas para registrar eventos."); 
        }
        else
        {
            Console.WriteLine("Escolha qual meta realizou o evento: ");
            for (int i = 0; i < _metas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_metas[i].ObterNome()}");
            }

            Console.Write("\nNúmero da Meta: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >=1 && indice <= _metas.Count)
            {
                _metas[indice -1].RegistrarEvento(ref _pontos);
            }
            else
            {
                Console.WriteLine("Seleção inválida.");
            }
        }
        Console.WriteLine("\nPressione qualquer tecla para continuar.");
        Console.ReadKey();
    }

    public void SalvarMetas()
    {
        Console.Clear();
        Console.Write("Digite o nome do arquivo para salvar (ex: metas.txt): ");
        string nomeArquivo = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(nomeArquivo))
        {
            sw.WriteLine(_pontos);
            foreach (Meta meta in _metas)
            {
                sw.WriteLine(meta.ObterRepresentacaoEmTexto());
            }
        }
        Console.WriteLine("\nMetas e pontos salvos com sucesso! Pressione qualquer tecla para continuar.");
        Console.ReadKey();
    }

    public void CarregarMetas()
    {
        Console.Clear();
        Console.Write("Digite o nome do arquivo para carregar (ex: metas.txt): ");
        string nomeArquivo = Console.ReadLine();

        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            if (linhas.Length > 0)
            {
                _pontos = int.Parse(linhas[0]);
                _metas.Clear();

                for (int i = 1; i < linhas.Length; i++)
                {
                    string[] partes = linhas[i].Split('|');
                    string tipo = partes[0];

                    if (tipo == "MetaSimples")
                    {
                        _metas.Add(new MetaSimples(partes[1], partes[2], partes[3], bool.Parse(partes[4])));
                    }
                    else if (tipo == "MetaEterna")
                    {
                        _metas.Add(new MetaEterna(partes[1], partes[2], partes[3]));
                    }
                    else if (tipo == "MetaDeListaDeTarefas")
                    {
                        _metas.Add(new MetaDeListaDeTarefas(partes[1], partes[2], partes[3], 
                            int.Parse(partes[4]), int.Parse(partes[5]), int.Parse(partes[6])));
                    }
                }
            }
            Console.WriteLine("\nMetas e pontos carregados com sucesso! Pressione qualquer tecla para continuar.");
        }
        else
        {
            Console.WriteLine("\nArquivo não encontrado.");
        }
        Console.ReadKey();
    }
}