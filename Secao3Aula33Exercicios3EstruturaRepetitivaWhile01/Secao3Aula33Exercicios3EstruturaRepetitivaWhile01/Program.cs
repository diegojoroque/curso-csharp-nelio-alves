using System;

namespace Secao3Aula33Exercicios3EstruturaRepetitivaWhile01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 01:

                Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
            */

            Console.WriteLine("Insira a senha:");
            int password = int.Parse(Console.ReadLine());

            while (password != 2002)
            {
                Console.WriteLine("Senha Invalida");
                password = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
