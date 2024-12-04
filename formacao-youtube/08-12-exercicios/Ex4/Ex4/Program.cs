/*
 * Enunciado: Calcular área do triângulo
*/

using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseTriangulo = 0,
                alturaTriangulo = 0,
                area = 0;

            Console.WriteLine("Informe a base do triângulo: ");
            baseTriangulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do triângulo: ");
            alturaTriangulo = int.Parse(Console.ReadLine());

            area = baseTriangulo * alturaTriangulo / 2;

            Console.WriteLine("A área do triângulo informado é: " + area);
        }
    }
}
