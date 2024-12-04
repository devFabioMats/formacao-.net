using System;

namespace Condicoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("É maior de idade");
            }
            else
            {
                Console.WriteLine("É menor de idade");
            }
        }
    }
}
