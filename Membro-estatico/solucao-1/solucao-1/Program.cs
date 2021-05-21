using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double Circu = Circuferencia(raio);
            double Vol = Volume(raio);

            Console.WriteLine($"Circuferência: {Circu:F2}");
            Console.WriteLine($"Volume: {Vol:F2}");
            Console.WriteLine($"Valor de PI: {Pi}");
        }

        static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
