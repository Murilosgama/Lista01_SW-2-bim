namespace Tarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

            // Adicionando tarefas de exemplo
            gerenciador.AdicionarTarefa("Estudar para o exame", new DateTime(2024, 5, 17));
            gerenciador.AdicionarTarefa("Fazer compras", new DateTime(2024, 5, 16));
            gerenciador.AdicionarTarefa("Ir à academia", new DateTime(2024, 5, 15));
            gerenciador.AdicionarTarefa("Fazer os exercios de C#", new DateTime(2024, 5, 16));
            gerenciador.AdicionarTarefa("Conexão de API (Feteps)", new DateTime(2024, 5, 17));

            // Listando as tarefas
            gerenciador.ListarTarefas();

            // Verificando se uma tarefa deve ser executada hoje
            Console.WriteLine("\nVerificando tarefas para hoje:");
            Console.WriteLine("Estudar para o exame: " + (gerenciador.VerificarTarefaHoje("Estudar para o exame") ? "Sim" : "Não"));
            Console.WriteLine("Fazer compras: " + (gerenciador.VerificarTarefaHoje("Fazer compras") ? "Sim" : "Não"));
            Console.WriteLine("Ir à academia: " + (gerenciador.VerificarTarefaHoje("Ir à academia") ? "Sim" : "Não"));
            Console.WriteLine("Fazer os exercios de C#: " + (gerenciador.VerificarTarefaHoje("Fazer os exercios de C#") ? "Sim" : "Não"));
        }
    }
}