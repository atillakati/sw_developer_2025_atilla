using System.Drawing;

namespace Wifi.PlaylistEditor.BaseTypes
{
    public interface IPlaylistItem
    {
        string Title {  get; }
        string Artist { get; }

        TimeSpan Duration { get; }

        string Path { get; }
        Bitmap Thumbnail { get; }
    }
}
