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
<<<<<<< HEAD
            string[] linhas = File.ReadAllLines(@"..\REPOSITORIO\Fornecedores.csv");
            foreach(var linha in linhas ) {
                System.Console.WriteLine(linha.Replace(";", " "));
            }
            return "";
=======
            throw new System.NotImplementedException();
>>>>>>> fc75cde79472d957928bf1dc2e4bd6ef30ec1ced
        }
    }
}