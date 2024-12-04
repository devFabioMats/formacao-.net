/*
 * Enunciado: Calcular preço pelo valor do quilo e a quantidade de quilos
*/

using System;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorQuilo = 0,
                  quantidadeProduto = 0,
                  valorFinal = 0;

            Console.WriteLine("Informe o valor do quilo do produto: ");
            valorQuilo = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de produto: ");
            quantidadeProduto = float.Parse(Console.ReadLine());

            valorFinal = valorQuilo * quantidadeProduto;

            Console.WriteLine("O valor final será de R$ " + valorFinal.ToString("F2"));
        }
    }
}
