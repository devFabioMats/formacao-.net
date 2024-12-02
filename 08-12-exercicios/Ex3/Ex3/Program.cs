/*
 * Enunciado: Crie um algoritmo que após ler dois números inteiros, apresenta a sua diferença.
*/

using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0,
                n2 = 0,
                dif = 0;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            dif = n1 - n2;

            Console.WriteLine("A diferença entre os números é: " + dif);



        }
    }
}
