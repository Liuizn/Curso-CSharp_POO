using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira um número do tipo inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("NÃO NEGATIVO.");
            } else
            {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}
