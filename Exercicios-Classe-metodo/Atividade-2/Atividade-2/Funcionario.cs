using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = (SalarioBruto + (SalarioBruto * porcentagem / 100.0) - Imposto);
        }

        public override string ToString()
        {
            return $"{Nome}, $ {SalarioBruto}";
        }
    }
}
