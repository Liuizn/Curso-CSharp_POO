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
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade desejada: ");
            int quantidade = int.Parse(Console.ReadLine());


            double total = 0;

            if (codigo == 1)
            {
                double valor1 = 4.00;
                total = valor1 * quantidade;
            }
            else if (codigo == 2)
            {
                double valor2 = 4.50;
                total = valor2 * quantidade;
            }
            else if (codigo == 3)
            {
                double valor3 = 5.00;
                total = valor3 * quantidade;
            }
            else if (codigo == 4)
            {
                double valor4 = 2.00;
                total = valor4 * quantidade;
            }
            else if (codigo == 5)
            {
                double valor5 = 1.50;
                total = valor5 * quantidade;
            }
            else
            {
                Console.WriteLine("Código não encontrado");
            }

            Console.WriteLine($"Total: R${total:F2}");

        }
    }
}
