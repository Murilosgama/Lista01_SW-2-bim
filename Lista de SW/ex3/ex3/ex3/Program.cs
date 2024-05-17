namespace corretora
{
    class Program
    {
        static void Main(string[] args)
        {
            CorretoraImoveis corretora = new CorretoraImoveis();

            int opcao;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir Imóvel");
                Console.WriteLine("2. Alterar Preço do Imóvel");
                Console.WriteLine("3. Listar Imóveis");
                Console.WriteLine("4. Calcular Valor Médio dos Imóveis");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Endereço do imóvel: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Preço do imóvel: ");
                        double preco = double.Parse(Console.ReadLine());
                        Console.Write("Tipo do imóvel: ");
                        string tipo = Console.ReadLine();
                        corretora.InserirImovel(endereco, preco, tipo);
                        break;
                    case 2:
                        Console.Write("Endereço do imóvel: ");
                        string enderecoAlterarPreco = Console.ReadLine();
                        Console.Write("Novo preço do imóvel: ");
                        double novoPreco = double.Parse(Console.ReadLine());
                        corretora.AlterarPreco(enderecoAlterarPreco, novoPreco);
                        break;
                    case 3:
                        corretora.ListarImoveis();
                        break;
                    case 4:
                        double valorMedio = corretora.CalcularValorMedio();
                        Console.WriteLine($"O valor médio dos imóveis é R${valorMedio:F2}");
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 5);
        }
    }
}