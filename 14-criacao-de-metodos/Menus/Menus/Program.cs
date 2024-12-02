using System;

namespace Menus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo, escolha uma das seguintes opções");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                if (op == 0)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                else if (op == 1)
                {
                    somar();
                }
                else if (op == 2)
                {
                    subtrair();
                }
                else if (op == 3)
                {
                    multiplicar();
                }
                else
                {
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                }
            }
        }

        private static void subtrair()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(n1 + "-" + n2 + "=" + (n1 - n2));

            Console.ReadKey();
        }

        private static void somar()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(n1 + "+" + n2 + "=" + (n1 + n2));

            Console.ReadKey();
        }

        private static void multiplicar()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(n1 + "x" + n2 + "=" + (n1 * n2));

            Console.ReadKey();
        }
    }
}
