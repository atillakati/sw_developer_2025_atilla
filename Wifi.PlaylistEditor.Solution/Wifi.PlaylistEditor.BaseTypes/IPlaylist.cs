
namespace Wifi.PlaylistEditor.BaseTypes
{
    public interface IPlaylist
    {
        string Author { get; }
        TimeSpan Duration { get; }
        IEnumerable<IPlaylistItem> Items { get; }
        string Title { get; }

        void Add(IPlaylistItem newItem);
        void Clear();
        void Remove(IPlaylistItem itemToRemove);
    }
}