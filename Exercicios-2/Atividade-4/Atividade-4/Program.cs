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

            Console.Write("Insira a Hora inicial: ");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.Write("Insira a Hora final: ");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao = 0;

            if (horaInicial < horaFinal )
            {
                duracao = horaFinal - horaInicial;
            } else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}
