using System;

namespace Secao3Aula33Exercicios3EstruturaRepetitivaWhile02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 03:

            Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.
            */

            Console.WriteLine("Informe uma opção:");
            int option = int.Parse(Console.ReadLine());

            int alcool = 0, gasolina = 0, diesel = 0;

            while (option < 1 && option > 4)
            {
                if (option == 1)
                {
                    alcool++;
                }
                else if (option == 2)
                {
                    gasolina++;
                }
                else if (option == 3)
                {
                    diesel++;
                }
                else
                {
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine("alcool: ", alcool);
                    Console.WriteLine("gasolina: ", gasolina);
                    Console.WriteLine("diesel: ", diesel);
                }
            }
        }
    }
}
