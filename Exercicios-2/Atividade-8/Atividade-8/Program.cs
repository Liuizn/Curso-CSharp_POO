using System;

namespace Atividade_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o seu salário para verificação do imposto: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario >= 0 && salario <= 2000.00)
            {
                Console.WriteLine("Saída: Isento.");
            }
            else if (salario >= 2000.01 && salario <= 3000.00)
            {
                salario -= 2000.00;
                salario *= 0.08;
                Console.WriteLine($"R$: {salario:F2}");

            }
            else if (salario >= 3000.01 && salario <= 4500.00)
            {
                salario -= 3000;
                salario *= 0.18;
                salario += 80;
                Console.WriteLine($"R$: {salario:F2}");
            }
            else if (salario > 4500.00)
            {
                salario -= 4500;
                salario *= 0.28;
                salario += 350;
                Console.WriteLine($"R$: {salario:F2}");

            }
        }
    }
}
