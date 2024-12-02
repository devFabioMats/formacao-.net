/*
 * Enunciado: utilizar SE para fazer um programa que retorne o nome de um produto a partir do código do mesmo.
 * Considere o seguinte código:
 * a. 001 - Parafuso;
 * b. 002 - Porca;
 * c. 003 - Prego;
 * d. Para qualquer outro código indicar "Não definido".
*/

using System;

namespace Ex11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int codigo = 0;

            Console.WriteLine("Insira o código do produto: ");
            codigo = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                Console.WriteLine("001 - Parafuso");
            }
            else if (codigo == 2)
            {
                Console.WriteLine("002 - Porca");
            }
            else if (codigo == 3)
            {
                Console.WriteLine("003 - Prego");
            }
            else
            {
                Console.WriteLine("Não definido");
            }
        }
    }
}