namespace Wifi.PlaylistEditor.BaseTypes
{
    public interface IPlaylistItemFactory
    {
        IPlaylistItem Create(string filePath);
    }
}