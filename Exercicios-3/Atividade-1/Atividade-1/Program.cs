using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.Write("Senha incorreta, Digite novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Senha Correta.");
        }
    }
}
