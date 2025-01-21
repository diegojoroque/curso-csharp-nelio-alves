using System;
using System.Globalization;

namespace Secao4Aula46ProblemaMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Problema exemplo:

                Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor de uma circunferência e do volume de uma esfera para um raio daquele valor. Informar também o valor de PI com duas casas decimais.
            */

            Esfera sphere = new Esfera();

            Console.Write("Entre o valor do raio: ");
            sphere.Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write(sphere);
        }
    }
}
