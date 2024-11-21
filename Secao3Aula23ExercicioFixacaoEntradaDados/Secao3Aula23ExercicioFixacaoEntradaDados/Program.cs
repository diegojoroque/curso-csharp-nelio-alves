using System;
using System.Globalization;

namespace Secao3Aula23ExercicioFixacaoEntradaDados
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo");
            string fullname = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa ?");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] profile = Console.ReadLine().Split(' ');

            string lastName = profile[0];
            int age = int.Parse(profile[1]);
            double height = double.Parse(profile[2], CultureInfo.InvariantCulture);

            Console.WriteLine(fullname);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
