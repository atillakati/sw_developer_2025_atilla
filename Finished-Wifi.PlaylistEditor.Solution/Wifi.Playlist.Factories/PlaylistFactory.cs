using System;
using Wifi.Playlist.CoreTypes;

namespace Wifi.Playlist.Factories
{
    public class PlaylistFactory : IPlaylistFactory
    {
        public IPlaylist Create(string title, string author)
        {
            return Create(title, author, DateTime.Now);
        }

        public IPlaylist Create(string title, string author, DateTime createDate)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                return null;
            }

            return new CoreTypes.Playlist(title, author, createDate);
        }
    }
}
