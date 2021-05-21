using System;


namespace Atividade_membros_estáticos
{
    class ConversorDeMoeda
    {       
        public static double ConversorDolarToReal(double qtd, double cot)
        {
            return (qtd * cot) * 1.06;
        }
    }
}
