using System;

namespace PROJETO_CONSOLE
{
   public class CadastroProduto
    {
       
        static void Linha()
        {
            Console.Write("======================================================");
        }
        public  static void CadastrarProduto(){

            Console.Clear();
            Linha();
            Console.WriteLine();
            Console.WriteLine("    Informe a Categoria do Produto para cadastro: ");
            Console.WriteLine();
            Console.WriteLine("    1 - Vestuario ");
            Console.WriteLine("    2 - Material Esportivo ");
            Console.WriteLine();
            Linha();
            Console.WriteLine();
            Console.Write("Opção: ");
            string opcao = Console.ReadLine();
            //laço recursivo, caso seja digitada uma opcao diferente de 1 ou 2, o funcao chama ela propria novamente
            while(opcao != "1" && opcao != "2") {
                CadastrarProduto();
            }
            if (opcao == "1")
            {
                Console.Clear();
                Console.WriteLine("Casdatro de Vestuário");
                Console.WriteLine();
                Console.Write("Informe o Código: ");
                int Id = int.Parse(Console.ReadLine());

                Console.Write("Informe o Nome: ");
                string Nome = Console.ReadLine();

                Console.Write("Informe a Descrição: ");
                string Descricao = Console.ReadLine();

                Console.Write("Informe o Preço: ");
                double Preco = double.Parse(Console.ReadLine());

                Console.Write("Informe o Tamanho: ");
                string Tamanho = Console.ReadLine();

                Console.Write("Informe a Cor: ");
                string Cor = Console.ReadLine();

            }else
            
            {
                Console.Clear();
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

                 
            }
    }
  }
}