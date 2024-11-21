using System;
using System.Globalization;

namespace Secao3Aula24Exercicios1EstruturaSequencial02
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Exercício 02:
            Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos. 
            Fórmula da área: area = π . raio2 
            Considere o valor de π = 3.14159 
            */

            Console.WriteLine("Informe o raio do círculo:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
