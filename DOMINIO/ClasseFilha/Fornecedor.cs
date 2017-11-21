using DOMINIO.ClassePai;
using System.IO;

namespace DOMINIO.ClasseFilha

{
    public class Fornecedor : PessoaJuridica,IAcao
    {

           

        private string Produto;
        public Fornecedor()
        {
            
        }



        public Fornecedor(string RazaoSocial, string CNPJ, Endereco Endereco, string Email, string Telefone, string Produto)
        {

          base.RazaoSocial = RazaoSocial;
          base.CNPJ = CNPJ;
          base.Endereco = Endereco;
          base.Email = Email;
          base.Telefone = Telefone;
          this.Produto = Produto;

        }
    

        public bool Cadastrar()
        {

           StreamWriter SalvarFornecedor = new StreamWriter(@"..\REPOSITORIO\Fornecedores.csv",true);
           return false;
        }

        public string Consultar(string Path)
        {
            
        }
    }
}