using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());


            if (num1 % num2 == 0 || num2 % num1 == 0 )
            {
                Console.WriteLine("São Multiplos");
            } else
            {
                Console.WriteLine("Não são multiplos");
            }

        }
    }
}
