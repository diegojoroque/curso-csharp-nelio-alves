using System;
using System.Globalization;

namespace Secao4Aula45ExercicioFixacaoClassAtribMet01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 01:
                Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado.
             */

            Retangulo retangle = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangle.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangle.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(retangle);
        }
    }
}
