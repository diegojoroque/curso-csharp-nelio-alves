using System;
using System.Globalization;

namespace Secao3Aula35Exercicios4EstruturaRepetitivaFor03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 03:
                Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
            */

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; 1 <= n; i++)
            {
                string[] value = Console.ReadLine().Split(' ');

                double value1 = double.Parse(value[0], CultureInfo.InvariantCulture);
                double value2 = double.Parse(value[1], CultureInfo.InvariantCulture);
                double value3 = double.Parse(value[2], CultureInfo.InvariantCulture);

                double mediapond = ((value1 * 2) + (value2 * 3) + (value3 * 5)) / (2 + 3 + 5);

                Console.WriteLine(mediapond.ToString("F1"));
            }
        }
    }
}
