/*
 * Enunciado: Receber os lados do triangulo e dizer se eles são equiláteros, isósceles ou escaleno.
*/

using System;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l1 = 0,
                l2 = 0,
                l3 = 0;

            Console.WriteLine("Digite o medida do lado 1 do triângulo: ");
            l1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o medida do lado 2 do triângulo: ");
            l2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o medida do lado 3 do triângulo: ");
            l3 = int.Parse(Console.ReadLine());

            if (l1 == l2 && l1 == l3 && l2 == l3)
            {
                Console.WriteLine("O triângulo é equilátero!");
            }
            else if (l1 == l2 || l1 == l3 || l2 == l3)
            {
                Console.WriteLine("O triângulo é isósceles!");
            }
            else
            {
                Console.WriteLine("O triângulo é escaleno!");
            }
        }
    }
}
