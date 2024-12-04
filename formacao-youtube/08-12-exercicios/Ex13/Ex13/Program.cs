/*
 * Enunciado: faça um programa que leia 50 numeros e calcule a sua média aritmetica
*/

using System;

namespace Ex13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numero = 0,
                soma = 0,
                media = 0;

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Digite o " + i + "º número: ");
                numero = int.Parse(Console.ReadLine());

                soma = soma + numero;
            }

            media = soma / 50;

            Console.WriteLine("A média dos 50 números é: " + media);
        }
    }
}