using System;

namespace Secao3Aula29Exercicios2EstruturaCondicional01
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Exercício 01:
            Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            */

            Console.WriteLine("Informe o nº");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}
