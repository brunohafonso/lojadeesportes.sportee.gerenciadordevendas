using System;
using System.IO;
using System.Text;
using DOMINIO.ClassePai;

namespace DOMINIO.ClasseFilha
{
    public class Vestuario : Produto, IAcao
    {
        private string Tamanho { get; set; }
        private string Cor { get; set; }

        public Vestuario()
        {            

        }

        public Vestuario(int id, string Nome, string Descricao, double Preco, string Tamanho , string Cor)
        {
            base.Id = Id;
            base.Nome = Nome;
            base.Descricao = Descricao;
            base.Preco = Preco;
            this.Tamanho = Tamanho;
            this.Cor = Cor;            
        }

        public bool Cadastrar()
        {
            bool cadastrado;
            StreamWriter arquivo = null;

            try
            {
                arquivo = new StreamWriter(@"..\REPOSITORIO\Vestuario.csv", true);
                arquivo.WriteLine(Id + ";" + Nome + ";" + Descricao + ";" + Preco + ";" + Tamanho + ";" + Cor);
            }
            catch (Exception ex){
                throw new Exception("Erro ao tentar gravar o arquivo." + ex.Message);
                cadastrado = false;
            }
            finally
            {
                arquivo.Close();
                cadastrado = true;
            }
            return cadastrado;
        }

        public string Consultar()
        {
            string resultado = "";
            StreamReader ler = null;

            try
            {
                ler = new StreamReader(@"..\REPOSITORIO\Vestuario.csv", Encoding.Default);
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