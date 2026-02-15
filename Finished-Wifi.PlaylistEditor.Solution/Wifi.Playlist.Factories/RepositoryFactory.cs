using PlaylistsNET.Content;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.Playlist.CoreTypes;
using Wifi.Playlist.Repositories;
using Wifi.Playlist.Repositories.Json;

namespace Wifi.Playlist.Factories
{
    public class RepositoryFactory : IRepositoryFactory
    {        
        private readonly IPlaylistFactory _playlistFactory;
        private IPlaylistItemFactory _itemFactory;

        public RepositoryFactory(IPlaylistFactory playlistFactory, IPlaylistItemFactory itemFactory)
        {
            _playlistFactory = playlistFactory;
            _itemFactory = itemFactory;
        }

        public IEnumerable<IFileInfo> AvailableTypes => new IFileInfo[] 
        {   
            new M3uRepository(null),
            new PlsRepository(),
            new WplRepository(),
            new ZplRepository(),
            new JsonRepository(null),
        };

        public IPlaylistRepository Create(string fileName)
        {
            IPlaylistRepository repository = null;

            if (string.IsNullOrEmpty(fileName))
            {
                return repository;
            }

            var ext = Path.GetExtension(fileName);

            switch (ext)
            {
                case ".m3u":
                    repository = new M3uRepository(_itemFactory);
                    break;

                case ".pls":
                    repository = new PlsRepository(_playlistFactory, _itemFactory);
                    break;

                case ".wpl":
                    repository = new WplRepository(_playlistFactory, _itemFactory);
                    break;

                case ".zpl":
                    repository = new ZplRepository(_playlistFactory, _itemFactory);
                    break;
                
                case ".wifi":
                    repository = new JsonRepository(_itemFactory);
                    break;
            }

            return repository;
        }
    }
}
