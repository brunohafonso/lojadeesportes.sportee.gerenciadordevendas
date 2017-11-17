using System;

namespace DOMINIO.ClassePai
{
    public abstract class Pessoa
    {
        protected Endereco Endereco { get; set; }

        protected string Email { get; set; }
        
        protected string Telefone { get; set; }
        protected string Tipo { get; set; }
    }
}
