using System;
using System.Globalization;
using Secao4Aula45ExercicioFixacaoClassAtribMet02;

namespace Secao4Aula45ExercicioFixacaoClassAtribMet01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 02:
                Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário. Use a classe projetada abaixo. 
            */

            Funcionario employee = new Funcionario();

            Console.Write("Nome: ");
            employee.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            employee.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            employee.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + employee);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + employee);
        }
    }
}
