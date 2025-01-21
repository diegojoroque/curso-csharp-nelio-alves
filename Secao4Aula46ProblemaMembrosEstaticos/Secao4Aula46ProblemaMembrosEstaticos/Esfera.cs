using System;
using System.Globalization;

namespace Secao4Aula46ProblemaMembrosEstaticos
{
    class Esfera
    {
        public double Raio;

        public double Circunferencia()
        {
            return 2.0 * Math.PI * Raio;
        }

        public double Volume()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(Raio, 3);
        }

        public override string ToString()
        {
            return "Circunferência: "
                + Circunferencia().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "Volume: "
                + Volume().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "Valor de PI: "
                + Math.PI.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
