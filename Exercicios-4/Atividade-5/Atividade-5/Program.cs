using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o número para o cálculo: ");
            int N = int.Parse(Console.ReadLine());

            int fat = 1;

            for (int i = 1; i <= N; i++)
            {
                fat *= i;
            }

            Console.WriteLine(fat);
        }
    }
}
