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
            Console.Write("Insira um valor: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
                Console.Write($"{Math.Pow(i, 2)} ");
                Console.Write(Math.Pow(i,3));
                Console.WriteLine();
            }
        }
    }
}
