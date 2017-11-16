namespace DOMINIO.ClassePai.ClasseFilha
{
    public class PessoaJuridica : Pessoa
    {
        private string RazaoSocial { get; set; }

        private string CNPJ { get; set; }

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
    }
}