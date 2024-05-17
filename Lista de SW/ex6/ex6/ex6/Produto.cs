using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaproduto
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }
    }

    class GerenciadorDeProdutos
    {
        private List<Produto> produtos;

        public GerenciadorDeProdutos()
        {
            produtos = new List<Produto>();
        }

        public void AdicionarProduto(string nome, double preco, int quantidadeEmEstoque)
        {
            Produto novoProduto = new Produto(nome, preco, quantidadeEmEstoque);
            produtos.Add(novoProduto);
            Console.WriteLine("Produto adicionado com sucesso!");
        }

        public void ApresentarProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.Nome} | Preço: R${produto.Preco:F2} | Quantidade em Estoque: {produto.QuantidadeEmEstoque}");
            }
        }

        public Produto ConsultarProduto(string nome)
        {
            return produtos.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
    }

}