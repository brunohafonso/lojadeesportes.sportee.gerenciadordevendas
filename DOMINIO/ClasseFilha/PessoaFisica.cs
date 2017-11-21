
using DOMINIO.ClassePai;
using System.IO;

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




        public bool Cadastrar()
        {
            

           bool Cadastro=false;
            StreamWriter SalvaClientes=new StreamWriter(@"..\REPOSITORIO\PessoaFisica.csv",true);
            try
            {
              SalvaClientes.Write(Nome+";");
              SalvaClientes.Write(CPF+";");
              SalvaClientes.Write(Endereco+";");
              SalvaClientes.Write(Email+";");
              SalvaClientes.WriteLine(Telefone+";");
              SalvaClientes.Close();
              Cadastro=true;
            }
            catch
            {

            System.Console.WriteLine("Ocorreu um erro ao Salvar os arquivos");

            }
           return Cadastro;
        }

        public string Consultar()
        {
            throw new System.NotImplementedException();
        }
    }
}