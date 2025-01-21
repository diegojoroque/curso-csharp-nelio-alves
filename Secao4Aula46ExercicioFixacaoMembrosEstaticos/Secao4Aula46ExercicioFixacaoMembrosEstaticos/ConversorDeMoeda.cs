using System;
using System.Globalization;

namespace Secao4Aula46ExercicioFixacaoMembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double Iof = 1.06; //iof = 6.0%
        public static double DolarForReal(double quantityDolar, double price)
        {
            return quantityDolar * price * Iof;
        }

    }
}
