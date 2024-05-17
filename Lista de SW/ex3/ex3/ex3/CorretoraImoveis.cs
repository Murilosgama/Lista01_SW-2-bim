using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corretora
{
    class CorretoraImoveis
    {
        // Definindo uma estrutura para representar um imóvel
        struct Imovel
        {
            public string endereco;
            public double preco;
            public string tipo;

            public Imovel(string endereco, double preco, string tipo)
            {
                this.endereco = endereco;
                this.preco = preco;
                this.tipo = tipo;
            }
        }

        // Lista para armazenar os imóveis
        private List<Imovel> imoveis;

        // Construtor
        public CorretoraImoveis()
        {
            imoveis = new List<Imovel>();
        }

        // Método para inserir um imóvel
        public void InserirImovel(string endereco, double preco, string tipo)
        {
            Imovel novoImovel = new Imovel(endereco, preco, tipo);
            imoveis.Add(novoImovel);
            Console.WriteLine("Imóvel inserido com sucesso!");
        }

        // Método para alterar o preço de um imóvel
        public void AlterarPreco(string endereco, double novoPreco)
        {
            Imovel imovel = imoveis.FirstOrDefault(i => i.endereco == endereco);
            if (imovel.endereco != null)
            {
                imovel.preco = novoPreco;
                Console.WriteLine($"Preço do imóvel alterado para R${novoPreco:F2}");
            }
            else
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
        }

        // Método para listar todos os imóveis
        public void ListarImoveis()
        {
            Console.WriteLine("Lista de Imóveis Disponíveis:");
            foreach (Imovel imovel in imoveis)
            {
                Console.WriteLine($"Endereço: {imovel.endereco} | Preço: R${imovel.preco:F2} | Tipo: {imovel.tipo}");
            }
        }

        // Método para calcular o valor médio dos imóveis
        public double CalcularValorMedio()
        {
            if (imoveis.Count == 0)
            {
                return 0;
            }

            double somaPrecos = 0;
            foreach (Imovel imovel in imoveis)
            {
                somaPrecos += imovel.preco;
            }

            return somaPrecos / imoveis.Count;
        }
    }
}