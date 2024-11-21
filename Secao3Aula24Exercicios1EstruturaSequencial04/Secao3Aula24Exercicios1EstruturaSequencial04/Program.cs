using System;
using System.Globalization;

namespace Secao3Aula24Exercicios1EstruturaSequencial04
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Exercício 04:
            Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
            */

            Console.WriteLine("Informe o número do funcionário:");
            int employeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de horas trabalhadas:");
            double hoursWorked = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o salário/hora:");
            double hourlyRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = hoursWorked * hourlyRate;

            Console.WriteLine("NUMBER = " + employeeNumber);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
