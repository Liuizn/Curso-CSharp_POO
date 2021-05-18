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
            //Declarando as Classes
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            // Primeiro Funcionário
            Console.WriteLine("Dados do Primeiro Funcionário");

            Console.Write("Insira o Nome: ");
            func1.Nome = Console.ReadLine();

            Console.Write("Insira o salário: ");
            func1.Salario = double.Parse(Console.ReadLine());

            //Segundo Funcionário
            Console.WriteLine("Dados do Segundo Funcionário");

            Console.Write("Insira o Nome: ");
            func2.Nome = Console.ReadLine();

            Console.Write("Insira o Nome: ");
            func2.Salario = double.Parse(Console.ReadLine());

            double media = (func1.Salario + func2.Salario) / 2;

            Console.WriteLine($"Salário médio: {media}");
        }
    }
}
