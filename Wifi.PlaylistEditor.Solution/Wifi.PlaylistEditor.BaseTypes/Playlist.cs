namespace Wifi.PlaylistEditor.BaseTypes
{
    public class Playlist : IPlaylist
    {
        private string _title;
        private string _author;
        private List<IPlaylistItem> _items;


        public Playlist(string title, string author)
        {
            _title = title;
            _author = author;
            _items = new List<IPlaylistItem>();
        }

        public IEnumerable<IPlaylistItem> Items
        {
            get { return _items; }
        }

        public TimeSpan Duration
        {
            get
            {
                TimeSpan duration = TimeSpan.Zero;
                foreach (var item in _items)
                {
                    duration = duration.Add(item.Duration);
                }

                return duration;
            }
        }

        public string Author
        {
            get { return _author; }
        }

        public string Title
        {
            get { return _title; }
        }


        public void Add(IPlaylistItem newItem)
        {
            _items.Add(newItem);
        }

        public void Remove(IPlaylistItem itemToRemove)
        {
            _items.Remove(itemToRemove);
        }

        public void Clear()
        {
            _items.Clear();
        }
    }

}