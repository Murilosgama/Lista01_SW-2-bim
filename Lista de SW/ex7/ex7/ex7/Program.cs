namespace locadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Playlist minhaPlaylist = new Playlist("Julia");

            // Adicionando músicas
            minhaPlaylist.AdicionarMusica(new Musica("Perfect", "Ed Sheeran", "Atlantic Records"));
            minhaPlaylist.AdicionarMusica(new Musica("Night changes", "One Direction", "Interscope Records"));
            minhaPlaylist.AdicionarMusica(new Musica("Pillowtalk", "Zayn Malik", "Universal Music Latin Entertainment"));

            // Tocando música aleatória
            minhaPlaylist.TocarMusicaAleatoria();
        }
    }
}