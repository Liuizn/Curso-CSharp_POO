using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor de repetição: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("Insira o valor de X: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Insira o valor de Y: ");
                int y = int.Parse(Console.ReadLine());


                if (y == 0)
                {
                    Console.WriteLine("Divisão Impossível.");
                } 
                else
                {
                    double resultado = (double)x / y;
                    Console.WriteLine($"{resultado:F1}");
                }
            }
        }
    }
}
