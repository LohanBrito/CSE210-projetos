using System;

class Program
{
    //Acrescentado o Concole.Clear() para deixar mais organizada a tela.
    //Criada uma lista de Escrituras pré-definidas que irão puxar aleatoriamente.
    static void Main(string[] args)
    {
       List<Escritura> bancoDeEscrituras = new List<Escritura>
       {
           new Escritura(
            new Referencia("Provérbios", 3, 5),
            "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento."
           ),

           new Escritura(
            new Referencia("João", 3, 16),
            "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna."
           ),
           new Escritura(
            new Referencia("1 Néfi", 3, 7),
            "E aconteceu que eu, Néfi, disse a meu pai: Eu irei e farei as coisas que o Senhor ordenou."
           ),

            new Escritura(
             new Referencia("D&C", 82, 10),
             "Eu, o Senhor, estou obrigado quando fazeis o que eu digo; mas quando não o fazeis, não tendes promessa alguma."
            ),

       };

       Random random = new Random();
       int sorteio = random.Next(bancoDeEscrituras.Count);
       Escritura escritura = bancoDeEscrituras[sorteio];

       string mensagemErro = " ";


        while (true)
        {
            Console.Clear();

            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine();
            Console.WriteLine("Pressione [ENTER] para ocultar palavras ou digite 'sair' para encerrar:");

            if (escritura.EstaCompletamenteOculta())
            {
                break;
            }

            string entrada = Console.ReadLine();

            if (entrada.Trim().ToLower() == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(2);

        }
             
        
        Console.Clear();
        Console.WriteLine("Programa Encerrado. Te aguardo para a próxima!");
    }
}