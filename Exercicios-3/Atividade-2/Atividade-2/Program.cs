using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor do eixo X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor do eixo Y: ");
            int Y = int.Parse(Console.ReadLine());

            while (X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("primeiro");

                    Console.Write("Reinsira o valor do eixo X: ");
                    X = int.Parse(Console.ReadLine());
                    Console.Write("Reinsira o valor do eixo Y: ");
                    Y = int.Parse(Console.ReadLine());
                } else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("Segundo");

                    Console.Write("Reinsira o valor do eixo X: ");
                    X = int.Parse(Console.ReadLine());
                    Console.Write("Reinsira o valor do eixo Y: ");
                    Y = int.Parse(Console.ReadLine());
                } else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("Terceiro");

                    Console.Write("Reinsira o valor do eixo X: ");
                    X = int.Parse(Console.ReadLine());
                    Console.Write("Reinsira o valor do eixo Y: ");
                    Y = int.Parse(Console.ReadLine());
                } else if (X > 0 && Y < 0)
                {
                    Console.WriteLine("Quarto");

                    Console.Write("Reinsira o valor do eixo X: ");
                    X = int.Parse(Console.ReadLine());
                    Console.Write("Reinsira o valor do eixo Y: ");
                    Y = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("");
        }
    }
}
