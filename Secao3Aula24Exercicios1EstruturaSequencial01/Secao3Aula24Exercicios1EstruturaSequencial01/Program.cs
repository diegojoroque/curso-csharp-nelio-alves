using System;
using System.Globalization;

namespace Secao3Aula24Exercicios1EstruturaSequencial01
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Exercício 01:
            Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
            mensagem explicativa, conforme exemplos.
            */

            int value1, value2, sum;

            Console.WriteLine("Informe o 1º valor da soma:");
            value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o 2º valor da soma:");
            value2 = int.Parse(Console.ReadLine());

            sum = value1 + value2;

            Console.WriteLine("SOMA = " + sum);
        }
    }
}
