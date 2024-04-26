using Estoque;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso da classe Produto
        Produto produto = new Produto("Caneta", 2.5, 50);

        Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}, Quantidade em estoque: {produto.QuantidadeEmEstoque}");

        // Adicionando 10 unidades ao estoque
        produto.AdicionarItem(10);
        Console.WriteLine($"Nova quantidade em estoque: {produto.QuantidadeEmEstoque}");

        // Removendo 5 unidades do estoque
        produto.RemoverItem(5);
        Console.WriteLine($"Nova quantidade em estoque: {produto.QuantidadeEmEstoque}");

        // Tentando remover mais itens do que o disponível em estoque
        produto.RemoverItem(100);
    }
}