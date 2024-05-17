namespace anotacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Armazenar Pessoa");
                Console.WriteLine("2 - Remover Pessoa");
                Console.WriteLine("3 - Buscar Pessoa");
                Console.WriteLine("4 - Imprimir Agenda");
                Console.WriteLine("0 - Sair");

                Console.Write("Escolha uma opção: ");
                int opcao;
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        return;
                    case 1:
                        Console.Write("Nome da pessoa: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        int idade;
                        if (!int.TryParse(Console.ReadLine(), out idade))
                        {
                            Console.WriteLine("Idade inválida. Tente novamente.");
                            continue;
                        }
                        Console.Write("Altura (em metros): ");
                        float altura;
                        if (!float.TryParse(Console.ReadLine(), out altura))
                        {
                            Console.WriteLine("Altura inválida. Tente novamente.");
                            continue;
                        }
                        agenda.ArmazenaPessoa(nome, idade, altura);
                        break;
                    case 2:
                        Console.Write("Nome da pessoa a ser removida: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemovePessoa(nomeRemover);
                        break;
                    case 3:
                        Console.Write("Nome da pessoa a ser buscada: ");
                        string nomeBuscar = Console.ReadLine();
                        Pessoa pessoaBuscada = agenda.BuscaPessoa(nomeBuscar);
                        if (pessoaBuscada != null)
                        {
                            Console.WriteLine($"Pessoa encontrada: {pessoaBuscada}");
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada na agenda.");
                        }
                        break;
                    case 4:
                        agenda.ImprimeAgenda();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}