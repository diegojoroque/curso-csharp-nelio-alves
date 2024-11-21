using System;
using System.Globalization;
using System.Numerics;

namespace Secao3Aula29Exercicios2EstruturaCondicional05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 05:
                Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.
            */
            Console.WriteLine("Informe o ítem e a qtd desejada:");
            string[] menu = Console.ReadLine().Split(' ');

            int codigo = int.Parse(menu[0]);
            int qtd = int.Parse(menu[1]);

            double total;

            if (codigo == 1)
            {
                total = qtd * 4.00;
            }
            else if (codigo == 2)
            {
                total = qtd * 4.50;
            }
            else if (codigo == 3)
            {
                total = qtd * 5.00;
            }
            else if (codigo == 4)
            {
                total = qtd * 2.00;
            }
            else
            {
                total = qtd * 1.50;
            }

            Console.WriteLine("Total: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
