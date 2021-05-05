using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o 1 número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o 2 número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Insira o 3 número: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Insira o 4 número: ");
            int num4 = int.Parse(Console.ReadLine());

            int diference = ((num1 * num2) - (num3 * num4));

            Console.WriteLine($"A diferença entre os valores é {diference}");
        }
    }
}

