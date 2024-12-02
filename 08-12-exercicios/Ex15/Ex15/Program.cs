/*Enunciado: o preço de um automovel é calculado pela soma do preço de fabrica com o preco dos impostos (45% do preço de fabrica)
 * e a porcentagem do revendedor (28% do preço de fabrica). Faça um algoritmo que leia o nome do automovel e o preço de fabrica
 * e escreva o nome do automovel e o preço final
*/

using System;

namespace Ex14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double precoFabrica = 0,
                   precoImpostos = 0,
                   precoRevendedor = 0,
                   precoFinal = 0,
                   porcentagemImpostos = 0.45,
                   porcentagemRevendedor = 0.28;

            string nomeAutomovel = "";

            Console.WriteLine("Informe o nome do automóvel: ");
            nomeAutomovel = Console.ReadLine();

            Console.WriteLine("Informe o preço de fábrica: R$ ");
            precoFabrica = double.Parse(Console.ReadLine());

            precoImpostos = precoFabrica * porcentagemImpostos;
            precoRevendedor = precoFabrica * porcentagemRevendedor;
            precoFinal = precoFabrica + precoImpostos + precoRevendedor;

            Console.WriteLine("O valor final do automóvel " + nomeAutomovel + " é de R$ " + precoFinal);
        }
    }
}