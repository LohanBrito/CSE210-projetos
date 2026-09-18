using System;

class Program
{
    //Acrescentado o Concole.Clear() para deixar mais organizada a tela.
    static void Main(string[] args)
    {
        Referencia referencia = new Referencia("Provérbios", 3, 5, 6);

        string textoEscritura = "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento.";
        
        Escritura escritura = new Escritura(referencia, textoEscritura);

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

            escritura.OcultarPalavrasAleatorias(1);

        }
             
        
        Console.Clear();
        Console.WriteLine("Programa Encerrado. Te aguardo para a próxima!");
    }
}