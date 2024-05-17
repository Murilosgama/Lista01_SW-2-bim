namespace telefonista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica();

            // Adicionando contatos de exemplo
            agenda.AdicionarContato("João", "936478134", "joao@example.com");
            agenda.AdicionarContato("Maria", "987654321", "maria@example.com");
            agenda.AdicionarContato("José", "934528352", "jose@example.com");

            // Testando a busca de contatos
            Console.WriteLine("\nBuscando contatos:");
            Contato contato1 = agenda.BuscarContato("Maria");
            if (contato1 != null)
            {
                Console.WriteLine($"Contato encontrado: {contato1.Nome}, {contato1.Telefone}, {contato1.Email}");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }

            // Testando a remoção de contatos
            Console.WriteLine("\nRemovendo contatos:");
            agenda.RemoverContato("João");
            agenda.RemoverContato("Inexistente");

            // Listando os contatos restantes
            Console.WriteLine("\nContatos restantes:");
            foreach (Contato contato in agenda.ObterContatos())
            {
                Console.WriteLine($"{contato.Nome}, {contato.Telefone}, {contato.Email}");
            }
        }
    }
}