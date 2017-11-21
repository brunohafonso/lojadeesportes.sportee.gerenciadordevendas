using System;
using DOMINIO.ClassePai;
using DOMINIO.ClasseFilha;

namespace PROJETO_CONSOLE {
    class Program {
        
        static void Main (string[] args) 
        {
            MenuPrincipal();            
        }

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
                Console.WriteLine ("    5 - Gerar Histórico");
                Console.WriteLine ("    9 - Sair");
                Console.WriteLine ();
                Linha();
                //Recebe opção do Cliente
                Console.WriteLine ();
                Console.Write ("Opção: ");
                opcao = Console.ReadLine ();

            switch (opcao) {
                case "1":
                    //CadastrarCliente();
                    break;
                case "2":
                    //Console.Clear();
                    CadastrarProduto();
                    break;
                case "3":
                    Telas.CadastrarFonercedor();
                    break;
                case "4":
                    //ConsultarCadastro ();
                    break;
                case "5":
                    //GerarHistorico ();
                    break;
                case "9":
                    Environment.Exit(1);
                break;
                default:
                    MenuPrincipal();
                break;
            }
        }
        
        public  static void CadastrarProduto()
        {
            string opcao = "";
            //Laço de controle de opção de escolha de produto
            //Digitando a opção 3 retorna ao menu anterior
                Linha();
                Console.WriteLine();
                Console.WriteLine("    Informe a Categoria do Produto para cadastro: ");
                Console.WriteLine();
                Console.WriteLine("    1 - Vestuario ");
                Console.WriteLine("    2 - Material Esportivo ");
                Console.WriteLine("    3 - Voltar ");
                Console.WriteLine();
                Linha();
                Console.WriteLine();
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao) 
                {
                    case "1": 
                        Console.WriteLine("Cadastro de Vestuário");
                        Console.WriteLine();
                        Console.Write("Informe o Código: ");
                        try {
                            int Id = int.Parse(Console.ReadLine());
                        } catch {
                            Console.Write("Informe o Codigo novamente, codigo invalido: ");
                            Id = int.Parse(Console.ReadLine());
                        }
                        Console.Write("Informe o nome do produto: ");
                        string Nome = Console.ReadLine();
                        while(Nome.Length < 1) {
                            Console.Write("Informe o nome do novamente, nome invalido: ");
                            Nome = Console.ReadLine();
                        }

                        Console.Write("Informe a Descricao: ");
                        string Descricao = Console.ReadLine();
                        while(Descricao < 1) {
                            Console.Write("Informe a Descricao novamente: ");
                            Descricao = Console.ReadLine();
                        }

                        Console.Write("Informe o Preco: ");
                        try {
                            double Preco = double.Parse(Console.ReadLine());
                        } catch {
                            Console.Write("Informe o Preco novamente: ");
                            Preco = double.Parse(Console.ReadLine());
                        }

                        Console.Write("Informe o Tamanho: ");
                        string Tamanho = Console.ReadLine();
                        while(Tamanho.Length < 1) {
                            Console.Write("Informe o Tamanho novamente: ");
                            Tamanho = Console.ReadLine();
                        }

                        Console.Write("Informe a Cor: ");
                        string Cor = Console.ReadLine();
                        while(Cor.Length < 1) {
                            Console.Write("Informe a Cor novamente: ");
                            Cor = Console.ReadLine();
                        }

                        Vestuario vestuario = new Vestuario(Id, Nome, Descricao, String.Format({0:C2} ,Preco), Tamanho , Cor); 
                        bool verificador = vestuario.Cadastrar();
                        if(verificador) {
                            System.Console.WriteLine("Produto cadastrado com sucesso.");
                            linha();
                        } else {
                            System.Console.WriteLine("erro ao cadastrar produto.");
                            CadastrarProduto();
                        }
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
                        MenuPrincipal();
                    break;
                    default:
                      CadastrarProduto();
                    break;
                }
        }
    }
}
