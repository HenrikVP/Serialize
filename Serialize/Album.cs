namespace Serialize
{
    internal class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public List<int> SongIds { get; set; }
    }
}
