using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1 = "Ana Silva";
            string nome2 = "Maria Gomes";
            string nome3 = "Vander Lobão";
            string nome4 = "José Valdo";
            string nome5 = "Main Yasuo";

            Console.WriteLine("Nome 1: " + nome1);
            Console.WriteLine("Nome 2: " + nome2);
            Console.WriteLine("Nome 3: " + nome3);
            Console.WriteLine("Nome 4: " + nome4);
            Console.WriteLine("Nome 5: " + nome5);

            Console.WriteLine("--------------------------------------------------------");

            string[] nomes = new string[] { "Ana", "Maria", "Vander", "José", "Main" };

            string[] sobrenomes = new string[5];
            sobrenomes[0] = "Silva";
            sobrenomes[1] = "Gomes";
            sobrenomes[2] = "Lobão";
            sobrenomes[3] = "Valdo";
            sobrenomes[4] = "Yasuo";

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome " + (i + 1) + ": " + nomes[i] + " " + sobrenomes[i]);
            }

            Random rnd = new Random();
            int[] numeros = new int[50];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(1, 100);
                Console.Write(numeros[i] + "  ");
            }

            double[] decimais = new double[10];
            bool[] verdadeirosFalsos = new bool[10];

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------");

            int[,] tabuada = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabuada[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabuada[i, j] + "\t");
                }
            }
        }
    }
}
