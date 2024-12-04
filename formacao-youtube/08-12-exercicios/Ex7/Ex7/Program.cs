/*
 * Enunciado: receber dois valores e retornar o maior
*/

using System;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0,
                valor2 = 0;

            Console.WriteLine("Valor 1: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor 2: ");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine("O maior valor é: " + valor1);
            }
            else
            {
                Console.WriteLine("O maior valor é: " + valor2);
            }
        }
    }
}
