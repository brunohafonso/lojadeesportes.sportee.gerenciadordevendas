
using DOMINIO.ClassePai;

namespace DOMINIO.ClasseFilha
{
    public class PessoaFisica : Pessoa,IAcao
    {
        private  string Nome { get; set; }
        private string CPF { get; set; }

        public PessoaFisica()
        {
            
        }

        public PessoaFisica(string Nome, string CPF, Endereco endereco, string Email, string Telefone)
        {
           this.Nome = Nome;
           this.CPF =   CPF;
           base.Endereco = Endereco;
           base.Email = Email;
           base.Telefone = Telefone; 
        }

        public string Cadastrar() 
        {
            return null;
        }

        public string Consultar()
        {
            return null;
        }
    }
}