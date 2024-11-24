using System;
using System.Globalization;

namespace Secao3Aula35Exercicios4EstruturaRepetitivaFor04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 04:
                Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
            */

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] value = Console.ReadLine().Split(' ');

                double value1 = double.Parse(value[0], CultureInfo.InvariantCulture);
                double value2 = double.Parse(value[1], CultureInfo.InvariantCulture);

                if (value2 != 0)
                {
                    double resultado = value1 / value2;

                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
            }
        }
    }
}
