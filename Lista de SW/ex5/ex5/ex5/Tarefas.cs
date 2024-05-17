using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefas
{
    class Tarefa
    {
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }

        public Tarefa(string descricao, DateTime dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }
    }

    class GerenciadorDeTarefas
    {
        private List<Tarefa> tarefas;

        public GerenciadorDeTarefas()
        {
            tarefas = new List<Tarefa>();
        }

        public void AdicionarTarefa(string descricao, DateTime dataVencimento)
        {
            Tarefa novaTarefa = new Tarefa(descricao, dataVencimento);
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        public void RemoverTarefa(string descricao)
        {
            Tarefa tarefaParaRemover = tarefas.Find(t => t.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
            if (tarefaParaRemover != null)
            {
                tarefas.Remove(tarefaParaRemover);
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        public void ListarTarefas()
        {
            Console.WriteLine("Lista de Tarefas:");
            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine($"Descrição: {tarefa.Descricao} | Data de Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
            }
        }

        public bool VerificarTarefaHoje(string descricao)
        {
            Tarefa tarefa = tarefas.Find(t => t.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
            if (tarefa != null)
            {
                return tarefa.DataVencimento.Date == DateTime.Today;
            }
            return false;
        }
    }
}