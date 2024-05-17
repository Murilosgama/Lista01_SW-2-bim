namespace listaproduto
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeProdutos gerenciador = new GerenciadorDeProdutos();

            // Adicionando produtos de exemplo
            gerenciador.AdicionarProduto("Caneta", 2.50, 10);
            gerenciador.AdicionarProduto("Caderno", 15.99, 5);
            gerenciador.AdicionarProduto("Borracha", 1.20, 20);

            // Apresentando produtos
            gerenciador.ApresentarProdutos();

            // Consultando um produto pelo nome
            Console.WriteLine("\nConsultando produto:");
            Produto produtoConsultado = gerenciador.ConsultarProduto("Caneta");
            if (produtoConsultado != null)
            {
                Console.WriteLine($"Produto encontrado: {produtoConsultado.Nome}, Preço: R${produtoConsultado.Preco:F2}, Quantidade em Estoque: {produtoConsultado.QuantidadeEmEstoque}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
    }
}