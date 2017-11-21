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
                    Telas.CadastrarProduto();
                    break;
                case "3":
                    //CadastarFornecedor ();
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
    }
}
