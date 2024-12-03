using System;

namespace ProjetoLoteria
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int op = 1;

            while (op != 0)
            {
                Console.WriteLine("Bem-vindo!");
                Console.WriteLine("Escolha uma das seguintes opções:");
                Console.WriteLine("1 - Loteria");
                Console.WriteLine("2 - Raspadinha");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Obrigado por jogar!");
                        break;
                    case 1:
                        Loteria();
                        break;
                    case 2:
                        Raspadinha();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private static void Loteria()
        {
            Console.Clear();

            int numeroPremiado = rnd.Next(1000, 10000);

            int numeroJogado = 0;
            while (numeroJogado < 1000 || numeroPremiado > 9999)
            {
                Console.WriteLine("Qual número quer jogar na loteria? (1000-9999)");
                numeroJogado = int.Parse(Console.ReadLine());
            }

            if (numeroJogado == numeroPremiado)
            {
                Console.WriteLine("Parabéns! Você ganhou o 1º prêmio!");
            }
            else if (numeroJogado % 100 == numeroPremiado % 100)
            {
                Console.WriteLine("Parabéns! Você ganhou o 2º prêmio!");
            }
            else if (numeroJogado % 10 == numeroPremiado % 10)
            {
                Console.WriteLine("Parabéns! Você ganhou o 3º prêmio!");
            }
            else
            {
                Console.WriteLine("Que pena! O número escolhido não era o premiado");
            }

            Console.ReadKey();
            
        }

        private static void Raspadinha()
        {
            int op = 1;

            while (op != 0)
            {
                Console.WriteLine("Menu Raspadinhas:");
                Console.WriteLine("1 - Raspadinha A");
                Console.WriteLine("2 - Raspadinha B");
                Console.WriteLine("0 - Voltar ao menu anterior");
                op = int.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Voltando ao menu anterior...");
                        break;
                    case 1:
                        RaspadinhaA();
                        break;
                    case 2:
                        RaspadinhaB();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private static void RaspadinhaA()
        {
            throw new NotImplementedException();
        }
        private static void RaspadinhaB()
        {

        }

        
    }
}
