using System;
using System.IO;
using System.Text;

namespace DOMINIO.ClassePai.ClasseFilha
{
    public class MaterialEsportivo : Produto, IAcao
    {
        private string Modalidade { get; set; }

        public MaterialEsportivo(){            
        }


        public MaterialEsportivo(int id, string Nome, string Descricao, double Preco, string Modalidade){
            base.Id = Id;
            base.Nome = Nome;
            base.Descricao = Descricao;
            base.Preco = Preco;
            this.Modalidade = Modalidade;
        }

        public string Cadastrar()
        {
            string cadastrado;
            StreamWriter arquivo = null;

            try
            {
                arquivo = new StreamWriter(@"..\REPOSITORIO\material-esportivo.csv", true);
                arquivo.WriteLine(Id + ";" + Nome + ";" + Descricao + ";" + Preco + ";" + Modalidade);
                cadastrado = "cadastrado com sucesso";
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

        public string Consultar()
        {
            throw new NotImplementedException();
        }

        /*public override string ConsultarProduto(int Id)
        {
            string resultado = "";
            StreamReader ler = null;

            try
            {
                ler = new StreamReader(@"..\REPOSITORIO\material-esportivo.csv", Encoding.Default);
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

        public string Consultar()
        {
            throw new NotImplementedException();
        }
    }*/

    }
}