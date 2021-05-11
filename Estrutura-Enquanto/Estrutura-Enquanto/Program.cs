using System;
using System.Globalization;


namespace Estrutura_Enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
