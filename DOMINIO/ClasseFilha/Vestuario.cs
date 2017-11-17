using System;
using System.IO;
using System.Text;

namespace DOMINIO.ClassePai.ClasseFilha
{
    public class Vestuario : Produto
    {
        private string Tamanho { get; set; }
        private string Cor { get; set; }


        public Vestuario(){            

        }

        public Vestuario(int id, string Nome, string Descricao, double Preco, string Tamanho , string Cor){
            base.Id = Id;
            base.Nome = Nome;
            base.Descricao = Descricao;
            base.Preco = Preco;
            this.Tamanho = Tamanho;
            this.Cor = Cor;            
        }

         public override bool CadastrarProduto() 
        {
            bool cadastrado = false;
            StreamWriter arquivo = null;

            try
            {
                arquivo = new StreamWriter("vestuario.csv", true);
                arquivo.WriteLine(Id + ";" + Nome + ";" + Descricao + ";" + Preco + ";" + Tamanho + ";" + Cor);
                cadastrado = true;
            }
            catch (Exception ex){
                throw new Exception("Erro ao tentar gravar o arquivo." + ex.Message);
            }
            finally
            {
                arquivo.Close();
            }

            return cadastrado;
            
        }

        public override string ConsultarProduto(int Id)
        {
            string resultado = "";
            StreamReader ler = null;

            try
            {
                ler = new StreamReader("vestuario.csv", Encoding.Default);
                string linha = "";
                while((linha = ler.ReadLine()) != null){
                    string[] dados = linha.Split(';');
                    if(dados[0] == Convert.ToString(Id)){
                        resultado = linha;
                        break;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                
                 resultado = "Erro ao tentar ler o arquivo." + ex.Message;
            }

             finally{
                ler.Close();
            }

            return resultado;
        }

    }
}