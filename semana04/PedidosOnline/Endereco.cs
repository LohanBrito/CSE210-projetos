using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Endereco
{
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;

    public Endereco (string rua, string cidade, string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    public bool moraNosEUA()
    {
        return _pais ==  "EUA";
        
    }

    public string ObterEnderecoCompleto()
    {
        return $"{_rua} - {_cidade}, {_estado} - {_pais}";
    }


}



