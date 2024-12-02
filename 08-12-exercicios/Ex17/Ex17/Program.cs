/*Enunciado: Dado uma série de 20 valores inteiros, faça um
 * algorítmo que calcule a média destes valores.
*/

using System;

namespace Ex17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] valores = new int[20];
            int soma = 0;

            Console.WriteLine("Digite 20 valores inteiros:");

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Valor {i + 1}: ");
                valores[i] = int.Parse(Console.ReadLine());
                soma += valores[i];
            }

            double media = (double)soma / valores.Length;
            Console.WriteLine($"A média dos valores é: {media}");
        }
    }
}