using System;

namespace Secao3Aula35Exercicios4EstruturaRepetitivaFor01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 01:

                Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
            */

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                int resto = i % 2;

                if (resto != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
