using System.Net.Security;

namespace Serialize
{
    internal class Data
    {
        public List<Album> Albums { get; set; } = new();
        public List<Song> Songs { get; set; }
        public List<Artist> Artists { get; set; }

        public Data() 
        {
            Song song1 = new() { SongId = 1, Title = "Thank u next", ArtistId = 1, SampledFromId = 2 };
            Song song2 = new() { SongId = 2, Title = "Song 2", ArtistId = 2 };
            Songs = new() { song1, song2 };
            Artist artist = new Artist() { ArtistId = 1, Name = "Arianna Grande" };
            Artist artist2 = new Artist() { ArtistId = 2, Name = "Blur" };
            Artists = new() { artist, artist2 };

            Album album = new Album()
            {
                Title = "Greatest Hits 1990-2020",
                SongIds = new() { 1, 2 }
            };

            Albums.Add(album);
        }
    }
}
