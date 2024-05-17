using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anotacao
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }

        public Pessoa(string nome, int idade, float altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Altura: {Altura}cm";
        }
    }

    class Agenda
    {
        private List<Pessoa> pessoas;

        public Agenda()
        {
            pessoas = new List<Pessoa>();
        }

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa pessoa = new Pessoa(nome, idade, altura);
            pessoas.Add(pessoa);
            Console.WriteLine($"Pessoa '{nome}' armazenada na agenda.");
        }

        public void RemovePessoa(string nome)
        {
            Pessoa pessoa = BuscaPessoa(nome);
            if (pessoa != null)
            {
                pessoas.Remove(pessoa);
                Console.WriteLine($"Pessoa '{nome}' removida da agenda.");
            }
            else
            {
                Console.WriteLine($"Pessoa '{nome}' não encontrada na agenda.");
            }
        }

        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        public void ImprimeAgenda()
        {
            Console.WriteLine("Agenda:");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}