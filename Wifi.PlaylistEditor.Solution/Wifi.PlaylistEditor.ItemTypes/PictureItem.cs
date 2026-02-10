using System.Drawing;
using Wifi.PlaylistEditor.BaseTypes;

namespace Wifi.PlaylistEditor.ItemTypes
{
    public class PictureItem : IPlaylistItem
    {
        private readonly string _filePath; 
        private string _title;
        private Bitmap _thumbnail;

        internal PictureItem() { }

        public PictureItem(string filePath)
        {
            _filePath = filePath;
            _title = Path.GetFileNameWithoutExtension(_filePath);
            _thumbnail = (Bitmap)Image.FromFile(_filePath)
                              .ResizeAndFill(125, 125, Color.White);
        }        

        public string Title { get => _title; }
        public string Artist { get => "Unknown"; }
        public TimeSpan Duration { get => TimeSpan.FromSeconds(10); }
        public string FilePath { get => _filePath; }
        public Bitmap Thumbnail { get => _thumbnail; }

        public string Description { get => "JPG Picture file"; }
        public string Extension { get => ".jpg"; }

        public override string ToString()
        {
            return $"{_title}";
        }
    }
}
