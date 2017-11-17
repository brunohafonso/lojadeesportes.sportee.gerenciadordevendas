using System;
using UTIL;

namespace PROJETO_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
           Validacao validacao = new Validacao();
           System.Console.WriteLine(validacao.validar_cnpj("01836583000158"));
           System.Console.WriteLine(validacao.validar_cpf("44063076806"));
           System.Console.WriteLine(validacao.validar_email("brunohafonso@gmail.com"));
           System.Console.WriteLine(validacao.validar_cep("04164-180"));
        }
    }
}
