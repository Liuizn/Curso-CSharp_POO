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
            //Declaração da Classe
            Funcionario func = new Funcionario();

            //Entrada de Dados
            Console.Write("Insira o seu Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Insira o seu Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Insira o seu Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());
            //Fim Entrada

            //Saída do Nome e SalárioLiquido
            Console.WriteLine($"Funcionário: {func}");

            //Entrada Porcentagem
            Console.Write("Digite a porcentagem para o salário: ");
            double porc = double.Parse(Console.ReadLine());
            //Fim entrada

            func.AumentarSalario(porc);//Atualiza o salário com a porcetagem

            Console.WriteLine($"Dados Atualizados: {func}");

        }
    }
}
