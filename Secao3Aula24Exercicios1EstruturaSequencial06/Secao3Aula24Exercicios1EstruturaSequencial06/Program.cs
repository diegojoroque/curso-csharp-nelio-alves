using System;
using System.Globalization;

namespace Secao3Aula24Exercicios1EstruturaSequencial06
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*           
            Exercício 06: 
            Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:  
            a) a área do triângulo retângulo que tem A por base e C por altura.  
            b) a área do círculo de raio C. (pi = 3.14159)  
            c) a área do trapézio que tem A e B por bases e C por altura.  
            d) a área do quadrado que tem lado B.  
            e) a área do retângulo que tem lados A e B. 
            */

            double a, b, c, areaTriangle, areaCircle, areaTrapeze, areaSquare, areaRectangle;

            Console.WriteLine("Informe os valores de A, B e C, respectivamente:");
            string[] values = Console.ReadLine().Split(' ');

            a = double.Parse(values[0], CultureInfo.InvariantCulture);
            b = double.Parse(values[1], CultureInfo.InvariantCulture);
            c = double.Parse(values[2], CultureInfo.InvariantCulture);

            areaTriangle = (a * c) / 2;
            areaCircle = 3.14159 * Math.Pow(c, 2);
            areaTrapeze = ((a + b) * c) / 2;
            areaSquare = Math.Pow(b, 2);
            areaRectangle = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriangle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCircle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapeze.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaSquare.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRectangle.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
