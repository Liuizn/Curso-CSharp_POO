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
            //Criação da Classe
            Triangulo triang = new Triangulo();

            //Entrada de Dados do Triangulo
            Console.WriteLine("Insira a Largura do Triângulo: ");
            triang.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a Altura do Triângulo: ");
            triang.Altura = double.Parse(Console.ReadLine());
            //Fim Entrada

            //Saída dos Dados
            Console.WriteLine($"AREA = {triang.CalcularArea():F2}");
            Console.WriteLine($"PERIMETRO = {triang.CalcularPerimetro():F2}");
            Console.WriteLine($"DIAGONAL = {triang.CalcularDiagonal():F2}");

        }
    }
}
