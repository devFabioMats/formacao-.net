/*
 * Enunciado: Crie um algoritmo que após ler dois números inteiros, apresenta a sua soma.
*/

using System;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0,
                n2 = 0,
                soma = 0;


            Console.WriteLine("Informe o 1º número a ser somado :");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º número a ser somado: ");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("A soma dos número resulta em: " + soma);
        }
    }
}
