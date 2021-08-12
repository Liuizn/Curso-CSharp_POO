using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Luiz");
            list.Add("Marília");
            list.Add("Alex");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine();

            list.Insert(1, "Sobrou só eu");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Quantidade de indivíduos: {list.Count}");

            string encontra1Posicao = list.Find(primeiraPosicao);
            Console.WriteLine($"Primeira posição com M: {encontra1Posicao}");

            string encontraUltimaPosicao = list.FindLast(ultimaPosicao);
            Console.WriteLine($"Ultima posição com M: {encontraUltimaPosicao}");

            Console.WriteLine();
            Console.WriteLine();

            int referenciaPrimeira = list.FindIndex( x => x[0] == 'A');
            Console.WriteLine($"Index da primeira Posição com A: {referenciaPrimeira}");

            int referenciaUltima = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Index da última Posição com A: {referenciaUltima}");

            Console.WriteLine();
            Console.WriteLine();

            List<string> filtraLista = list.FindAll(x => x.Length == 4);

            foreach (string valor in filtraLista)
            {
                Console.WriteLine(valor);
            }


            Console.WriteLine();
            Console.WriteLine();

            list.Remove("Luiz");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            list.RemoveAll(x => x[0] == 'M');
            foreach (string valor in list)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine();
            Console.WriteLine();


            list.RemoveAt(0);
            foreach (string valor in list)
            {
                Console.WriteLine(valor);
            }

        }

        static bool primeiraPosicao(string valor)
        {
            return valor[0] == 'M';
        }

        static bool ultimaPosicao(string valor)
        {
            return valor[0] == 'M';
        }

    }
}
