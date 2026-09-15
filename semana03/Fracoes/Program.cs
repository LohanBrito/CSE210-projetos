using System;

class Program
{
    static void Main(string[] args)
    {
        //Fração padrão:
        Fracao f1 = new Fracao();
        Console.WriteLine(f1);
        Console.WriteLine(f1.ObterFracaoEmDecimal());
        Console.WriteLine(f1.ObterFracaoEmTexto());

        //Métodos de acesso:
        Console.WriteLine("Numerador atual: " + f1.ObterNumerador());
        Console.WriteLine("Denominador atual: " + f1.ObterDenominador());

        //Alterando valor com Setters:
        f1.DefinirNumerador(3);
        f1.DefinirDenominador(4);

        Console.WriteLine("Fração modificada: " + f1);
        Console.WriteLine("Valor decimal: " + f1.ObterFracaoEmDecimal());

    }
}