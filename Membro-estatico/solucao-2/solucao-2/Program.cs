using System;


namespace solucao_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora calc = new Calculadora();

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double Circ = calc.Circunferencia(raio);
            double Vol = calc.Volume(raio);

            Console.WriteLine($"Circuferência: {Circ}");
            Console.WriteLine($"Volume: {Vol}");
            Console.WriteLine($"Valor de pi: {calc.Pi}");
        }
    }
}
