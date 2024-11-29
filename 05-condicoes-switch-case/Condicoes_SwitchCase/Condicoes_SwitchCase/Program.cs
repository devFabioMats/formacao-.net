using System;

namespace Condicoes_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escola uma das opções");
            Console.WriteLine("1 - criar arquivo");
            Console.WriteLine("2 - abrir arquivo");
            Console.WriteLine("3 - salvar arquivo");
            Console.WriteLine("0 - sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Opção 1 selecionado");
                    break;
                case 2:
                    Console.WriteLine("Opção 2 selecionado");
                    break;
                case 3:
                    Console.WriteLine("Opção 3 selecionado");
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        }
    }
}
