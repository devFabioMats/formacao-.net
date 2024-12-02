using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------------------");

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }
        }
    }
}
