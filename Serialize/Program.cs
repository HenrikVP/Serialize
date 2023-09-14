namespace Serialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();

            //TODO Make a search in music/artist/album
            //TODO Call stack
            Io.Save(data);

            Data data2 = Io.Load<Data>();
            List<Album>? loa = data2.Albums;

            foreach (Album album in data2.Albums)
            {
                Console.WriteLine($"Album {album.Title}");
                foreach (var songId in album.SongIds)
                {
                    Console.WriteLine($"Song : {songId}");
                    foreach (var song in data2.Songs)
                    {
                        if (song.SongId == songId)
                        {
                            Console.WriteLine($"SongTitle: {song.Title}");
                            foreach (var artist in data2.Artists)
                            {
                                if (artist.ArtistId == song.ArtistId)
                                {
                                    Console.WriteLine($"Artist: {artist.Name}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}