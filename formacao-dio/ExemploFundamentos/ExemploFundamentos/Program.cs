using ExemploFundamentos.Models;

namespace ExemploFundamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Fabio";
            pessoa1.Idade = 21;
            pessoa1.Apresentar();
        }
    }
}
