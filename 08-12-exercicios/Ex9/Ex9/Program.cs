/*
 * Enunciado: Verifique se o numero é impar
*/

using System;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("Digite um número para verificar se ele é impar: ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("O número " + n + " é par.");
            }
            else
            {
                Console.WriteLine("O número " + n + " é ímpar.");
            }
        }
    }
}
