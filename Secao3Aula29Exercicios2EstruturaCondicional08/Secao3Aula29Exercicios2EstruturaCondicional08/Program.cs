using System;
using System.Globalization;

namespace Secao3Aula29Exercicios2EstruturaCondicional08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 08:

                Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$. 
                Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo. 
                Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais. 
            */

            Console.WriteLine("Informe o valor do salário:");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double range8 = salary - 2000;
            double range18 = salary - 3000;
            double range28 = salary - 4500;

            double aliquot8 = 0.08;
            double aliquot18 = 0.18;
            double aliquot28 = 0.28;

            double calc8 = range8 * aliquot8;
            double calc18 = (range18 * aliquot18) + ((range8 - range18) * aliquot8);
            double calc28 = (range28 * aliquot28) + ((range18 - range28) * aliquot18) + ((range8 - range18) * aliquot8);

            if (salary <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salary <= 3000)
            {
                Console.WriteLine("R$ " + calc8.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salary <= 4500)
            {
                Console.WriteLine("R$ " + calc18.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("R$ " + calc28.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
