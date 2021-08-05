using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_modulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta dadosConta; 

            Console.Write("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Títular da conta: ");
            string numTitular = Console.ReadLine();

            Console.Write("Hávera depósito inicial: (sim/não): ");
            string depInicial = Console.ReadLine();

            if (depInicial == "sim")
            {
                Console.Write("Entre com o valor Inicial: ");
                double saldo = int.Parse(Console.ReadLine());

                dadosConta = new Conta(numConta, numTitular, saldo);
            }
            else
            {
                dadosConta = new Conta(numConta, numTitular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(dadosConta);


            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            dadosConta.Deposito(quantia);


            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(dadosConta);


            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            dadosConta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(dadosConta);




            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(dadosConta);

        }
    }
}
