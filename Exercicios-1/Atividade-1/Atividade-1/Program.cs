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
            Console.Write("Digite um valor: ");
            int num1 = int.Parse (Console.ReadLine());

            Console.Write("Digite outro valor: ");
            int num2 = int.Parse(Console.ReadLine());


            int soma = num1 + num2;

            Console.WriteLine($"O valor da soma é {soma}");

            Console.ReadLine();
        }
    }
}
