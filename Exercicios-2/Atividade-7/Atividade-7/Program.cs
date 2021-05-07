using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor do eixo x: ");
            double X = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do exio y: ");
            double Y = double.Parse(Console.ReadLine());

            if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if ( X == 0 && Y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (Y == 0 && X != 0)
            {
                Console.WriteLine("Eixo X");
            }
        }
    }
}
