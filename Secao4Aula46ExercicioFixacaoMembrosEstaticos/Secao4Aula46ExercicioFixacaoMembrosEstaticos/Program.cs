using System;
using System.Globalization;

namespace Secao4Aula46ExercicioFixacaoMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício Fixação:

                Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por  uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda  que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe Conversor De Moeda para ser responsável pelos cálculos.
            */

            Console.Write("Qual é a cotação do dólar? ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantityDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double exchange = ConversorDeMoeda.DolarForReal(quantityDolar, price);

            Console.Write("Valor a ser pago em reais = " + exchange.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
