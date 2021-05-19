using System;


namespace Atividade_3
{
    class SomaAluno
    {
        public string Nome;
        public double Not1, Not2, Not3, NotaFinal, falta;

        public double Calc()
        {
            NotaFinal = Not1 + Not2 + Not3;
            return NotaFinal;
        }

        public double FaltaPont()
        {
            double falta = 60 - NotaFinal;
            return falta;
        }
    }
}
