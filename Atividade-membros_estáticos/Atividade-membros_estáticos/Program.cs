using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_membros_estáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a Cotação do dólar: ");
            double CotDolar = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você irá comprar: ");
            double QtdDolar = double.Parse(Console.ReadLine());

            double ValorConvertido = ConversorDeMoeda.ConversorDolarToReal(QtdDolar, CotDolar);

            Console.WriteLine($"Valor a ser pago em reais: {ValorConvertido:F2}");
        }
    }

}
