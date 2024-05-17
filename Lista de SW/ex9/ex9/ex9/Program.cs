namespace editora
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Livro livro = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien");
                Console.WriteLine($"Título do livro: {livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Erro ao criar livro: {e.Message}");
            }
        }
    }
}