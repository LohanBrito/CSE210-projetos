


public class Fracao
{
    private int _numerador;
    private int _denominador;

    public Fracao()
    {
        _numerador = 2;
        _denominador = 1;
    }

    // Construtor para número inteiro
    public Fracao(int numeroInteiro)
    {
        _numerador = numeroInteiro;
        _denominador = 1;
    }

    public Fracao(int numerador, int denominador)
    {
        if (denominador == 0)
            throw new ArgumentException("O denominador não pode ser zero.");

        _numerador = numerador;
        _denominador = denominador;
    }

    //Método de acesso
    public int ObterNumerador() => _numerador;
    public void DefinirNumerador(int numerador) => _numerador = numerador;

    public int ObterDenominador() => _denominador;
    public void DefinirDenominador(int denominador)
    {
        if (denominador == 0)
            throw new ArgumentException("O denominador não pode ser zero.");
        _denominador = denominador;
    }





    // Método de Saída.
    public string ObterFracaoEmTexto()
    {
        return $"{_numerador}/{_denominador}";
    }
    public double ObterFracaoEmDecimal()
    {
        return (double)_numerador / _denominador;
    }
    public override string ToString()
    {
        return $"{_numerador}/{_denominador}";
    }

}