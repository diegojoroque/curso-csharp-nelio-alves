using System;
using System.ComponentModel.Design;

namespace Secao3Aula29Exercicios2EstruturaCondicional03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercício 04:
                Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            */

            Console.WriteLine("Informe a hora inicial e final do jogo:");
            string[] hora = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(hora[0]);
            int horaFinal = int.Parse(hora[1]);

            int duracao;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
        }
    }
}
