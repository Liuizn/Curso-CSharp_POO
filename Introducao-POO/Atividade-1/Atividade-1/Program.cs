using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
           Pessoa pessoa1 = new Pessoa();
           Pessoa pessoa2 = new Pessoa();
        //Primeira pessoa
            Console.Write("Insira o nome da primeira pessoa: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Insira a idade da primeira pessoa: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            //Segunda Pessoa
            Console.Write("Insira o nome da segunda pessoa: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("insira a idade da segunda pessoa: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            //Estrutura de condição
            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"a pessoa com maior idade é {pessoa1.Nome}");
            } else
            {
                Console.WriteLine($"a pessoa com maior idade é {pessoa2.Nome}");
            }

        }
    }
}
