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
              
          bool Resposta=false;
           try
           {
           StreamWriter SalvarFornecedor = new StreamWriter(@"..\REPOSITORIO\Fornecedores.csv",true);
           SalvarFornecedor.Write(RazaoSocial+";");
           SalvarFornecedor.Write(CNPJ+";");
           SalvarFornecedor.Write(Endereco+";");
           SalvarFornecedor.Write(Email+";");
           SalvarFornecedor.Write(Telefone+";");
           SalvarFornecedor.WriteLine(Produto+";");
           SalvarFornecedor.Close();
           Resposta=true;

           }
           catch
           {
          
           System.Console.WriteLine("Ocorreu um erro ao tentar Salvar!");

           }

           return Resposta;
        }

        public string Consultar()
        {
            throw new System.NotImplementedException();
        }
    }
}