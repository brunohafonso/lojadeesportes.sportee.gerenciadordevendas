using System;
using System.IO;
using DOMINIO.ClassePai;
using DOMINIO.ClasseFilha;

namespace PROJETO_CONSOLE

{
    public class Telas
    {

        public static void CadastrarProduto()
        {
            string opcao = "";
            //Laço de controle de opção de escolha de produto
            //Digitando a opção 3 retorna ao menu anterior

            Console.WriteLine();
            Console.WriteLine("    Informe a Categoria do Produto para cadastro: ");
            Console.WriteLine();
            Console.WriteLine("    1 - Vestuario ");
            Console.WriteLine("    2 - Material Esportivo ");
            Console.WriteLine("    3 - Voltar ");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarVestuario();


                    break;
                case "2":
                    Console.WriteLine("Cadastro de Material Esportivo");
                    Console.WriteLine();
                    Console.Write("Informe o Código: ");
                    int Id = int.Parse(Console.ReadLine());

                    Console.Write("Informe o Nome: ");
                    string Nome = Console.ReadLine();

                    Console.Write("Informe a Descrição: ");
                    string Descricao = Console.ReadLine();

                    Console.Write("Informe o Preço: ");
                    double Preco = double.Parse(Console.ReadLine());

                    Console.Write("Modalidade: ");
                    string Modalidade = Console.ReadLine();
                    break;
                case "3":

                    break;
                default:
                    CadastrarProduto();
                    break;
            }
        }
        public static void CadastrarVestuario()
        {

            int Id;
            string Descricao, Tamanho, Cor;
            double Preco;

            Console.WriteLine("Cadastro de Vestuário");
            Console.WriteLine();
            Console.Write("Informe o Código: ");
            try
            {
                Id = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Informe o Codigo novamente, codigo invalido: ");
                Id = int.Parse(Console.ReadLine());
            }
            Console.Write("Informe o nome do produto: ");
            string Nome = Console.ReadLine();
            while (Nome.Length < 1)
            {
                Console.Write("Informe o nome do novamente, nome invalido: ");
                Nome = Console.ReadLine();
            }

            Console.Write("Informe a Descricao: ");
            Descricao = Console.ReadLine();
            while (int.Parse(Descricao) < 1)
            {
                Console.Write("Informe a Descricao novamente: ");
                Descricao = Console.ReadLine();
            }

            Console.Write("Informe o Preco: ");
            try
            {
                Preco = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Informe o Preco novamente: ");
                Preco = double.Parse(Console.ReadLine());
            }

            Console.Write("Informe o Tamanho: ");
            Tamanho = Console.ReadLine();
            while (Tamanho.Length < 1)
            {
                Console.Write("Informe o Tamanho novamente: ");
                Tamanho = Console.ReadLine();
            }

            Console.Write("Informe a Cor: ");
            Cor = Console.ReadLine();
            while (Cor.Length < 1)
            {
                Console.Write("Informe a Cor novamente: ");
                Cor = Console.ReadLine();
            }

            Vestuario vestuario = new Vestuario(Id, Nome, Descricao, Preco, Tamanho, Cor);
            bool verificador = vestuario.Cadastrar();

            if (verificador)
            {
                System.Console.WriteLine("Produto cadastrado com sucesso.");

            }
            else
            {
                System.Console.WriteLine("erro ao cadastrar produto.");
            }
        }

        public static void CadastrarFonercedor()
        {


            string RazaoSocial = null, Email = null, Produto = null, Telefone = null, CNPJ = null;
            Endereco FornecedorEnd = new Endereco();

            System.Console.WriteLine("**  CADASTRO DE FORNECEDOR **\n");


            //RAZÃO SOCIAL
            while (RazaoSocial == null)
            {

                System.Console.WriteLine("Favor digite a Razão Social do Fornecedor");
                RazaoSocial = Console.ReadLine();

            }


            //CNPJ
            while (CNPJ == null)
            {
                System.Console.WriteLine("Favor digite o CNPJ do Fornecedor");
                CNPJ = Console.ReadLine();
            }


            //LOGRADOURO
            while (FornecedorEnd.Logradouro == null)
            {
                System.Console.WriteLine("Favor digite o Logradouro do Fornecedor");
                FornecedorEnd.Logradouro = Console.ReadLine();
            }


            //NUMERO
            while (FornecedorEnd.Numero == null)
            {
                System.Console.WriteLine("Favor digite o Número do Logradouro");
                FornecedorEnd.Numero = Console.ReadLine();

            }


            //Complemento
            while (FornecedorEnd.Complemento == null)
            {
                System.Console.WriteLine("Favor digite o Complemento do Logradouro");
                FornecedorEnd.Complemento = Console.ReadLine();
            }


            //Cep
            while (FornecedorEnd.Cep == null)
            {
                System.Console.WriteLine("Favor digite o Complemento do Logradouro");
                FornecedorEnd.Cep = Console.ReadLine();
            }

            //EMAIL
            while (Email == null)
            {
                System.Console.WriteLine("Favor digite o Email do Fornecedor");
                Email = Console.ReadLine();
            }

            //PRODUTO
            while (Produto == null)
            {
                System.Console.WriteLine("Favor digite o Produto do Fornecedor");
                Produto = Console.ReadLine();
            }

            //TELEFONE
            while (Telefone == null)
            {
                System.Console.WriteLine("Favor digite o Telefone do Fornecedor");
                Telefone = Console.ReadLine();
            }

            Fornecedor FornecedorAtual = new Fornecedor(RazaoSocial, CNPJ, FornecedorEnd, Email, Telefone, Produto);
            FornecedorAtual.Cadastrar();
        }



        public static void CadastrarCliente()
        {


            string Nome= null, CPF = null, Email = null, Telefone = null;
            Endereco ClienteEnd = new Endereco();

            System.Console.WriteLine("**  CADASTRO DE FORNECEDOR **\n");


            //RAZÃO SOCIAL
            while (Nome == null)
            {

                System.Console.WriteLine("Favor digite o nome do cliente");
                Nome = Console.ReadLine();

            }


            //CNPJ
            while (CPF == null)
            {
                System.Console.WriteLine("Favor digite o CPF do cliente");
                CPF = Console.ReadLine();
            }


            //LOGRADOURO
            while (ClienteEnd.Logradouro == null)
            {
                System.Console.WriteLine("Favor digite o Logradouro do cliente");
                ClienteEnd.Logradouro = Console.ReadLine();
            }


            //NUMERO
            while (ClienteEnd.Numero == null)
            {
                System.Console.WriteLine("Favor digite o Número do cliente");
                ClienteEnd.Numero = Console.ReadLine();

            }


            //Complemento
            while (ClienteEnd.Complemento == null)
            {
                System.Console.WriteLine("Favor digite o Complemento do cliente");
                ClienteEnd.Complemento = Console.ReadLine();
            }


            //Cep
            while (ClienteEnd.Cep == null)
            {
                System.Console.WriteLine("Favor digite o cep do cliente");
                ClienteEnd.Cep = Console.ReadLine();
            }

            //EMAIL
            while (Email == null)
            {
                System.Console.WriteLine("Favor digite o Email do cliente");
                Email = Console.ReadLine();
            }

        

            //TELEFONE
            while (Telefone == null)
            {
                System.Console.WriteLine("Favor digite o Telefone do Fornecedor");
                Telefone = Console.ReadLine();
            }

             PessoaFisica PessoaAtual = new PessoaFisica(Nome, CPF, ClienteEnd, Email, Telefone);
             PessoaAtual.Cadastrar();
             
        }
    }
}