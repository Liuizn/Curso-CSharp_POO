using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um valor: ");
            double N = double.Parse(Console.ReadLine());

            if (N >= 0 && N <= 25) 
            {
                Console.WriteLine("Intervalo [0,25]");
            } 
            else if (N > 25 && N <= 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (N > 50 && N <= 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (N > 75 && N <= 100)
            {
                Console.WriteLine("Intervalo [75.100]");
            } else 
            {
                Console.WriteLine("Valor inserido fora do intevalo.");
            }
        }
    }
}
