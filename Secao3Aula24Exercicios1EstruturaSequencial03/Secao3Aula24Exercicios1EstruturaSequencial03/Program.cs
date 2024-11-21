using System;
using System.Globalization;

namespace Secao3Aula24Exercicios1EstruturaSequencial03
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Exercício 03:
            Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). 
            */

            int A, B, C, D, diferenca;

            Console.WriteLine("Informe o valor de A:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C:");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de D:");
            D = int.Parse(Console.ReadLine());

            diferenca = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}
