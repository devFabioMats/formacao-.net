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
                Console.WriteLine("Número premiado: " + numeroPremiado);
            }

            Console.ReadKey();
            
        }

        private static void Raspadinha()
        {
            int op = 1;

            while (op != 0)
            {
                Console.Clear();
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
            Console.Clear();

            int numeroPrincipal = rnd.Next(1, 10);
            int n1 = rnd.Next(1, 10); int p1 = rnd.Next(1, 100);
            int n2 = rnd.Next(1, 10); int p2 = rnd.Next(1, 100);
            int n3 = rnd.Next(1, 10); int p3 = rnd.Next(1, 100); 
            int n4 = rnd.Next(1, 10); int p4 = rnd.Next(1, 100);
            int n5 = rnd.Next(1, 10); int p5 = rnd.Next(1, 100);

            Console.WriteLine("Número principal: " + numeroPrincipal);
            Console.WriteLine("1º número " + n1 + " (R$ " + p1 + ")");
            Console.WriteLine("2º número " + n2 + " (R$ " + p2 + ")");
            Console.WriteLine("3º número " + n3 + " (R$ " + p3 + ")");
            Console.WriteLine("4º número " + n4 + " (R$ " + p4 + ")");
            Console.WriteLine("5º número " + n5 + " (R$ " + p5 + ")");

            int premio = 0;

            if (numeroPrincipal == n1) premio += p1;
            if (numeroPrincipal == n2) premio += p2;
            if (numeroPrincipal == n3) premio += p3;
            if (numeroPrincipal == n4) premio += p4;
            if (numeroPrincipal == n5) premio += p5;

            Console.WriteLine("Prêmio: R$ " + premio);

            Console.ReadKey();
        }
        private static void RaspadinhaB()
        {
            Console.Clear();

            int numeroPrincipal = rnd.Next(1, 10);
            int premio = rnd.Next(1, 100);

            int n1 = rnd.Next(1, 10);
            int n2 = rnd.Next(1, 10);
            int n3 = rnd.Next(1, 10);
            int n4 = rnd.Next(1, 10);
            int n5 = rnd.Next(1, 10);
            int n6 = rnd.Next(1, 10);
            int n7 = rnd.Next(1, 10);
            int n8 = rnd.Next(1, 10);
            int n9 = rnd.Next(1, 10);

            int contador = 0;

            if (numeroPrincipal == n1) contador++;
            if (numeroPrincipal == n2) contador++;
            if (numeroPrincipal == n3) contador++;
            if (numeroPrincipal == n4) contador++;
            if (numeroPrincipal == n5) contador++;
            if (numeroPrincipal == n6) contador++;
            if (numeroPrincipal == n7) contador++;
            if (numeroPrincipal == n8) contador++;
            if (numeroPrincipal == n9) contador++;

            Console.WriteLine("Número principal: " + numeroPrincipal + " (Prêmio: R$ " + premio + ")");
            Console.WriteLine(n1 + " " + n2 + " " + n3);
            Console.WriteLine(n4 + " " + n5 + " " + n6);
            Console.WriteLine(n7 + " " + n8 + " " + n9);

            if (contador >= 3) {
                Console.WriteLine("Parabéns! Você foi premiado! (Ganhou: R$ " + premio + ")");
                premio += 100;
            } else
            {
                Console.WriteLine("Que pena! Raspadinha não premiada!");
            }

            Console.ReadKey();
        }
    }
}
