using System;

namespace Wifi.Playlist.CoreTypes
{
    public interface IPlaylistFactory
    {
        IPlaylist Create(string title, string author);

        IPlaylist Create(string title, string author, DateTime createDate);
    }
}
