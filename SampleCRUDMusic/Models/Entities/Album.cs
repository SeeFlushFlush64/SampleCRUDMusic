using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCRUDMusic.Models.Entities
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string AlbumPicture { get; set; }
        public ICollection<Track> Tracks { get; set; } = new List<Track>();
    }
}
