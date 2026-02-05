using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.BaseTypes
{
    public interface IPlaylistRepository
    {
        string Extension { get; }
        string Description { get; }

        void Save(IPlaylist playlist, string filePath);

        IPlaylist Load(string filePath);
    }
}
