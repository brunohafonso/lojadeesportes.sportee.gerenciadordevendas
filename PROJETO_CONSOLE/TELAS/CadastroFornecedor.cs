using System;
using DOMINIO.ClasseFilha;
using DOMINIO.ClassePai;

namespace PROJETO_CONSOLE {
    public class CadastroFornecedor{
      
    public static void CadastroFornecedorConsole()
    {


       
        string RazaoSocial;
        string CNPJ;
        string Logradouro;
        string Numero;
        string Complemento;
        string Cep;
        string Email;
        string Telefone;
        string Produto;


        CadastroProduto.Linha(); 

        System.Console.WriteLine("   Favor digite o a sua  Razão Social: ");
        RazaoSocial=Console.ReadLine();

        System.Console.WriteLine("   Favor digite o seu CNPJ: ");
        CNPJ=Console.ReadLine();

        System.Console.WriteLine("   Favor digite o seu Logradouro:  ");
        Logradouro=Console.ReadLine();

        System.Console.WriteLine("Favor digite o seu Numero:");
        Numero=Console.ReadLine();

        System.Console.WriteLine("Favor digite o seu Complemento:");
        Complemento=Console.ReadLine();

        System.Console.WriteLine("Favor digite o seu CEP:");
        Cep=Console.ReadLine();

        System.Console.WriteLine("Favor digite o seu E-mail:");
        Email=Console.ReadLine();


        System.Console.WriteLine("Favor digite o seu Telefone:");
        Telefone=Console.ReadLine();

        System.Console.WriteLine("Favor digite o produto a ser Fornecido:");
        Produto=Console.ReadLine();

       

        CadastroProduto.Linha(); 

        Endereco EnderecoAtual=new Endereco(Logradouro,Numero,Complemento,Cep);
        Fornecedor PessoaAtual=new Fornecedor(RazaoSocial,CNPJ,EnderecoAtual,Email,Telefone,Produto);





   }

    }
}