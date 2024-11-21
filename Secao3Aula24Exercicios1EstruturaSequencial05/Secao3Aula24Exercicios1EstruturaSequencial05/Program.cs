using System;
using System.Globalization;

namespace Secao3Aula24Exercicios1EstruturaSequencial05
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*           
            Exercício 05:
            Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
            */

            Console.WriteLine("Informe o código, qtd e valor unitário da peça 1:");
            string[] peca1 = Console.ReadLine().Split(' ');

            int codPeca1, qtdPeca1, codPeca2, qtdPeca2;
            double pricePeca1, pricePeca2, total;

            codPeca1 = int.Parse(peca1[0]);
            qtdPeca1 = int.Parse(peca1[1]);
            pricePeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o código, qtd e valor unitário da peça 2:");
            string[] peca2 = Console.ReadLine().Split(' ');

            codPeca2 = int.Parse(peca2[0]);
            qtdPeca2 = int.Parse(peca2[1]);
            pricePeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            total = (qtdPeca1 * pricePeca1) + (qtdPeca2 * pricePeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
