using System;

namespace Secao3Aula29Exercicios2EstruturaCondicional03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 03:
                Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em  ordem crescente ou decrescente. 
            */

            Console.WriteLine("Insira 2 números");
            string[] ab = Console.ReadLine().Split(' ');

            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao Sao Multiplos");
            }
        }
    }
}
