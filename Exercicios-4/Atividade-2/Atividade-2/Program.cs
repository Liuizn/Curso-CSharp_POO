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
            Console.Write("Insira o valor de números: ");
            int N = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Insira o valor: ");
                int num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 20)
                {
                    dentro += 1;
                } 
                else
                {
                    fora += 1;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
