using System;


namespace Produtos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade; 
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantindade)
        {
            Quantidade += quantindade;
        }

        public override string ToString()
        {
            return $"{Nome} $ {Preco:F2} , {Quantidade} unidades, Total: {ValorTotalEmEstoque():F2}";
        }

    }
}
