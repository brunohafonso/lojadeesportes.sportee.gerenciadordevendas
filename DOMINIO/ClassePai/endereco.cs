using System;

namespace DOMINIO
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        
        public string Numero { get; set; }

        public string Complemento { get; set; }
        
        public string Cep { get; set; }

        public Endereco()
        {
            
        }

        public Endereco(string Logradouro, string Numero, string Complemento, string Cep)
        {
            this.Logradouro =  Logradouro;
            this.Numero =  Numero;
            this.Complemento =  Complemento;
            this.Cep = Cep;
        }
    }
}