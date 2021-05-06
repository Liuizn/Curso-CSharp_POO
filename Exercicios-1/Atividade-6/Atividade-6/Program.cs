using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o valor do lado A: ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do lado B: ");
            double B = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do lado C: ");
            double C = double.Parse(Console.ReadLine());

            double areaTriangulo = A * C / 2;
            double areaCirculo = 3.14159 * Math.Pow(C, 2);
            double areaTrapezio = ((A + B) / 2) * C;
            double areaQuadrado = Math.Pow(B, 2) + Math.Pow(B, 2);
            double areaRetangulo = A * B;



            Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
            Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
            Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
            Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");

        }
    }
}
