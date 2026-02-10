
using PlaylistsNET.Content;
using PlaylistsNET.Models;
using Wifi.PlaylistEditor.BaseTypes;

namespace Wifi.PlaylistEditor.RepositoryTypes.M3u
{
    public class M3uRepository : IPlaylistRepository
    {
        private readonly IPlaylistItemFactory _playlistItemFactory;

        public M3uRepository(IPlaylistItemFactory playlistItemFactory)
        {
            _playlistItemFactory = playlistItemFactory;
        }

        public string Extension => ".m3u";

        public string Description => "M3U playlist format";

        public IPlaylist Load(string filePath)
        {
            //Playlistdatei öffnen und Entity Objekte holen
            M3uPlaylist playlistEntity = null;

            using (var stream = new StreamReader(filePath))
            {
                var content = new M3uContent();
                playlistEntity = content.GetFromStream(stream.BaseStream);
            }
            
            var itemPaths = playlistEntity.GetTracksPaths();

            //create Playlist
            var playlist = new Playlist(Path.GetFileNameWithoutExtension(filePath), "NoName");

            //create items
            foreach (var itempath in itemPaths)
            {
                var item = _playlistItemFactory.Create(itempath);  
                if(item != null)
                {
                    playlist.Add(item); 
                }
            }

            return playlist;
        }

        public void Save(IPlaylist playlist, string filePath)
        {
            var playlistEntity = new M3uPlaylist();

            playlistEntity.IsExtended = true;

            foreach (var item in playlist.Items)
            {
                //convert domain item => entity item
                var itemEntity = new M3uPlaylistEntry
                {
                    AlbumArtist = item.Artist,
                    Title = item.Title,
                    Duration = item.Duration,
                    Path = item.FilePath
                };

                playlistEntity.PlaylistEntries.Add(itemEntity);
            }                        

            M3uContent content = new M3uContent();
            string text = content.ToText(playlistEntity);
            
            File.WriteAllText(filePath, text);
        }
    }
}
