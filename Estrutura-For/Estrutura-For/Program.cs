using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira quantos números você vai digitar: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("oi");
            }
        }
    }
}
