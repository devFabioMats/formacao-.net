// Façça um programa que peça ao utilizador para introduzir três notas e calcule a média das notas.

using System;

namespace Ficha1_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0,
                   media = 0;
            double[] notas = new double[3];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Digite a " + (i + 1) + "º nota: ");
                notas[i] = double.Parse(Console.ReadLine());

                soma = soma + notas[i];
            }

            media = soma / notas.Length;

            Console.WriteLine("A média das notas é: " + media);
        }
    }
}
