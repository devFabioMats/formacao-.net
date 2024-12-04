/*
 * Enunciado: receber quatro valores e retornar o menor
*/

using System;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0,
                valor2 = 0,
                valor3 = 0,
                valor4 = 0;

            Console.WriteLine("Valor 1: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor 2: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor 3: ");
            valor3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor 4: ");
            valor4 = int.Parse(Console.ReadLine());

            if (valor1 < valor2 && valor1 < valor3 && valor1 < valor4)
            {
                Console.WriteLine("O menor valor é: " + valor1);
            }
            else if (valor2 < valor1 && valor2 < valor3 && valor2 < valor4)
            {
                Console.WriteLine("O menor valor é: " + valor2);
            }
            else if (valor3 < valor1 && valor3 < valor2 && valor3 < valor4)
            {
                Console.WriteLine("O menor valor é: " + valor3);
            }
            else
            {
                Console.WriteLine("O menor valor é: " + valor4);
            }
        }
    }
}
