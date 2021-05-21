using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucao_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double Circ = Calculadora.Circuferencia(raio);
            double Vol = Calculadora.Volume(raio);

            Console.WriteLine($"Circuferência: {Circ:F2}");
            Console.WriteLine($"Volume: {Vol:F2}");
            Console.WriteLine($"Valor de Pi: {Calculadora.Pi:F2}");
        }
    }
}
