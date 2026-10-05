using System;

class Program
{
    static void Main(string[] args)
    {
        
        Quadrado quadrado = new Quadrado("Azul", 5);
        quadrado.ObterArea();

        Console.WriteLine($"A cor do Quadrado é: {quadrado.ObterCor()}");
        Console.WriteLine($"A áre do Quadrado é: {quadrado.ObterArea()}\n");
        
        Retangulo retangulo = new Retangulo("Amarelo", 10, 15);
        retangulo.ObterArea();

        Console.WriteLine($"A cor do Quadrado é: {retangulo.ObterCor()}");
        Console.WriteLine($"A áre do Quadrado é: {retangulo.ObterArea()}\n");

        
        Circulo circulo = new Circulo("Vermelho", 12);
        Console.WriteLine($"A cor do Quadrado é: {circulo.ObterCor()}");
        Console.WriteLine($"A áre do Quadrado é: {circulo.ObterArea()}\n");

        List<Figura> listaDeFiguras = new List<Figura>();
        listaDeFiguras.Add(new Quadrado("Azul", 5));
        listaDeFiguras.Add(new Retangulo("Amarelo", 10, 15));
        listaDeFiguras.Add(new Circulo("Vermelho", 12));

        foreach (Figura figura in listaDeFiguras)
        {
            Console.WriteLine($"Cor: {figura.ObterCor()} | Área: {figura.ObterArea()}");
        }
    }
}