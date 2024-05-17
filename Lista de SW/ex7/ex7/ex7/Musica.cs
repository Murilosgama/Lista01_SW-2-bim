using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadora
{
    class Musica
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Gravadora { get; set; }

        public Musica(string nome, string autor, string gravadora)
        {
            Nome = nome;
            Autor = autor;
            Gravadora = gravadora;
        }
    }

    class Playlist
    {
        private List<Musica> musicas;
        private string donoPlaylist;

        public Playlist(string dono)
        {
            musicas = new List<Musica>();
            donoPlaylist = dono;
        }

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
            Console.WriteLine($"Música '{musica.Nome}' adicionada à playlist de {donoPlaylist}.");
        }

        public void TocarMusicaAleatoria()
        {
            if (musicas.Count == 0)
            {
                Console.WriteLine("Playlist vazia. Adicione músicas antes de reproduzir.");
                return;
            }

            Random random = new Random();
            int indiceMusicaAleatoria = random.Next(0, musicas.Count);
            Musica musicaAleatoria = musicas[indiceMusicaAleatoria];

            Console.WriteLine($"Tocando música aleatória: '{musicaAleatoria.Nome}'");
        }
    }
}