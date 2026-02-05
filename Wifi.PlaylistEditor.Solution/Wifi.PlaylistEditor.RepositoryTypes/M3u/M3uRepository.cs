
using PlaylistsNET.Content;
using PlaylistsNET.Models;
using Wifi.PlaylistEditor.BaseTypes;

namespace Wifi.PlaylistEditor.RepositoryTypes.M3u
{
    public class M3uRepository : IPlaylistRepository
    {
        public string Extension => ".m3u";

        public string Description => "M3U playlist format";

        public IPlaylist Load(string filePath)
        {
            throw new NotImplementedException();
        }

        public void Save(IPlaylist playlist, string filePath)
        {
            var playlistEntity = new M3uPlaylist();

            playlistEntity.IsExtended = true;

            playlistEntity.PlaylistEntries.Add(new M3uPlaylistEntry()
            {
                Album = "New album",
                AlbumArtist = "",
                Duration = TimeSpan.FromSeconds(175),
                Path = @"C:\Music\song.mp3",
                Title = "Track Title"
            });

            M3uContent content = new M3uContent();
            string text = content.ToText(playlistEntity);
            
        }
    }
}
