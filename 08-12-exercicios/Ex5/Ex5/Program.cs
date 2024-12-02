/*
 * Enunciado: Calcular troco
*/

using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorPago = 0,
                valorProduto = 0,
                troco = 0;


            Console.WriteLine("Informe o valor pago: ");
            valorPago = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do produto: ");
            valorProduto = float.Parse(Console.ReadLine());

            troco = valorPago - valorProduto;

            Console.WriteLine("O seu troco será de R$ " + troco.ToString("F2"));
        }
    }
}
