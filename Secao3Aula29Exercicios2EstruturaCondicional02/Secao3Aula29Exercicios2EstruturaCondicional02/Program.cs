using System;

namespace Secao3Aula29Exercicios2EstruturaCondicional02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 02:
                Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar. 
            */

            Console.WriteLine("Insira um nº");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
