using System;

namespace Secao3Aula33Exercicios3EstruturaRepetitivaWhile02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 02:
            
                Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). 
            */

            Console.WriteLine("Informe as coordenadas X e Y, respectivamente:");
            string[] xy = Console.ReadLine().Split(' ');

            int x = int.Parse(xy[0]);
            int y = int.Parse(xy[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }

                xy = Console.ReadLine().Split(' ');

                x = int.Parse(xy[0]);
                y = int.Parse(xy[1]);
            }
        }
    }
}
