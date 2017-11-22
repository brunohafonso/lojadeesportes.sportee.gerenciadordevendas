
using System;
using System.IO;
using DOMINIO.ClassePai;
using DOMINIO.ClasseFilha;

namespace PROJETO_CONSOLE

{
    public class Telas
    {

        public static void Linha()
        {
            Console.Write("======================================================");
        }






          public static void MenuPrincipal() 
        {
            string opcao = "";
                Linha();
                Console.WriteLine ();
                Console.WriteLine ();
                Console.WriteLine ("    SISTEMA SPORTEE     ");
                Console.WriteLine ();
                Console.WriteLine ("    Digite a opção:");
                Console.WriteLine ();
                Console.WriteLine ("    1 - Cadastrar Cliente");
                Console.WriteLine ("    2 - Cadastrar Produto");
                Console.WriteLine ("    3 - Cadastrar Fornecedor");
                Console.WriteLine ("    4 - Consultar Cadastro");
                Console.WriteLine ("    5 - Venda");
                Console.WriteLine ("    9 - Sair");
                Console.WriteLine ();
                Linha();
                //Recebe opção do Cliente
                Console.WriteLine ();
                Console.Write ("Opção: ");
                opcao = Console.ReadLine ();

            switch (opcao) {
                case "1":
                   //Chama o método que solicita os dados do cliente e depois os salva
                    CadastrarCliente();
                  //Chama o método do menu principal
                    MenuPrincipal();
                    

                    break;
                case "2":
                //Chama o método que solicita os dados do produto e depois os salva
                    CadastrarProduto();
                    //Chama o método do menu principal
                    MenuPrincipal();

                    break;
                case "3":
                    
                    //Chama o método que solicita os dados do fornecedor e depois os salva
                    CadastrarFonercedor();
                   //Chama o método do menu principal
                    MenuPrincipal();
                    break;

                case "4":
                    //ConsultarCadastro ();
                    break;

                case "5":
                    RealizaVenda();
                    MenuPrincipal();
                    break;
                case "9":
                    Environment.Exit(1);
                break;
                default:
                    MenuPrincipal();
                break;
            }
        }

           


   public static void  RealizaVenda()
   {
         string opcao="";
         bool controla=false;
          Linha();
        int escolha=0;
          System.Console.WriteLine("\n  Vendas \n");
          Linha();

          System.Console.WriteLine("\n Escolha o Tipo de Produto");
          Console.WriteLine("  1 - Vestuario ");
            Console.WriteLine("2 - Material Esportivo ");
            Console.WriteLine("3 - Voltar ");
            

            Console.Write("Opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Vestuario vestuariovenda = new Vestuario();
                    vestuariovenda.Consultar();
                    while(controla=false)
                    {
                        try
                        {
                    System.Console.WriteLine("Escolha o Produto por ID:");
                    escolha=Int32.Parse(Console.ReadLine());
                    controla=true;
                        }
                        catch
                        {
                             System.Console.WriteLine("O sistema apenas aceita números"); 
                        }
                    }

                    break;
                case "2":
                    controla=false;

                    MaterialEsportivo esportivovenda = new MaterialEsportivo();
                    esportivovenda.Consultar();
                   
                    while(controla=false)
                    {
                        try
                        {
                         System.Console.WriteLine("Escolha o Produto por ID:");
                         escolha=Int32.Parse(Console.ReadLine());
                         controla=true;
                        }
                        catch
                        {
                             System.Console.WriteLine("O sistema apenas aceita números"); 
                        }
                    }

                    break;
                case "3":
                    MenuPrincipal();
                    break;
                default:
                    RealizaVenda();
                    break;
            }
           
          

   }



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
                    CadastrarMaterialEsportivo();
                    break;
                case "3":
                    MenuPrincipal();
                    break;
                default:
                    CadastrarProduto();
                    break;
            }
        }




public static void CadastrarMaterialEsportivo()
        {

          Linha();

          System.Console.WriteLine("\n Cadastro de Material Esportivo \n");
          Linha();
                    
                    string Nome="",Descricao="",Modalidade="";
                    double Preco=0;
                    bool controla=false;
                   
                   



                    //Nome
                    //fica no loop até o nome ser preenchido
                    while(Nome=="")
                    {
                    Console.Write("\nInforme o Nome:");
                      Nome = Console.ReadLine();
                    }

                    //Nome
                    //fica no loop até a descricao ser preenchida
                    while(Descricao=="")
                    {
                    Console.Write("Informe a Descrição: ");
                      Descricao = Console.ReadLine();
                    }
                    

                    // deixa a controla como false
                    controla=false;
                    //fica no loop até o valor ser inserido como numerico
                    while(controla==false) 
                    {
                        //tenta converter
                        try
                        {
                        Console.Write("Informe o Preço do Produto: ");
                        Preco = int.Parse(Console.ReadLine());
                        controla=true;
                        }
                        catch
                        {

                            System.Console.WriteLine("Favor Digite o preco corretamente. OBS o campo aceita apenas números!");
                        }
                    }


                    while(Modalidade=="")
                    {
                    Console.Write("Modalidade: ");
                    Modalidade = Console.ReadLine();
                    }

                    MaterialEsportivo MaterialAtual=new MaterialEsportivo(Nome,Descricao,Preco,Modalidade);
                    MaterialAtual.Cadastrar();
        }






            //Cadastro de vestuario
        public static void CadastrarVestuario()
        {

            int Id=0;
            string Descricao, Tamanho, Cor;
            double Preco=0;
            bool opcao=false;

            Console.WriteLine("Cadastro de Vestuário");
            Console.WriteLine();
            
           

           
          


             // SOLICITA O PRODUTO

            Console.Write("Informe o nome do produto: ");
            string Nome = Console.ReadLine();
            while (Nome.Length < 1)
            {
                Console.Write("Informe o nome do novamente, nome invalido: ");
                Nome = Console.ReadLine();
            }



           //SOLICITA A DESCRIÇÃO
            Console.Write("Informe a Descricao: ");
            Descricao = Console.ReadLine();
            while (Descricao.Length < 1)
            {
                Console.Write("Informe a Descricao novamente: ");
                Descricao = Console.ReadLine();
            }



            //SOLICITA O PREÇO
            Console.Write("Informe o Preco: ");
            opcao=false;
             // SE O PRECO NAO FOR IGUAL A DOUBLE FICA NO LAÇO
            while(opcao==false)
            {
            try
            {
                Preco = double.Parse(Console.ReadLine());
                opcao=true;
            }
            catch
            {
                Console.Write("Informe o Preco novamente: ");
               
            }
            }



           //SOLICITA O TAMANHO
            Console.Write("Informe o Tamanho: ");
            Tamanho = Console.ReadLine();
            while (Tamanho.Length < 1)
            {
                Console.Write("Informe o Tamanho novamente: ");
                Tamanho = Console.ReadLine();
            }



            //SOLICITA A COR
            Console.Write("Informe a Cor: ");
            Cor = Console.ReadLine();
            while (Cor.Length < 1)
            {
                Console.Write("Informe a Cor novamente: ");
                Cor = Console.ReadLine();
            }


         // CRIA E INSTANCIA O OBJETI vesturario
            Vestuario vestuario = new Vestuario(Nome, Descricao, Preco, Tamanho, Cor);
            //Salva o Vestuario
            bool verificador = vestuario.Cadastrar();
            vestuario.Consultar();

            if (verificador)
            {
                System.Console.WriteLine("Produto cadastrado com sucesso.");

            }
            else
            {
                System.Console.WriteLine("erro ao cadastrar produto.");
            }
            
            vestuario.Consultar();
        }
           




           
           //CADASTRO DE FORNECEDORES
        public static void CadastrarFonercedor()
        {


            string RazaoSocial ="", Email ="", Produto ="", Telefone ="", CNPJ ="";
            Endereco FornecedorEnd = new Endereco();

            System.Console.WriteLine("**  CADASTRO DE FORNECEDOR **\n");


            //RAZÃO SOCIAL
            while (RazaoSocial == "")
            {

                System.Console.WriteLine("Favor digite a Razão Social do Fornecedor");
                RazaoSocial = Console.ReadLine();

            }


            //CNPJ
            while (CNPJ == "")
            {
                System.Console.WriteLine("Favor digite o CNPJ do Fornecedor");
                CNPJ = Console.ReadLine();
            }


            //LOGRADOURO
            while (FornecedorEnd.Logradouro == "")
            {
                System.Console.WriteLine("Favor digite o Logradouro do Fornecedor");
                FornecedorEnd.Logradouro = Console.ReadLine();
            }


            //NUMERO
            while (FornecedorEnd.Numero == "")
            {
                System.Console.WriteLine("Favor digite o Número do Logradouro");
                FornecedorEnd.Numero = Console.ReadLine();

            }


            //Complemento
            while (FornecedorEnd.Complemento == "")
            {
                System.Console.WriteLine("Favor digite o Complemento do Logradouro");
                FornecedorEnd.Complemento = Console.ReadLine();
            }


            //Cep
            while (FornecedorEnd.Cep == "")
            {
                System.Console.WriteLine("Favor digite o CEP do Logradouro");
                FornecedorEnd.Cep = Console.ReadLine();
            }

            //EMAIL
            while (Email == "")
            {
                System.Console.WriteLine("Favor digite o Email do Fornecedor");
                Email = Console.ReadLine();
            }

            //PRODUTO
            while (Produto == "")
            {
                System.Console.WriteLine("Favor digite o Produto do Fornecedor");
                Produto = Console.ReadLine();
            }

            //TELEFONE
            while (Telefone == "")
            {
                System.Console.WriteLine("Favor digite o Telefone do Fornecedor");
                Telefone = Console.ReadLine();
            }

            Fornecedor FornecedorAtual = new Fornecedor(RazaoSocial, CNPJ, FornecedorEnd, Email, Telefone, Produto);
            FornecedorAtual.Cadastrar();
            FornecedorAtual.Consultar();
        }



        public static void CadastrarCliente()
        {


            string Nome= "", CPF = "", Email = "", Telefone = "";
            Endereco ClienteEnd = new Endereco();

            
            System.Console.WriteLine("\n  CADASTRO DE Cliente \n");
            Linha();

            //Nome do cliente
            while (Nome == "")
            {

                System.Console.WriteLine("\nFavor digite o nome do cliente");
                Nome = Console.ReadLine();

            }


            //CPF do cliente
            while (CPF == "")
            {
                System.Console.WriteLine("Favor digite o CPF do cliente");
                CPF = Console.ReadLine();
            }


            //Logradouro do cliente
            while (ClienteEnd.Logradouro == "")
            {
                System.Console.WriteLine("Favor digite o Logradouro do cliente");
                ClienteEnd.Logradouro = Console.ReadLine();
            }


            //NUMERO
            while (ClienteEnd.Numero == "")
            {
                System.Console.WriteLine("Favor digite o Número do cliente");
                ClienteEnd.Numero = Console.ReadLine();

            }


            //Complemento
            while (ClienteEnd.Complemento == "")
            {
                System.Console.WriteLine("Favor digite o Complemento do cliente");
                ClienteEnd.Complemento = Console.ReadLine();
            }


            //Cep
            while (ClienteEnd.Cep == "")
            {
                System.Console.WriteLine("Favor digite o cep do cliente");
                ClienteEnd.Cep = Console.ReadLine();
            }

            //EMAIL
            while (Email == "")
            {
                System.Console.WriteLine("Favor digite o Email do cliente");
                Email = Console.ReadLine();
            }

        

            //TELEFONE
            while (Telefone == "")
            {
                System.Console.WriteLine("Favor digite o Telefone do cliente");
                Telefone = Console.ReadLine();
            }

             PessoaFisica PessoaAtual = new PessoaFisica(Nome, CPF, ClienteEnd, Email, Telefone);
             PessoaAtual.Cadastrar();
             PessoaAtual.Consultar();
             
        }
    }
}