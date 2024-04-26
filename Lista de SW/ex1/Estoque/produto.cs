using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    public class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int QuantidadeEmEstoque { get; private set; }

        // Construtor
        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        // Método para adicionar itens ao estoque
        public void AdicionarItem(int quantidade)
        {
            if (quantidade > 0)
                QuantidadeEmEstoque += quantidade;
            else
                Console.WriteLine("A quantidade deve ser maior que zero.");
        }

        // Método para remover itens do estoque
        public void RemoverItem(int quantidade)
        {
            if (quantidade > 0 && quantidade <= QuantidadeEmEstoque)
                QuantidadeEmEstoque -= quantidade;
            else if (quantidade > QuantidadeEmEstoque)
                Console.WriteLine("Quantidade insuficiente no estoque.");
            else
                Console.WriteLine("A quantidade deve ser maior que zero.");
        }
    }
}
