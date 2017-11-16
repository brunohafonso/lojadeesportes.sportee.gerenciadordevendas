using System;

namespace PROJETO_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string opcao = "";
            do{
                Console.Clear();
                Console.WriteLine("==========================");
                Console.WriteLine("    SISTEMA SPORTEE     ");
                Console.WriteLine();
                Console.WriteLine("    Digite a opção:");
                Console.WriteLine();
                Console.WriteLine("    1 - Cadastrar Cliente");
                Console.WriteLine("    2 - Cadastrar Produto");
                Console.WriteLine("    3 - Cadastrar Fornecedor");
                Console.WriteLine("    4 - Consultar Cadastro");
                Console.WriteLine("    5 - Gerar Histórico");
                Console.WriteLine("    9 - Sair");
                Console.WriteLine();
                Console.WriteLine("===========================");
                
                //Recebe opção do Cliente
                Console.WriteLine();
                Console.Write("Opção: ");
                opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        //Cadastrar cliente
                        break;
                    case "2":
                        Console.Clear();
                        //Cadastrar produto
                        break;
                    case "3":
                        Console.Clear();
                        //Cadastrar fornecedor
                        break;
                    case "4":
                        Console.Clear();
                        //Consultar cadastro
                        break;
                    case "5":
                        Console.Clear();
                        //Gerar histórico
                        break;                
                    //default:
                }



        }while(opcao != "9");







        }
    }
}


