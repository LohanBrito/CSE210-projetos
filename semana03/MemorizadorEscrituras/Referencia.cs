

public class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculo;
    private int _ultimoVersiculo;

    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _ultimoVersiculo = 0;
    }

    public Referencia(string livro, int capitulo, int primeiroVersiculo, int ultimoVersiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = primeiroVersiculo;
        _ultimoVersiculo = ultimoVersiculo;
    }

    // Método acrescido de um "IF" para verificar qual condição puxar ao obter o texto
    public string ObterTexto()
    {
        if (_ultimoVersiculo == 0)
        {
            return $"{_livro} {_capitulo}:{_versiculo}";
        }
        
        return $"{_livro} {_capitulo}:{_versiculo}-{_ultimoVersiculo}";
    }







}
