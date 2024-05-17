using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telefonista
{
    class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }

    class AgendaTelefonica
    {
        private List<Contato> contatos;

        public AgendaTelefonica()
        {
            contatos = new List<Contato>();
        }

        public void AdicionarContato(string nome, string telefone, string email)
        {
            Contato novoContato = new Contato(nome, telefone, email);
            contatos.Add(novoContato);
            Console.WriteLine("Contato adicionado com sucesso!");
        }

        public void RemoverContato(string nome)
        {
            Contato contatoParaRemover = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (contatoParaRemover != null)
            {
                contatos.Remove(contatoParaRemover);
                Console.WriteLine("Contato removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        public Contato BuscarContato(string nome)
        {
            return contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        public List<Contato> ObterContatos()
        {
            return contatos;
        }
    }
}