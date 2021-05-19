using System;


namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SomaAluno soma = new SomaAluno();

            Console.Write("Digite seu Nome: ");
            soma.Nome = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            soma.Not1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            soma.Not2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            soma.Not3 = double.Parse(Console.ReadLine());

            Console.WriteLine(soma.Calc());

            if (soma.Calc() >= 60)
            {
                Console.WriteLine("APROVADO");
            } else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"Falta {soma.FaltaPont()}");
            }
        }
    }
}
