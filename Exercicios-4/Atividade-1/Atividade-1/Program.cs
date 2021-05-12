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

            Console.Write("Insira um valor: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
