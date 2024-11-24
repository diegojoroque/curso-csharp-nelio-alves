using System;

namespace Secao3Aula35Exercicios4EstruturaRepetitivaFor01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 02:
                 
                Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
                Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            */

            int n = int.Parse(Console.ReadLine());

            int x = 0, inside = 0, outside = 0;

            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    inside++;
                }
                else
                {
                    outside++;
                }
            }

            Console.WriteLine(inside + " in");
            Console.WriteLine(outside + " out");
        }
    }
}
