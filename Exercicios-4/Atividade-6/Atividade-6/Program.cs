using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

           for (int i = n; i !=0; i--)
            {
                int divisao = n / i;
                if (n % i == 0)
                {

                Console.WriteLine(divisao);
                }
            }
        }
    }
}
