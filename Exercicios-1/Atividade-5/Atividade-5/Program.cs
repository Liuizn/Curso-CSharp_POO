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
            // Área produto 1
            Console.Write("Insira o código da peça 1: ");
            int _1codigo = int.Parse(Console.ReadLine());

            Console.Write("Insira o número de peças que deseja comprar: ");
            int _1quantiPecas = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor unitário: ");
            float _1precoUnit = float.Parse(Console.ReadLine());

            // Área Produto 2

            Console.Write("Insira o código da peça 2: ");
            int _2codigo = int.Parse(Console.ReadLine());

            Console.Write("Insira o número de peças que deseja comprar: ");
            int _2quantiPecas = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor unitário: ");
            float _2precoUnit = float.Parse(Console.ReadLine());


            float total_pagar = (_1precoUnit * _1quantiPecas) + (_2precoUnit * _2quantiPecas);


            Console.WriteLine($"VALOR A PAGAR: R${total_pagar:F2}");


        }
    }
}
 