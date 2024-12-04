/*
 * Enunciado: Crie um algoritmo que lê o nome de uma pessoa e escreve "Olá" segido do nome da pessoa.
*/

using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá, " + nome);
        }
    }
}
