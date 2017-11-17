namespace DOMINIO.ClassePai
{
    public class Produto
    {
        protected int Id { get; set; }
        protected string Nome { get; set; }
        protected string Descricao { get; set; }
        protected double Preco { get; set; }


         public virtual bool CadastrarProduto(){
            return false;
        }

         public virtual string ConsultarProduto(int Id){
             
            return null;
        }

        
    }

   

}