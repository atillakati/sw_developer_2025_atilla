using Wifi.PlaylistEditor.BaseTypes;
using Wifi.PlaylistEditor.ItemTypes;

namespace Wifi.PlaylistEditor.Factories
{
    public class PlaylistItemFactory : IPlaylistItemFactory
    {
        public IPlaylistItem Create(string filePath)
        {
            IPlaylistItem item = null;

            var extension = Path.GetExtension(filePath);

            switch (extension)
            {
                case ".mp3":
                    item = new Mp3Item(filePath);
                    break;

                case ".jpg":
                    item = new PictureItem(filePath);
                    break;
            }

            return item;
        }
    }
}
