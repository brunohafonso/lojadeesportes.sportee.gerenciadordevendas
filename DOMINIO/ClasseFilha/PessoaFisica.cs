using Pessoa;

namespace DOMINIO.ClassePai.ClasseFilha
{
    public class PessoaFisica : Pessoa
    {
        private string Nome { get; set; }
        private string CPF { get; set; }

        public PessoaFisica(string Telefone)
        {
            base.Telefone = Telefone;
        }
        
    }
}