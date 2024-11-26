using System;
using System.Globalization;

namespace Secao4Aula40ClassesObjetosAtributos02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 02:
                Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário  médio dos funcionários.
            */

            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            employee1.FullName = Console.ReadLine();
            Console.Write("Salário: ");
            employee1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            employee2.FullName = Console.ReadLine();
            Console.Write("Salário: ");
            employee2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double averageSalary = (employee1.Salary + employee2.Salary) / 2;

            Console.WriteLine("Salário médio = " + averageSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
