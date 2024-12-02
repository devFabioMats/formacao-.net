/*
 * Enunciado: utilizar SE para fazer um programa que retorne o nome de um produto a partir do código do mesmo.
 * Considere o seguinte código:
 * a. 001 - Parafuso;
 * b. 002 - Porca;
 * c. 003 - Prego;
 * d. Para qualquer outro código indicar "Não definido".
*/

using System;

namespace Ex12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int codigo = 0;

            Console.WriteLine("Insira o código do produto: ");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("001 - Parafuso");
                    break;
                case 2:
                    Console.WriteLine("002 - Porca");
                    break;
                case 3:
                    Console.WriteLine("003 - Prego");
                    break;
                default:
                    Console.WriteLine("Não definido");
                    break;
            }
        }
    }
}