
using DOMINIO.ClassePai;

namespace DOMINIO.ClasseFilha
{
    public class PessoaJuridica : Pessoa,IAcao
    {
        protected string RazaoSocial { get; set; }

        protected string CNPJ { get; set; }

        public PessoaJuridica()
        {
            
        }

        public PessoaJuridica(string RazaoSocial, string CNPJ, Endereco Endereco, string Email, string Telefone)
        {
          this.RazaoSocial = RazaoSocial;
          this.CNPJ = CNPJ;
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