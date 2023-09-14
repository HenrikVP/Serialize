namespace Serialize
{
    internal class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        //public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public int SampledFromId { get; set; }
    }
}
