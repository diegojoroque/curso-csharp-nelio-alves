using System;
using System.Globalization;

namespace Secao4Aula45ExercicioFixacaoClassAtribMet03
{
    class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3;

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public double PontosReprovacao()
        {
            return 60 - NotaFinal();
        }

        public string Aprovacao()
        {
            if (NotaFinal() >= 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO" + "\n" + "FALTARAM " + PontosReprovacao().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }
        public override string ToString()
        {
            return "NOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture) + "\n" + Aprovacao();
        }
    }
}
