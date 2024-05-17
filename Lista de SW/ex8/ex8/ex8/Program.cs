namespace fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabricante fabricante = new Fabricante("ABC Eletrônicos", "123 Main St", "São Paulo");
            Produto produto = new Produto("Celular", fabricante, 999.99);

            Console.WriteLine($"Nome do produto: {produto.Nome}");
            Console.WriteLine($"Fabricante: {produto.Fabricante.Nome}");
            Console.WriteLine($"Preço: R${produto.Preco:F2}");
        }
    }
}