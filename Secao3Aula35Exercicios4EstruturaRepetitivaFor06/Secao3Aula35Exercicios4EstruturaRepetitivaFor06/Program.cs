﻿using System;

namespace Secao3Aula35Exercicios4EstruturaRepetitivaFor06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 06:

                Ler um número inteiro N e calcular todos os seus divisores.
            */

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
