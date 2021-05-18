using System;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da Classe
            Produto p = new Produto();

            //Entrada dos Dados do produto
            Console.WriteLine("Entre com os Dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            //Fim entradada

            //Saída da informação
            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");
            Console.WriteLine();

            //Entrada da adição de quantidade
            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            //Fim Entrada adição de quantidade

            p.AdicionarProdutos(qte);//Está realizando a adição da quantindade

            //Saída da informação
            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {p}");
            Console.WriteLine();

            //Entrada da subtração de quantidade
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte);//Está realizando a remoção da quantidade

            //Saída da informação
            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {p}");

        }
    }
}
