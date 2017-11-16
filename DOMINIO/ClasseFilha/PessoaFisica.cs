namespace DOMINIO.ClassePai.ClasseFilha
{
    public class PessoaFisica : Pessoa
    {
        private string Nome { get; set; }
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
    }
}