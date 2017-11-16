using System;

namespace DOMINIO.ClassePai
{
    public abstract class Pessoa
    {
        protected string  Documento { get; set; }
        
        protected Endereco Endereco {get; set;}

        protected string Email { get; set; }
        
        protected string Telefone { get; set; }

    }
}
