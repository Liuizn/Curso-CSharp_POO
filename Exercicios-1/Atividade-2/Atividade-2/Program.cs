using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o valor do raio: ");
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine(raio);

            double pi = 3.14159;

            double area = pi * Math.Pow(raio, 2);


            Console.WriteLine($"O valor da Área é {area}");

           Console.ReadLine();
        }
    }
}
