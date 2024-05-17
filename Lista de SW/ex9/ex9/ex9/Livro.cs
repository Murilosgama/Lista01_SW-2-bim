using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace editora
{
    class Livro
    {
        private string titulo;
        private string autor;

        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    titulo = value;
                }
                else
                {
                    throw new ArgumentException("O título do livro não pode estar vazio.");
                }
            }
        }

        public string Autor
        {
            get { return autor; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    autor = value;
                }
                else
                {
                    throw new ArgumentException("O autor do livro não pode estar vazio.");
                }
            }
        }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }

}