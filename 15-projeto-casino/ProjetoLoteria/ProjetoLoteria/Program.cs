using System;

namespace ProjetoLoteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;

            while (op != 0)
            {
                Console.WriteLine("Bem-vindo!");
                Console.WriteLine("Escolha uma das seguintes opções:");
                Console.WriteLine("1 - Loteria");
                Console.WriteLine("2 - Raspadinhas");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Obrigado por jogar!");
                        break;
                    case 1:
                        loteria();
                        break;
                    case 2:
                        raspadinha();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
