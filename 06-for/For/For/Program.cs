using System;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira um número: ");
                int n = int.Parse(Console.ReadLine());

                soma = soma + n;
            }

            Console.WriteLine("A soma de todos os valores inseridos é: " + soma);
        }
    }
}
