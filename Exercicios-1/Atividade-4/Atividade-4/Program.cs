using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o seu Número: ");
            int cadastro = int.Parse(Console.ReadLine());

            Console.Write("Insira o Valor por Hora do seu Serviço: ");
            float valorHora = float.Parse(Console.ReadLine());

            Console.Write("Insira as horas trabalhadas: ");
            int horaTrabalhada = int.Parse(Console.ReadLine());


            float calculo = horaTrabalhada * valorHora;


            Console.WriteLine($"NUMBER = {cadastro}");
            Console.WriteLine("SALARY = U$ " + calculo.ToString("F2"));




        }
    }
}
