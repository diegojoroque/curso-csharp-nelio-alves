using System;
using System.Globalization;

namespace Secao3Aula29Exercicios2EstruturaCondicional08os
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do salário:");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double tax = 0, aliquot0 = 0, aliquot8 = 0.08, aliquot18 = 0.18, aliquot28 = 0.28;


            if (salary <= 2000)
            {
                tax = salary * aliquot0;
            }
            else if (salary <= 3000)
            {
                tax = (salary - 1000) * aliquot8;
            }
            else if (salary <= 4500)
            {
                tax = (salary - 3000) * aliquot18 + 1000 * aliquot8;
            }
            else
            {
                tax = (salary - 4500) * aliquot28 + 1500 * aliquot18 + 1000 * aliquot8;
            }

            if (tax == 0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
