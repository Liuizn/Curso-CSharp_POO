using System;


namespace Atividade_1
{
    class Triangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }


    }
}
