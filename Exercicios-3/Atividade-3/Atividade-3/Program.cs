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
            int num = 0;
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;
            while (num != 4)
            {
                Console.WriteLine("1- ÁLCOOL | 2- GASOLINA | 3- DIESEL | 4- SAIR");
                num = int.Parse(Console.ReadLine());


                if (num == 4) 
                {
                Console.WriteLine("MUITO OBRIGADO!");
                Console.WriteLine($"Álcool: {alcool}");
                Console.WriteLine($"Gasolina: {gasolina}");
                Console.WriteLine($"Diesel: {diesel}");
                } 
                else if (num == 1)
                {
                    alcool += 1;
                    Console.WriteLine("Adicionado 'Álcool'.");
                }
                else if (num == 2)
                {
                    gasolina += 1;
                    Console.WriteLine("Adicionado 'Gasolina'.");
                }
                else if (num == 3)
                {
                    Console.WriteLine("Adicionado 'Diesel'.");
                    diesel += 1;
                }
                else if (num != 1 && num != 2 && num != 3 && num != 4)
                {
                    Console.WriteLine("Código invalido.");
                }



            }
        }
    }
}
