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
            Console.Write("Quantos testes?: ");
            int numeroTestes = int.Parse(Console.ReadLine());

            double num1;double num2; double num3; double saida;

            for (int i = 0; i < numeroTestes; i++)
            {
                Console.Write("Insira o primeiro número: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Insira o segundo número: ");
                num2 = double.Parse(Console.ReadLine());

                Console.Write("Insira o terceiro número: ");
                num3 = double.Parse(Console.ReadLine());


                saida = ((num1 * 2) + (num2 * 3) + (num3 * 5)) / (2 + 3 + 5);

                Console.WriteLine($"Saída: {saida:F1}");


            }
               
        }
    }
}
