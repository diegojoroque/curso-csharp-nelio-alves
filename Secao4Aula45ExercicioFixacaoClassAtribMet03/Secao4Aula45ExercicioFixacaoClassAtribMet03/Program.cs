﻿using System;
using System.Globalization;

namespace Secao4Aula45ExercicioFixacaoClassAtribMet03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 03:
                Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano  (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este problema. 
            */
            Aluno student = new Aluno();

            Console.Write("Nome do aluno: ");
            student.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            student.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(student);
        }
    }
}
